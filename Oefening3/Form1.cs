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

        private void btnMijnKnop_Click(object sender, EventArgs e)
        {
            VulLijst(tbMijnTextBox.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VulLijst("");
        }
        public void VulLijst(string text)
        {
            lbMijnLijst.Items.Clear();
            List<string> namenLijst = new List<string>();
            using (StreamReader reader = new StreamReader("namen.txt"))
            {
                while (!reader.EndOfStream)
                {
                    namenLijst.Add(reader.ReadLine());
                }
            }
            foreach (var item in namenLijst)
            {
                if (item.Contains(text))
                {
                    lbMijnLijst.Items.Add(item);
                }

            }
        }
    }
}
