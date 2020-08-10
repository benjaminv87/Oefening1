using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> namenLijst = new List<string>();
        private void btnMijnKnop_Click(object sender, EventArgs e)
        {
            lbMijnLijst.Items.Clear();
            foreach (var item in namenLijst)
            {
                if (item.ToLower().Contains(tbMijnTextBox.Text.ToLower()))
                {
                    lbMijnLijst.Items.Add(item);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("namen.txt"))
            {
                while (!reader.EndOfStream)
                {
                    namenLijst.Add(reader.ReadLine());
                }
            }
            foreach (var item in namenLijst)
            {

                    lbMijnLijst.Items.Add(item);

            }
        }

    }
}
