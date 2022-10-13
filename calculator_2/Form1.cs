using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
