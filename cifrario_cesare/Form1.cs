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

        private void btn_n3_Click(object sender, EventArgs e)
        {
            string testo = txt_n5.Text, chiave;
            chiave = txt_n6.Text;


            if (string.IsNullOrEmpty(testo))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box");
                return;

            }
            if (string.IsNullOrEmpty(chiave))
            {
                MessageBox.Show("Inserisci una parola valida come chiave");
                return;
            }
            else
            {
                string risultato = "";
                
                chiave = chiave.ToUpper();


                int iTesto = 0;
                int iChiave = 0;


                int lunghezzaMassima = Math.Max(testo.Length, chiave.Length);

                for (int i = 0; i < lunghezzaMassima; i++)
                {
                    char letteraTesto = testo[iTesto];
                    char letteraChiave = chiave[iChiave];

                    if (letteraTesto == ' ')
                    {
                        risultato += ' ';
                        iTesto++;
                        if (iTesto == testo.Length) iTesto = 0;
                        continue; 
                    }
                    int spostamento = letteraChiave - 'A';
                    char nuovaLettera = (char)(letteraTesto + spostamento);

                    if (char.IsUpper(letteraTesto))
                    {
                        if (nuovaLettera > 'Z')
                        {
                            nuovaLettera = (char)(nuovaLettera - 26);
                        }
                    }
                    else if (char.IsLower(letteraTesto))
                    {
                        if (nuovaLettera > 'z')
                        {
                            nuovaLettera = (char)(nuovaLettera - 26);
                        }
                    }

                    risultato += nuovaLettera;

                    iTesto++;
                    iChiave++;


                    if (iTesto == testo.Length)
                    {
                        iTesto = 0;
                    }

                    if (iChiave == chiave.Length)
                    {
                        iChiave = 0;
                    }
                }

                lbl_n10.Text = risultato;
            }
        }

        private void btn_n4_Click(object sender, EventArgs e)
        {

            string testo = txt_n7.Text, chiave;
            chiave = txt_n8.Text;


            if (string.IsNullOrEmpty(testo))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box");
                return;

            }
            if (string.IsNullOrEmpty(chiave))
            {
                MessageBox.Show("Inserisci una parola valida come chiave");
                return;
            }
            else
            {
                string risultato = "";
               
                chiave = chiave.ToUpper();


                int iTesto = 0;
                int iChiave = 0;


                int lunghezzaMassima = Math.Max(testo.Length, chiave.Length);

                for (int i = 0; i < lunghezzaMassima; i++)
                {
                    char letteraTesto = testo[iTesto];
                    char letteraChiave = chiave[iChiave];

                    if (letteraTesto == ' ')
                    {
                        risultato += ' ';
                        iTesto++;
                        if (iTesto == testo.Length) iTesto = 0;
                        continue;
                    }
                    int spostamento = letteraChiave - 'A';
                    char nuovaLettera = (char)(letteraTesto - spostamento);

                    if (char.IsUpper(letteraTesto))
                    {
                        if (nuovaLettera < 'A')
                        {
                            nuovaLettera = (char)(nuovaLettera + 26);
                        }
                    }
                    else if (char.IsLower(letteraTesto))
                    {
                        if (nuovaLettera < 'a')
                        {
                            nuovaLettera = (char)(nuovaLettera + 26);
                        }
                    }

                    risultato += nuovaLettera;

                    iTesto++;
                    iChiave++;


                    if (iTesto == testo.Length)
                    {
                        iTesto = 0;
                    }

                    if (iChiave == chiave.Length)
                    {
                        iChiave = 0;
                    }
                }

                lbl_n13.Text = risultato;
            }

        }
    }
}
