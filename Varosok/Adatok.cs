using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Varosok
{
    internal class Adatok
    {
        public Adatok(string r)
        {
            var v = r.Split(';');
            VarosNeve = v[0];
            OrszagNeve = v[1];
            Nepesseg = double.Parse(v[2]);
        }

        public string VarosNeve { get; set; }
        public string OrszagNeve { get; set; }
        public double Nepesseg { get; set; }

        public override string ToString()
        {
            return $"{VarosNeve} {OrszagNeve} {Nepesseg}";
        }

    }
    
}
