using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_prakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            string key = keyBox.Text;
            key = Cipherer.keyExtender(text.Length, key);
            resultBox.Text = Cipherer.cipherer(text, key);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox.Text;
            string key = keyBox.Text;
            key = Cipherer.keyExtender(text.Length, key);
            resultBox.Text = Cipherer.decipherer(text, key);
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            keyBox.Text = "";
            resultBox.Text = "";
        }
    }
}
