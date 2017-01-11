using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Internet : Usługa
    {
        private int iloscMB;

        protected override void ObliczCene()
        {
            cena = (double)iloscMB / 756;
        }

        public Internet(DateTime czas, int iloscMB) : base(czas)
        {
            this.iloscMB = iloscMB;
        }

        public override string ToString()
        {
            ObliczCene();
            return "Internet, data i godzina internetu: " + czas.ToString() + ", ilośćMB: " + iloscMB + ", łączny koszt: " + cena;
        }
    }
}
