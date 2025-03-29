namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] numbers)
        {
            Array.Sort(numbers);
            int num;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - ( 1 + i ); j++)
                {
                    if (numbers[j] > numbers[j] + 1)
                    {
                        num = numbers [j + 1];
                        numbers [j + 1 ] = numbers [j];
                        numbers [j] = num;  
                    }
                }
            }
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumber = BubbleSort(numbers);
            listBoxResults.DataSource = sortedNumber;
        }
        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
