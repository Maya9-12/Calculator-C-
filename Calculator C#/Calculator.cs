using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C_
{
    public partial class Calculator : Form
    {
        string input = string.Empty;        //Stores user input
        string value1 = string.Empty;       //Stores first operand
        string value2 = string.Empty;       //Stores second operand
        char operation;                     //Stores operation
        double result = 0.0;                //Stores the result

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                this.textBox1.Text = "";
                input += ".";
                this.textBox1.Text += input;
            }

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            value2 = input;
            double num1, num2;
            double.TryParse(value1, out num1);
            double.TryParse(value2, out num2);

            if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num2 * num1;
                textBox1.Text = result.ToString();
            }
            else if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Error. Cannot divide by 0";
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.value1 = string.Empty;
            this.value2 = string.Empty;

        }
    }
}