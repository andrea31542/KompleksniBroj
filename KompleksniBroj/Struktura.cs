using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBroj
{
    struct KompleksniBrojStruktura
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojStruktura(double realni, double imaginarni) //konstruktor mora biti istog imena kao struktura 
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;

        }

        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})"; 
        }

    }
}
