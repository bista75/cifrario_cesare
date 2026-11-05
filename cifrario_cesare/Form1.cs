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
            

            if (string.IsNullOrWhiteSpace(Stringa))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box");
                return;
                    
            }
            if (!int.TryParse(txt_n2.Text, out int chiave))
            {
                MessageBox.Show("Inserisci un numero valido come chiave");
                return;
            }

            else
            {
                chiave = chiave % 26;
                char[] risultato = Stringa.ToCharArray();
                for (int i = 0; i < Stringa.Length; i++)
                {
                    char c = risultato[i];
                    if (c >= 'A' && c <= 'Z')
                    {
                        risultato[i] = (char)('A' + (c - 'A' + chiave+26) % 26);
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        risultato[i] = (char)('a' + (c - 'a' + chiave + 26) % 26);
                    }
                }
                lbl_n3.Text = new string(risultato);
            }

        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string Stringa = txt_n3.Text;


            if (string.IsNullOrEmpty(Stringa))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box");
                return;

            }
            if (!int.TryParse(txt_n4.Text, out int chiave))
            {
                MessageBox.Show("Inserisci un numero valido come chiave");
                return;
            }
            else
            {
                chiave = chiave % 26;
                char[] risultato = Stringa.ToCharArray();
                for (int i = 0; i < Stringa.Length; i++)
                {
                    char c = risultato[i];
                    if (c >= 'A' && c <= 'Z')
                    {
                        risultato[i] = (char)('A' + (c - 'A' - chiave + 26) % 26);
                    }
                    else if(c >= 'a' && c <= 'z')
                    {
                        risultato[i] = (char)('a' + (c - 'a' - chiave + 26) % 26);
                    }
                }
                lbl_n7.Text = new string(risultato);
            }

        }
    }
}
