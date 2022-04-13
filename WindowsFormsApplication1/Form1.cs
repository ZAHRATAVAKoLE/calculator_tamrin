using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (a * b).ToString(); //عدد دو ضرب

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a, b;
           a = Convert.ToInt32(textBox1.Text);
          b = Convert.ToInt32(textBox2.Text);
          textBox3.Text = (a - b).ToString(); //عدد دو تفریق
}

        private void button13_Click(object sender, EventArgs e)
        {
              int a, b;
              a = Convert.ToInt32(textBox1.Text);
              b = Convert.ToInt32(textBox2.Text);
              textBox3.Text = (a + b).ToString(); //عدد دو جمع

        
        }

    

        private void button11_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (a / b).ToString(); //عدد دو تقسیم
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
    }
}
