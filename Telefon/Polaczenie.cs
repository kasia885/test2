using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Polaczenie : Usługa
    {
        string numer;
        int czasP;

        protected override void ObliczCene()
        {
            cena = 0.29d * czasP;
        }

        public Polaczenie(DateTime czas, string numer, int czasP) : base(czas)
        {
            //this.czas = czas;
            this.numer = numer;
            this.czasP = czasP;
            ObliczCene();
        }

        public override string ToString()
        {
            ObliczCene();
            return "Połączenie: numer " + numer + ", data i godzina rozmowy: " + czas.ToString() + ", długość trwania: " + czasP + ", łączny koszt: " + cena;
        }
    }
}
