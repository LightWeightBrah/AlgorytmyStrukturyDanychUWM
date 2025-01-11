using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KodowanieHuffmana
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void OnEncodeButtonClick(object sender, EventArgs e)
        {
            string input = this.inputEncodingText.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Wprowadź tekst do zakodowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] characters;
            int[] frequencies;
            this.CalculateFrequencies(input, out characters, out frequencies);

            HuffmanNode root = this.BuildHuffmanTree(characters, frequencies);

            string[] codes = new string[characters.Length];
            this.GenerateCodes(root, "", codes, characters);

            this.letterList.Items.Clear();
            for (int i = 0; i < characters.Length; i++)
            {
                this.letterList.Items.Add($"{characters[i]}: {codes[i]}");
            }

            string encodedText = this.EncodeText(input, characters, codes);
            this.outputText.Text = encodedText;
        }

        private void CalculateFrequencies(string text, out char[] characters, out int[] frequencies)
        {
            List<char> charList = new List<char>();
            List<int> freqList = new List<int>();

            foreach (char c in text)
            {
                int index = charList.IndexOf(c);
                if (index == -1)
                {
                    charList.Add(c);
                    freqList.Add(1);
                }
                else
                {
                    freqList[index]++;
                }
            }

            characters = charList.ToArray();
            frequencies = freqList.ToArray();
        }

        private HuffmanNode BuildHuffmanTree(char[] characters, int[] frequencies)
        {
            List<HuffmanNode> huffmanNodes = new List<HuffmanNode>();

            for (int i = 0; i < characters.Length; i++)
            {
                huffmanNodes.Add(new HuffmanNode { symbol = characters[i], frequency = frequencies[i] });
            }

            while (huffmanNodes.Count > 1)
            {
                huffmanNodes = huffmanNodes.OrderBy(n => n.frequency).ToList();
                HuffmanNode left = huffmanNodes[0];
                HuffmanNode right = huffmanNodes[1];

                HuffmanNode parent = new HuffmanNode
                {
                    symbol = '\0',
                    frequency = left.frequency + right.frequency,
                    left = left,
                    right = right
                };

                huffmanNodes.Remove(left);
                huffmanNodes.Remove(right);
                huffmanNodes.Add(parent);
            }

            return huffmanNodes[0];
        }

        private void GenerateCodes(HuffmanNode huffmanNode, string currentCode, string[] codes, char[] characters)
        {
            if (huffmanNode == null)
                return;

            if (huffmanNode.left == null && huffmanNode.right == null)
            {
                int index = Array.IndexOf(characters, huffmanNode.symbol);
                codes[index] = currentCode;
                return;
            }

            this.GenerateCodes(huffmanNode.left, currentCode + "0", codes, characters);
            this.GenerateCodes(huffmanNode.right, currentCode + "1", codes, characters);
        }

        private string EncodeText(string text, char[] characters, string[] codes)
        {
            string encodedText = "";

            foreach (char c in text)
            {
                int index = Array.IndexOf(characters, c);
                encodedText += codes[index];
            }

            return encodedText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

        
}
