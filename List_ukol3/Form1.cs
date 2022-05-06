using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_ukol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> znaky = new List<char>();

        private string Vypis(List<char> list)
        {
            string slovo = "";

            foreach (char znak in list)
            {
                slovo += znak;
            }

            return slovo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_a.Enabled = true;
            button_e.Enabled = true;
            button_i.Enabled = true;
            button_o.Enabled = true;
            button_u.Enabled = true;
            button_y.Enabled = true;
            reset.Enabled = true;
            button1.Enabled = false;

            foreach (char znak in vstup.Text)
            {
                znaky.Add(znak);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            button_a.Enabled = false;
            button_e.Enabled = false;
            button_i.Enabled = false;
            button_o.Enabled = false;
            button_u.Enabled = false;
            button_y.Enabled = false;
            reset.Enabled = false;
            button1.Enabled = true;

            znaky.Clear();
            vstup.Text = "";
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            String slovo = Vypis(znaky).Replace(((Button)sender).Text, String.Empty);

            vstup.Text = slovo;
            znaky.Clear();

            foreach (char znak in slovo)
            {
                znaky.Add(znak);
            }

            ((Button)sender).Enabled = false;
        }
    }
}
