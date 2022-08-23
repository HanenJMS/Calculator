using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        float num1, ans=0;
        bool isDecimal = false;
        public enum Calculation
        {
            Add, Subtract, Multiply, Divide, None
        }
        Calculation tool;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0+0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(!isDecimal)
            {
                textBox1.Text += ".";
                isDecimal = true;
            }
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if(num1 == 0)
            {
                num1 = float.Parse(textBox1.Text);
            }
            Compute();
        }

        private void Compute()
        {
            switch (tool)
            {
                case Calculation.Add:
                    ans += num1;
                    break;
                case Calculation.Subtract:
                    ans -= num1;
                    break;
                case Calculation.Multiply:
                    ans *= num1;
                    break;
                case Calculation.Divide:
                    ans /= num1;
                    break;
                default:
                    break;
            }
            textBox1.Text = ans.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            ResetText();
            tool = Calculation.Add;
        }

        private void ResetText()
        {
            if(textBox1.Text != "")
            {
                ans = float.Parse(textBox1.Text);
                num1 = 0;
                isDecimal = false;
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            ResetText();
            tool = Calculation.Subtract;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResetText();
            tool = Calculation.None;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            ResetText();
            tool = Calculation.Multiply;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            ResetText();
            tool = Calculation.Divide;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
