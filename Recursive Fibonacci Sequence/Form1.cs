namespace Recursive_Fibonacci_Sequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFibonacci(int n)
        {
            if (n <= 1) return n;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        private void btnCalculateSequence_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFibonacci(number);
            lblResult.Text = $"Result: {result}";
        }
    }
}
