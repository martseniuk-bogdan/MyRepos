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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void шифрЦезаряСКлючемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caesar f = new Caesar();
            f.MdiParent = this;
            f.Show();
            f.Hide();
            f.Show();
        }

        private void шифрСАвтоключемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vigenere f = new Vigenere();
            f.MdiParent = this;
            f.Show();
            f.Hide();
            f.Show();
        }
    }
}
