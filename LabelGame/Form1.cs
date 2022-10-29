using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara Çarptın!");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" TEBRİKLER Kazandınız ");
        }
    }
}
