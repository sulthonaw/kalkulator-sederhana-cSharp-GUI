using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhanaWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string math = textBox1.Text;

            if(math.Length > 0)
            {
                switch (math[math.Length - 1])
                {
                    case '+':
                    case '-':
                        math += 0;
                        break;
                    case '/':
                    case '*':
                        math += 1;
                        break;
                }

                string value = new DataTable().Compute(math, null).ToString();
                textBox1.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
           textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }
    }
}
