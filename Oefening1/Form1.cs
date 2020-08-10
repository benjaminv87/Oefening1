﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMijnKnop_Click(object sender, EventArgs e)
        {
            if (tbMijnTextBox.Text != "")
            {
                lbMijnLijst.Items.Add(tbMijnTextBox.Text);
                tbMijnTextBox.Focus();
            }
            if (lbMijnLijst.Items.Count >= 5)
            {
                btnMijnKnop.Enabled = false;
                tbMijnTextBox.Enabled = false;
                tbMijnTextBox.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbMijnTextBox.Focus();

        }
    }
}
