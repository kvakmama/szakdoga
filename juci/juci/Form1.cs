using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttonkiir_Click(object sender, EventArgs e)
        {
            string x;
            x = label1.Text;
            label2.Text = x;
        }
    }
}
