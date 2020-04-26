using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1741541Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string[] ArrayHistory  = new string[1000];

        int index = -1;

        public double convertfromsartodollar(double amount)
        {
            return amount * 0.27  ;
        }

        public double convertfromdollartosar(double amount)
        {
            return amount * 3.76;
        }
        public double convertfromsartoEgyptianPound(double amount)
        {
            return amount * 4.20 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string History = "";

            double amount = Double.Parse(textBox1.Text);       

            int index = comboBox1.SelectedIndex;

            if (index == 0)
            {
                History += "\n" + comboBox1.SelectedText.ToString();
                History += "\n" + amount + " SAR  = " + convertfromsartodollar(amount) + " USA .";

            }
            if (index == 1)
            {
                History += "\n" + comboBox1.SelectedText.ToString() ;
                History += "\n " + amount + "  USA  = " + convertfromdollartosar(amount) + " SAR  .";
            }
            if (index == 2)
            {
                History += "\n" + comboBox1.SelectedText.ToString();
                History += "\n " + amount + "  SAR  = " + convertfromsartoEgyptianPound(amount) + " LE  .";
            }

           index++;

           ArrayHistory[index] = History;

           label4.Text += History;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" 1 SAR = 0.27  USA  ");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" 1 USA  = 3.76 SAR   ");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" 1 SAR = 4.20  LE  ");
        }
    }
}
