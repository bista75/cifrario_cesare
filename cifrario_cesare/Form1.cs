using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string Stringa = txt_n1.Text;
            int chiave = Convert.ToInt32(txt_n2.Text));

            if (string.IsNullOrWhiteSpace(Stringa))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box",
                    "Errore di compilazione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                char[] risultato = Stringa.ToCharArray();
                for(int i = 0; i < 26; i++)
                {
                    char c = risultato[i];
                    if (c >= 'A' && c <= 'Z')
                    {
                        risultato[i] = (char)('A' + (c - 'A' + chiave) % 26);
                    }
                }
            }

        }
    }
}
