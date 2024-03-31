using System;
using System.Windows.Forms;
using OOPProjectSALINAS;

namespace OOPProjectSALINAS
{
    public partial class calculator : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";

        public calculator()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (!results.Text.Contains("."))
                results.Text += ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(results.Text);
            operation = button.Text;
            results.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double result = 0;
            double secondNumber;

            try
            {
                secondNumber = double.Parse(results.Text);

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return; 
                        }
                        break;
                }
                results.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large or too small.");
            }

        }

        private void one_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(results.Text);
            operation = button.Text;
            results.Text = "";
        }

        private void four_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(results.Text);
            operation = button.Text;
            results.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            results.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            results.Text += button.Text;
        }

        private void division_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(results.Text);
            operation = button.Text;
            results.Text = "";
        }

        private void clearclear_Click(object sender, EventArgs e)
        {
            results.Text = "";
        }
    }
}
