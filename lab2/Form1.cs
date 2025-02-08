using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";

        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public int Fibonacci(int n)
        {
            if (n < 0) throw new ArgumentException("Fibonacci sequence is not defined for negative numbers.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void btnFibonacii_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            int result = Fibonacci(number);
            lblFibo.Text = $"Fibonacii: {result}";

        }
        public double Power(double baseNo, double exponent)
        {
            if (exponent == 0) return 1;
            if (exponent < 0) return 1 / Power(baseNo, -exponent);
            return baseNo * Power(baseNo, exponent - 1);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseNo) && int.TryParse(txtExpo.Text, out int exponent))
            {
                double result = Power(baseNo, exponent);
                lblPower.Text = $"Result: {result}";
            }
            else
            {
                lblPower.Text = "Error: Enter valid numbers!";
            }
        }
    }
}
