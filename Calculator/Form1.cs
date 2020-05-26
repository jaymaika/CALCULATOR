using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Calculator
{
    public partial class Form1 : Form
    {
        int num_1 = 1;
        int num_2 = 2;
        int num_3 = 3;
        int num_4 = 4;
        int num_5 = 5;
        int num_6 = 6;
        int num_7 = 7;
        int num_8 = 8;
        int num_9 = 9;
        int num_0 = 0;
        float num, answer; 
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_0;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_4;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_5;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_6;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_7;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_8;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + num_9;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    answer = num + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 2:
                    answer = num - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 3:
                    answer = num * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 4:
                    answer = num / float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }
        //public static double Evaluate(String expression)
        //{
        //    try
        //    {
        //        System.Data.DataTable table = new System.Data.DataTable();
        //        table.Columns.Add("expression", string.Empty.GetType(), expression);
        //        System.Data.DataRow row = table.NewRow();
        //        table.Rows.Add(row);
        //        return double.Parse((string)row["expression"]);
        //    }
        //    catch
        //    {
        //        return -1;
        //    }
        //}
        private void button17_Click(object sender, EventArgs e)
        {
            //Evaluate(textBox1.Text);
            compute(count);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (Text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            
            } 
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
