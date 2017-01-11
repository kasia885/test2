using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Telefon : IBiling, IDodaj
    {
        private List<Usługa> uslugi;

        public Telefon()
        {
            this.uslugi = new List<Usługa>();
        }

        public void DodajPolaczenie(string numer, int czasP)
        {
            uslugi.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }
        public void DodajSms(string numer)
        {
            uslugi.Add(new Sms(DateTime.Now, numer));
        }
        public void DodajInternet(int iloscMB)
        {
            uslugi.Add(new Internet(DateTime.Now, iloscMB));
        }
        public override string ToString()
        {
            string output = string.Empty;
            foreach (var u in uslugi)
                output += u.ToString() + '\n';
            return output;
        }
        public void ZapiszBiling()
        {
            using (StreamWriter plik = new StreamWriter("biling.txt", true))
            {
                foreach (string s in ToString().Split('\n'))
                    plik.WriteLine(s);
                plik.Close();
            }
        }
    }
}
