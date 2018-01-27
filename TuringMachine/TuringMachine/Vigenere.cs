using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TuringMachine
{
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Visible = true;
                label1.Visible = true;
                String s = richTextBox1.Text;
                String key = textBox1.Text;
                richTextBox2.Text= VigenereCl.Encode(s, key);
            }
            if (radioButton2.Checked)
            {
                textBox1.Visible = true;
                label1.Visible = true;
                String s = richTextBox1.Text;
                String key = textBox1.Text;
                richTextBox2.Text = VigenereCl.Decode(s, key);

            }
            if (radioButton3.Checked)
            {
                textBox1.Visible = false;
                label1.Visible = false;
                String s = richTextBox1.Text;
                richTextBox2.Text = VigenereCl.Encode(s, VigenereCl.Generate_Pseudorandom_KeyWord(s.Length, 100));
            }
            if (radioButton4.Checked)
            {
                textBox1.Visible = false;
                label1.Visible = false;
                String s = richTextBox1.Text;
                richTextBox2.Text = VigenereCl.Decode(s, VigenereCl.Generate_Pseudorandom_KeyWord(s.Length, 100));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
        }
    }
}
