using System;
using System.Windows.Forms;

namespace Broadway.DesktopApp
{
    public partial class Calculator : Form
    {
        private string firstNumber;

        private char operators;
        private string result;
        private string secondNumber;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            if (!textBox1.Text.Contains(".") || btn.Text != ".")
            {
                secondNumber = secondNumber + btn.Text;

                textBox1.Text = secondNumber;
            }
        }

        private void char_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            firstNumber = secondNumber;
            secondNumber = "";
            textBox1.Text = "";
            operators = btn.Text[0];
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var firstNum = Convert.ToDouble(firstNumber);
            var secondNum = Convert.ToDouble(secondNumber);
            double res = 0;
            switch (operators)
            {
                case '+':
                    res = firstNum + secondNum;
                    break;
                case '-':
                    res = firstNum - secondNum;
                    break;
                case 'x':
                    res = firstNum * secondNum;
                    break;
                case '/':
                    res = firstNum / secondNum;
                    break;
            }

            result = res.ToString();
            textBox1.Text = result;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            result = "";
            operators = 'a';
            textBox1.Text = "";
        }
    }
}