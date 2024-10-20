using System.Diagnostics;

namespace SortowaniePracaNr2
{
    public partial class MainForm : Form
    {
        private int[] arrayToSort = null;
        private Stopwatch timer = new Stopwatch();
        private SORTING_TYPE sorting = SORTING_TYPE.NULL;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void Sort(SORTING_TYPE sortingType)
        {
            try
            {
                if (this.arrayToSort == null)
                {
                    throw new Exception("Nie ma liczb do posortowania, tablica jest pusta!");
                }

                this.timer.Start();
                int[] sortedArray = null;
                string sortingName = "";

                switch (sortingType)
                {
                    case SORTING_TYPE.BUBBLE:
                        sortedArray = Sorter.BubbleSort(this.arrayToSort);
                        sortingName = "bubble";
                        break;

                    case SORTING_TYPE.INSERTION:
                        sortedArray = Sorter.InsertionSort(this.arrayToSort);
                        sortingName = "insertion";
                        break;

                    case SORTING_TYPE.MERGE:
                        sortedArray = Sorter.MergeSort(this.arrayToSort);
                        sortingName = "merge";
                        break;

                    case SORTING_TYPE.QUICK:
                        sortedArray = Sorter.QuickSort(this.arrayToSort);
                        sortingName = "quick";
                        break;

                    case SORTING_TYPE.COUNTING:
                        sortedArray = Sorter.CountingSort(this.arrayToSort);
                        sortingName = "counting";
                        break;

                }
                this.timer.Stop();

                string resultText = String.Join(" ", sortedArray);
                this.sortedNumberText.Text = resultText;
                this.sortingTimeText.Text = $"Czas {sortingName} sort wynosil: {this.timer.Elapsed}";
                this.timer.Reset();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OnConvertButtonClick(object sender, EventArgs e)
        {
            string[] numberStringArray = this.numbersToConvertText.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            this.arrayToSort = new int[numberStringArray.Length];
            for (int i = 0; i < numberStringArray.Length; i++)
            {
                this.arrayToSort[i] = Convert.ToInt32(numberStringArray[i]);
            }

            this.numbersToSortText.Text = string.Join(" ", this.arrayToSort);
            this.sortedNumberText.Text = "";
            this.sortingTimeText.Text = "";
        }

        private void OnGenerateButtonClick(object sender, EventArgs e)
        {
            int amount = (int)this.numericAmountText.Value;
            this.arrayToSort = new int[amount];
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                this.arrayToSort[i] = random.Next(1, 101);
            }

            string resultText = String.Join(" ", this.arrayToSort);
            this.numbersToSortText.Text = resultText;
            this.sortedNumberText.Text = "";
            this.sortingTimeText.Text = "";
        }

        private void OnBubbleSortButtonClick(object sender, EventArgs e)
        {
            this.Sort(SORTING_TYPE.BUBBLE);
        }

        private void OnInsertionSortButtonClick(object sender, EventArgs e)
        {
            this.Sort(SORTING_TYPE.INSERTION);
        }

        private void OnMergeSortButtonClick(object sender, EventArgs e)
        {
            this.Sort(SORTING_TYPE.MERGE);
        }

        private void OnQuickSortButtonClick(object sender, EventArgs e)
        {
            this.Sort(SORTING_TYPE.QUICK);
        }

        private void OnCountingSortButtonClick(object sender, EventArgs e)
        {
            this.Sort(SORTING_TYPE.COUNTING);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}