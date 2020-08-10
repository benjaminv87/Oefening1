using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public List<user> userLijst = new List<user>();
        private void Form1_Load(object sender, EventArgs e)
        {

            userLijst.Add( new user("Benjamin", "Vandevelde"));
            userLijst.Add(new user("Katinka", "Derave"));
            userLijst.Add(new user("Léo", "Vandevelde"));
            userLijst.Add(new user("Colette", "Vandevelde"));
            VulLijst();

        }
        public void VulLijst()
        {
            cbMijnComboBox.Items.Clear();
            foreach (var item in userLijst)
            {
                cbMijnComboBox.Items.Add(item.Voornaam);
            }
        }
        private void cbMijnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            user geselecteerdeUser = userLijst[cbMijnComboBox.SelectedIndex];
            tbVoornaam.Visible = true;
            tbFamilienaam.Visible = true;
            tbVoornaam.Text = geselecteerdeUser.Voornaam;
            tbFamilienaam.Text = geselecteerdeUser.Achternaam;
        }

        private void tbVoornaam_Leave(object sender, EventArgs e)
        {
            userLijst[cbMijnComboBox.SelectedIndex].Voornaam = tbVoornaam.Text;
            VulLijst();
        }

        private void tbFamilienaam_Leave(object sender, EventArgs e)
        {
            userLijst[cbMijnComboBox.SelectedIndex].Achternaam = tbFamilienaam.Text;
            VulLijst();
        }
    }
}
