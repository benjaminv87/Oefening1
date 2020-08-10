using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMijnKnop_Click(object sender, EventArgs e)
        {
            if (cbMijnComboBox.SelectedIndex >= 0)
            {
                MessageBox.Show($"{cbMijnComboBox.SelectedItem.ToString()} is verwijderd") ;
                cbMijnComboBox.Items.RemoveAt(cbMijnComboBox.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMijnComboBox.Items.Add("1");
            cbMijnComboBox.Items.Add("2");
            cbMijnComboBox.Items.Add("3");
            cbMijnComboBox.Items.Add("4");
            cbMijnComboBox.Items.Add("5");
            cbMijnComboBox.Items.Add("6");
            cbMijnComboBox.Items.Add("7");
            cbMijnComboBox.Items.Add("8");
            cbMijnComboBox.Items.Add("9");
            cbMijnComboBox.Items.Add("10");

        }
    }
}
