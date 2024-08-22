using System;

namespace Coldi
{
    public partial class CalculatorForm : Form
    {
        string actionWithNums;
        string num1;
        bool startNum2;
        Button button;

        double doubleNum, result;

        public CalculatorForm()
        {
            InitializeComponent();
            startNum2 = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                startNum2 = false;
                textBox1.Text = "0";
            }

            button = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
            {
                textBox1.Text += button.Text;
            }


        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void actionBTN_Click(object sender, EventArgs e)
        {
            button = (Button)sender;

            actionWithNums = button.Text;

            num1 = textBox1.Text;
            startNum2 = true;



        }

        private void equally_Click(object sender, EventArgs e)
        {
            double doubleNum1, doubleNum2, result;

            result = 0;

            doubleNum1 = double.Parse(num1);
            doubleNum2 = double.Parse(textBox1.Text);

            if (actionWithNums == "+")
            {
                result = doubleNum1 + doubleNum2;
            }
            if (actionWithNums == "-")
            {
                result = doubleNum1 - doubleNum2;
            }
            if (actionWithNums == "*")
            {
                result = doubleNum1 * doubleNum2;
            }
            if (actionWithNums == "/")
            {
                result = doubleNum1 / doubleNum2;
            }
            if (actionWithNums == "%")
            {
                result = doubleNum1 * doubleNum2 / 100;
            }

            actionWithNums = "=";
            startNum2 = true;
            textBox1.Text = result.ToString();

        }

        private void negativeBTN_Click(object sender, EventArgs e)
        {         
            doubleNum = Convert.ToDouble(textBox1.Text);
            result = -doubleNum;
            textBox1.Text = result.ToString();
        }

        private void DotBTN_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void PowBTN_Click(object sender, EventArgs e)
        {           
            doubleNum = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(doubleNum, 2);
            textBox1.Text = result.ToString();
        }
    }
}
