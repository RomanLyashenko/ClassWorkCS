using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._05._2025
{
    public partial class Form1 : Form
    {

        string number;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number += "1";
            textBox1.Text = number;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            number += "0";
            textBox1.Text = number;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            number += "2";
            textBox1.Text = number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number += "3";
            textBox1.Text = number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number += "4";
            textBox1.Text = number;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            number += "5";
            textBox1.Text = number;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            number += "6";
            textBox1.Text = number;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            number += "7";
            textBox1.Text = number;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            number += "8";
            textBox1.Text = number;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            number += "9";
            textBox1.Text = number;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            number = null;
            textBox1.Text = "0";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            double book = Convert.ToDouble(number); 
            book *= Math.PI;
            number = book.ToString();
            textBox1.Text = number;
        }

        private void button444_Click(object sender, EventArgs e)
        {
            double book = Convert.ToDouble(number);
            book = 1 / book;
            number = book.ToString();
            textBox1.Text = number;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ',')
                {
                    flag = true;
                    break; 
                }
            }
            if (flag) 
            { 

            }
            else
            {
                number += ",";
                textBox1.Text = number;
            }
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            float book = float.Parse(number);

            number = (book *= -1).ToString();
            textBox1.Text = number;
        }

        private void button555_Click(object sender, EventArgs e)
        {
            float book = float.Parse(number);

            number = (book *= book).ToString();
            textBox1.Text = number;
        }

        private void button666_Click(object sender, EventArgs e)
        {
            float book = float.Parse(number);

            number = Math.Sqrt(book).ToString();
            textBox1.Text = number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number = number.Remove(number.Length - 1);
            textBox1.Text = number;
        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }


    }
}
