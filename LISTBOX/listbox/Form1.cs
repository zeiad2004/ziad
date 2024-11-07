using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty )
            {

            }
            else 
            { 
            listBox2.Items.Add(textBox2.Text);
            listBox2.Items.Add("---------------------------------------------------------------------------------------------------------------------------");
            textBox2.Text = string.Empty;
            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex == -1)
            {

            }
            else { listBox2.Items.RemoveAt(listBox2.SelectedIndex); }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
