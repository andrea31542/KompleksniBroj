using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBroj
{
   class KompleksniBrojKlasa
    {

        public double RealniDio;
        public double ImaginarniDio; //CTR + D kopiranje linije 
        public KompleksniBrojKlasa(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;

        }
        
        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})";  // $ string is variable, inside {}
        }

    }
}
