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
    public partial class KreiranjeNovogRazreda : Form
    {
        public KreiranjeNovogRazreda()
        {
            InitializeComponent();
        }


        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KreiranjeNovogRazreda_Load(object sender, EventArgs e)
        {
            Skola sk = Skola.getSkola();
            List<String> imenaProfesora = new List<String>();
            if (sk.profesori.Count > 0)
            {
                foreach (Profesor p in sk.profesori)
                {
                    imenaProfesora.Add(p.ova.ime);
                }
            }
            else
            {
                imenaProfesora.Add("Nema zaposlenih profesora");
            }
            listaProfesora.DataSource = imenaProfesora;

            List<String> listaImenaUcenika = new List<String>();
            if (sk.ucenici.Count < 1)
            {
                listaImenaUcenika.Add("Nema ucenika");
            }
            else
            {
                foreach (Ucenik u in sk.ucenici)
                {
                    listaImenaUcenika.Add(u.ova.ime);
                }
            }
            listUcenici.DataSource = listaImenaUcenika;
        }

        private void buttonDodajRazred_Click(object sender, EventArgs e)
        {
            Skola sk = Skola.getSkola();

            String nazivR = textBoxNazivRazreda.Text.ToString();
            Profesor prof = listaProfesora.SelectedItem as Profesor;
            List<Ucenik> ucen = new List<Ucenik>();

            foreach(int i in listUcenici.SelectedIndices)
            {
                ucen.Add(sk.ucenici[i]);
            }         

            sk.razredi.Add(new Razred(nazivR, prof, ucen));

            this.Close();
        }
    }
}
