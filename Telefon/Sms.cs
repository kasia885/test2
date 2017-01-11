using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Sms : Usługa
    {
        private string numer;

        protected override void ObliczCene()
        {
            cena = 0.15d;
        }

        public Sms(DateTime czas, string numer) : base(czas)
        {
            //this.czas = czas;
            this.numer = numer;
            ObliczCene();
        }

        public override string ToString()
        {
            ObliczCene();
            return "Sms: numer " + numer + ", data i godzina smsa: " + czas.ToString() + ", łączny koszt: " + cena;
        }
    }
}
