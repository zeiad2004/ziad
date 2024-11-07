using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double operation2 = 0;
        bool operation3 = false;
        double memoryValue = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button zero = (Button)sender;
            if (textBox1.Text == "0" || operation3 == true) { textBox1.Clear(); }

            if (zero.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text + zero.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + zero.Text;
            }
            operation3 = false;
        }

        private void button15_Click(object sender, EventArgs e) 
        {
            Button zero = (Button)sender;
            operation = zero.Text;
            operation2 = double.Parse(textBox1.Text);
            operation3 = true;
        }

        private void button16_Click(object sender, EventArgs e)      
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (operation2 + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (operation2 - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (operation2 * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox1.Text) == 0) 
                    {
                        MessageBox.Show("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        textBox1.Text = (operation2 / double.Parse(textBox1.Text)).ToString();
                    }
                    break;
            }
            operation2 = 0;
            operation3 = false;
        }

        private void button11_Click(object sender, EventArgs e) 
        {
            textBox1.Clear();
            operation2 = 0;
            operation3 = false;
        }

        private void button20_Click(object sender, EventArgs e) 
        {
            textBox1.Clear();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            memoryValue += double.Parse(textBox1.Text);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            memoryValue = double.Parse(textBox1.Text);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}