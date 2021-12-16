using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletfelujito
{
    enum Epitesanyagok
    {
        tegla,
        panel,
        fa
    }
    class Epuletek
    {
        string cim;
        int alapterulet;
        Epitesanyagok anyagok;
        DateTime kezd;
        DateTime vegez;

        public string Cim { get => cim; }
        public int Alapterulet { get => alapterulet; set { if (value >= 20) alapterulet = value else { throw new Exception(); } } }
        public DateTime Kezd { get => kezd; set { if (value >= DateTime.Now)  kezd = value;  else { throw new Exception(); } } } 
        public DateTime Vegez { get => vegez; set { if (value >= kezd) vegez = value; else { throw new Exception(); } } }
        internal Epitesanyagok Anyagok { get => anyagok;}

        public Epuletek(string cim, Epitesanyagok anyagok, int alapterulet, DateTime kezd, DateTime vegez)
        {
            this.cim = cim;
            this.anyagok = anyagok;
            Alapterulet = alapterulet;
            Kezd = kezd;
            Vegez = vegez;
        }
    }
}
