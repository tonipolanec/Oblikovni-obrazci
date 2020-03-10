using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrazci
{
    public partial class dodavanjeOsobaForm : Form
    {
        public dodavanjeOsobaForm()
        {
            InitializeComponent();
        }

        private void buttonDodavanjeOsoba_Click(object sender, EventArgs e)
        {
            Skola sk = Skola.getSkola();
            if (textIme.Text != "")
            {
                Osoba os = new Osoba(textIme.Text.ToString());

                if (radioUcenik.Checked)
                {
                    sk.ucenici.Add(new Ucenik(os));
                }
                else if (radioProfesor.Checked)
                {
                    sk.profesori.Add(new Profesor(os));
                }
                else if (radioRavnatelj.Checked)
                {
                    sk.ravnatelj = new Ravnatelj(os);
                }
            }
            textIme.Text = "";
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
