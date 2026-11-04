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
            string chiave = txt_n2.Text;

            if (string.IsNullOrWhiteSpace(Stringa) || string.IsNullOrWhiteSpace(chiave))
            {
                MessageBox.Show("Attenzione! Scrivere sui text box",
                    "Errore di compilazione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int[] conta = new int[26];


            }

        }
    }
}
