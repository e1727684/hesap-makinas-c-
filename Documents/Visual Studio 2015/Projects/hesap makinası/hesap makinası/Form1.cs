﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinası
{
    public partial class Form1 : Form
    {
        double x, y;
        string z;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//1 tuşu
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

        private void button2_Click(object sender, EventArgs e)//toplama
        {
            x = Convert.ToDouble(textBox1.Text);
            z = "+";
            textBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)//bölme
        {
            x = Convert.ToDouble(textBox1.Text);
            z = "/";
            textBox1.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)//2 tuşu
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

        private void button11_Click(object sender, EventArgs e)//3 tuşu
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

        private void button10_Click(object sender, EventArgs e)//4 tuşu
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

        private void button9_Click(object sender, EventArgs e)//5 tuşu
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

        private void button8_Click(object sender, EventArgs e)//6 tuşu
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

        private void button7_Click(object sender, EventArgs e)//7 tuşu
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

        private void button6_Click(object sender, EventArgs e)//8 tuşu
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

        private void button5_Click(object sender, EventArgs e)//9 tuşu
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

        private void button13_Click(object sender, EventArgs e)//çıkartma
        {
            x = Convert.ToDouble(textBox1.Text);
            z = "-";
            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)//çarpma 
        {
            x = Convert.ToDouble(textBox1.Text);
            z = "*";
            textBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e) //C tuşu
        {
            x = 0;
            y = 0;
            z = "";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (z == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
            }
            if (z == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
            }
            if (z == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
            }
            if (z == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = ",";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button3_Click(object sender, EventArgs e)// 0 tuşu
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
    }
}
