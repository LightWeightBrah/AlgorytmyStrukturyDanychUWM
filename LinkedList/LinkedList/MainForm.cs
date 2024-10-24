using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class MainForm : Form
    {
        private List<LinkedList> linkedLists = new List<LinkedList>();
        private int indexOfCurrentList;

        public MainForm()
        {
            this.InitializeComponent();

            /*LinkedList list = new LinkedList(new int[] {2, 5, 3, 5, 4, 6, 7, 8, 9, 10 });
            list.PrintList();
            //list.AddFirst(-5);
            //list.AddLast(-3);
            //list.RemoveFirst();
            list.RemoveLast();
            list.PrintList();*/
        }

        private void OnCreateListButtonClick(object sender, EventArgs e)
        {
            int[] values;
            try
            {
                values = this.GetIntArrayFromTextBox(this.numbersInListTextBox);
                this.linkedLists.Add(new LinkedList(values));
                this.UpdateListsLabelText();
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Napotkano blad!\n{exception.Message}");
            }
        }

        private void UpdateListsLabelText()
        {
            string listString = "";
            for (int i = 0; i < this.linkedLists.Count; i++)
            {
                listString += $"lista {i + 1}:\n{this.linkedLists[i].ToString()}\n\n";
            }

            this.listLabelText.Text = listString;
        }

        private int[] GetIntArrayFromTextBox(TextBox textBox)
        {
            string[] stringValues = textBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] values = Array.ConvertAll(stringValues, int.Parse);
            return values;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OnAddLastButtonClick(object sender, EventArgs e)
        {
            int[] values;
            try
            {
                values = this.GetIntArrayFromTextBox(this.numbersToAddTextBox);
                this.linkedLists[this.indexOfCurrentList].AddLast(values);
                this.UpdateListsLabelText();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Napotkano blad!\n{exception.Message}");
            }
        }
        private void OnAddFirstButtonClick(object sender, EventArgs e)
        {
            int[] values;
            try
            {
                values = this.GetIntArrayFromTextBox(this.numbersToAddTextBox);
                this.linkedLists[this.indexOfCurrentList].AddFirst(values);
                this.UpdateListsLabelText();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Napotkano blad!\n{exception.Message}");
            }
        }

        //TODO: dodac usuniecie listy gdy jest pusta
        private void OnRemoveFirstButtonClick_Click(object sender, EventArgs e)
        {
            try
            {
                this.linkedLists[this.indexOfCurrentList].RemoveFirst();
                this.UpdateListsLabelText();
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Nie ma utworzonych zadnych list");
            }
        }
        private void OnRemoveLastButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.linkedLists[this.indexOfCurrentList].RemoveLast();
                this.UpdateListsLabelText();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Nie ma utworzonych zadnych list");
            }
        }
        private void OnNumericValueChanged(object sender, EventArgs e)
        {
            this.indexOfCurrentList = (int)this.numericUpDown.Value;
        }
        private void OnRemoveListButtonClick(object sender, EventArgs e)
        {
            this.linkedLists.RemoveAt(this.indexOfCurrentList);
            this.UpdateListsLabelText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void numbersToAddTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
