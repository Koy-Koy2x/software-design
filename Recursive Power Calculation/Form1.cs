using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recursive_Power_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursivePowerCalculation(int n)
        {
            if (n <= 1) return 1;
           return n * RecursivePowerCalculation (n - 1);    
        }
        private void btnCalculatePower(object sender, EventArgs e)
        {
        
            int Base = int.Parse(txtInputBase.Text);
            int Exponent = int.Parse(txtInputExponent.Text);
            int result = Exponent * RecursivePowerCalculation(Base + 1) ;
            lblResult.Text = $"Result: {result}";
        }
        }
}
