namespace Custom_Decending_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
           
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumber = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumber;
        }
    }
}
