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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void detaljiRacunovodstva_Click(object sender, EventArgs e)
        {
            var form = new RacunovodstvoForm();
            form.Show();
        }


        public static float dveDecim(float f)
        {
            f = (Convert.ToSingle(Math.Floor((f * 100))) / 100);
            return f;
        }

        private void buttonUplati_Click(object sender, EventArgs e)
        {
            Racunovodstvo rac = Racunovodstvo.GetRacunovodstvo();
            if (textUplati.Text != "")
            {
                try
                {
                    float n = float.Parse(textUplati.Text.ToString());
                    rac.uplati(Form1.dveDecim(n));
                }
                catch
                {
                    Console.WriteLine("Krivi unos");
                }
                textUplati.Text = "";
            }
        }

        private void buttonIsplati_Click(object sender, EventArgs e)
        {
            Racunovodstvo rac = Racunovodstvo.GetRacunovodstvo();
            if (textIsplati.Text != "")
            {
                try
                {
                    float n = float.Parse(textIsplati.Text.ToString());
                    rac.isplati(Form1.dveDecim(n));
                }
                catch
                {
                    Console.WriteLine("Krivi unos");
                }
                textIsplati.Text = "";
            }
        }

        private void buttonDodajOsobe_Click(object sender, EventArgs e)
        {
            var form = new dodavanjeOsobaForm();
            form.Show();
        }

        private void buttonZaposlenici_Click(object sender, EventArgs e)
        {
            var form = new Zaposlenici();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skola sk = Skola.getSkola();
            sk.ispisiProf();
        }

        private void buttonUcenici_Click(object sender, EventArgs e)
        {
            var form = new Ucenici();
            form.Show();
        }

        private void buttonRazredi_Click(object sender, EventArgs e)
        {
            var form = new Razredi();
            form.Show();
        }
    }


    public class Racunovodstvo
    {
        private static Racunovodstvo r = null;

        public List<String> log = new List<String>();
        public float budzet = 10000;
        private Racunovodstvo() { }

        public static Racunovodstvo GetRacunovodstvo()
        {
            if (r == null)
                r = new Racunovodstvo();
            return r;
        }

        public void uplati(float novac)
        {
            r.budzet += novac;
            Console.WriteLine("Budzet racunovodstva: {0}kn", Form1.dveDecim(r.budzet));
            r.log.Add($"Uplata: {novac}kn, trenutno: {r.budzet}kn.\n");
        }
        public void isplati(float novac)
        {
            if ((r.budzet - novac) < 0)
            {
                Console.WriteLine("Budzet racunovodstva nije dostatan za isplatu.");
                r.log.Add("Pokusaj isplate, neuspjelo zbog nedostatka novca");
            }
            else
            {
                r.budzet -= novac;
                Console.WriteLine("Budzet racunovodstva: {0}kn", Form1.dveDecim(r.budzet));
                r.log.Add($"Isplata: {novac}kn, trenutno: {r.budzet}kn.\n");
            }
        }
    }

    public abstract class AbsOsoba
    {
        public String ime;

        public abstract void radi();
        public abstract void ispis();
    }

    public class Osoba : AbsOsoba
    {
        public Osoba(String _ime)
        {
            ime = _ime;
        }
        public override void radi()
        {
            Console.WriteLine("{0} nešto radi", ime);
        }
        public override void ispis()
        {
            Console.WriteLine("{0}", ime);
        }
    }

    public abstract class Decorator : AbsOsoba
    {
        protected AbsOsoba aO;
        public Decorator(AbsOsoba _aO)
        {
            aO = _aO;
        }
        public override void radi()
        {
            aO.radi();
        }
        public override void ispis()
        {
            aO.ispis();
        }
    }

    public class Ravnatelj : Decorator
    {
        public AbsOsoba ova;
        public Ravnatelj(AbsOsoba _aO) : base(_aO)
        {
            ova = _aO;
        }

        public override void ispis()
        {
            Console.WriteLine("{0} je ravnatelj", ova.ime);
        }
        public override void radi()
        {
            Console.WriteLine("{0} ravnatulje", ova.ime);
        }
        public void isplati(float novac)
        {
            Racunovodstvo rac = Racunovodstvo.GetRacunovodstvo();
            rac.isplati(novac);
        }
        public void uplati(float novac)
        {
            Racunovodstvo rac = Racunovodstvo.GetRacunovodstvo();
            rac.uplati(novac);
        }
    }

    public class Profesor : Decorator
    {
        List<Predmet> predmeti = new List<Predmet>();
        public AbsOsoba ova;
        public Profesor(AbsOsoba _aO, List<Predmet> _predmeti) : base(_aO)
        {
            ova = _aO;
            inicijalizacijaPredmeti(_predmeti);
        }
        public Profesor(AbsOsoba _aO) : base(_aO)
        {
            ova = _aO;
        }

        private void inicijalizacijaPredmeti(List<Predmet> pr)
        {
            foreach (Predmet p in pr)
            {
                if (p.profesor.ime == ova.ime)
                    predmeti.Add(p);
            }
        }

        public override void ispis()
        {
            Console.WriteLine("{0} je profesor", ova.ime);
        }
        public override void radi()
        {
            Console.WriteLine("{0} poducava djecu", ova.ime);
        }

        public void isplati(float novac)
        {
            Racunovodstvo rac = Racunovodstvo.GetRacunovodstvo();
            rac.isplati(novac);
        }
    }

    public class Ucenik : Decorator
    {
        public AbsOsoba ova;
        List<int> ocjene = new List<int>();
        public Ucenik(Osoba _aO) : base(_aO)
        {
            ova = _aO;
        }

        public override void ispis()
        {
            Console.WriteLine("{0} je ucenik/ca", ova.ime);
        }
        public override void radi()
        {
            Console.WriteLine("{0} mora uciti za ispit", ova.ime);
        }

        public void dodajOcjenu(int o)
        {
            if (o < 1 || o > 5)
                Console.WriteLine("Kriva ocjena, [1,5]!!");
            else
                ocjene.Add(o);
        }
        public float prosjekOcjena()
        {
            int suma = 0;
            foreach (int o in ocjene)
            {
                suma += o;
            }
            float prosjek = suma / ocjene.Count;
            return Form1.dveDecim(prosjek);
        }
    }


    public class Razred
    {
        public List<Ucenik> ucenici = new List<Ucenik>();
        public Profesor razrednik;
        public String naziv;
        public Razred(String _naziv, Profesor _razrednik, List<Ucenik> _ucenici)
        {
            naziv = _naziv;
            ucenici = _ucenici;
            razrednik = _razrednik;
        }

        public void ispisUcenika()
        {
            foreach (Ucenik u in ucenici)
            {
                Console.WriteLine(u.ime);
            }
        }
        public void ispis()
        {
            Console.WriteLine("Razrednik: {0}", razrednik.ime);
            Console.WriteLine("Ucenici:");
            ispisUcenika();
        }
    }

    public class Predmet
    {
        public String naziv;
        public Profesor profesor;
        public Predmet(String _naziv, Profesor _profesor)
        {
            profesor = _profesor;
            naziv = _naziv;
        }

        public void ispis()
        {
            Console.WriteLine("Predmet {0} poducuje {1}", naziv, profesor.ime);
        }
    }

    public class Skola
    {
        private static Skola s = null;

        public List<Ucenik> ucenici = new List<Ucenik>();
        public List<Razred> razredi = new List<Razred>();
        public List<Profesor> profesori = new List<Profesor>();
        public Ravnatelj ravnatelj;

        public List<Predmet> predmet = new List<Predmet>();

        private Skola() { }

        public static Skola getSkola()
        {
            if (s == null)
                s = new Skola();
            return s;
        }

        public void ispisiProf()
        {
            foreach (Profesor p in profesori)
            {
                Console.WriteLine(p.ime);
            }
            Console.WriteLine("-");
        }
    }
}
