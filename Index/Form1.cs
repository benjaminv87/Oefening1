using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
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

        private void btnOefening1_Click(object sender, EventArgs e)
        {
            Oefening1.Form1 f1 = new Oefening1.Form1();
            f1.Show();
        }

        private void btnOefening2_Click(object sender, EventArgs e)
        {
            Oefening2.Form1 f1 = new Oefening2.Form1();
            f1.Show();
        }

        private void btnOefening3_Click(object sender, EventArgs e)
        {
            Oefening3.Form1 f1 = new Oefening3.Form1();
            f1.Show();
        }

        private void btnOefening4_Click(object sender, EventArgs e)
        {
            Oefening4.Form1 f1 = new Oefening4.Form1();
            f1.Show();
        }
    }
}
