using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    abstract class Usługa
    {
        protected DateTime czas;
        protected double cena;

        abstract protected void ObliczCene();

        public Usługa(DateTime czas)
        {
            this.czas = czas;
            cena = 0;
        }
    }
}
