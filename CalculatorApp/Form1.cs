using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userinput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "0";
            Display.Text += userinput;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "1";
            Display.Text += userinput;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "2";
            Display.Text += userinput;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "3";
            Display.Text += userinput;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "4";
            Display.Text += userinput;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "5";
            Display.Text += userinput;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "6";
            Display.Text += userinput;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "7";
            Display.Text += userinput;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "8";
            Display.Text += userinput;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userinput += "9";
            Display.Text += userinput;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userinput = "";
            Display.Text = "";
            result = 0.0;
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            switch(function)
            {
                case '+': result = firstNum + secondNum;
                    break;
                case '-': result = firstNum - secondNum;
                    break;
                case '*': result = firstNum * secondNum;
                    break;
                case '/': result = firstNum / secondNum;
                    break;
            }
            string theresult = Convert.ToString(result);
            Display.Text = theresult;
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
        }
    }
}
