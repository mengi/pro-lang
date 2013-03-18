using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int a, b;
        double x, y;
        string d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            d = "+";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            d = "-";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            d = "*";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            a = Convert.ToInt32(textBox1.Text);
           
            d = "/";
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            float c;
            b = Convert.ToInt32(textBox1.Text);
            y = Convert.ToDouble(textBox1.Text);
            if (d == "+")
            {
                textBox1.Text = Convert.ToString(a + b);
            }
            if (d == "-")
            {
                textBox1.Text = Convert.ToString(a - b);
            }
            if (d == "*")
            {
                textBox1.Text = Convert.ToString(a * b);
            }
            if (d == "/")
            {
                c = (float)b;
                textBox1.Text = Convert.ToString(a / c);
            }
            if (d == "^")
            {
                textBox1.Text = Convert.ToString(Math.Pow(x, y));
                
            }
            a = 0;
            b = 0;
            d = " ";
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            d = "";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(x));


        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            d = "^";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Ceiling(x));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(Math.Sin(x));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(Math.Cos(x));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(Math.Tan(x));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            float v;
            x = Convert.ToDouble(textBox1.Text);
            v = (float)x;
            textBox1.Text = Convert.ToString(Math.Abs(v));

        }

        private void button24_Click(object sender, EventArgs e)
        {
            float v;
            a = Convert.ToInt32(textBox1.Text);
            v = (float)a;
            textBox1.Text = Convert.ToString(1 / v);
        }
    }
}
