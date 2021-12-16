using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletfelujito
{
    enum TetoAnyaga
    {
        cserep,
        zsindely,
        nád
    }
    class Cs_Epulet : Epuletek
    {
        int ottelok;
        bool garazs;
        TetoAnyaga t_anyag;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool Garazs { get => garazs; set => garazs = value; }
        internal TetoAnyaga T_anyag { get => t_anyag; set => t_anyag = value; }

        public Cs_Epulet(string cim, Epitesanyagok anyagok, int alapterulet, DateTime kezd, DateTime vegez, int ottelok, bool garazs, TetoAnyaga anyag) :base(cim, anyagok, alapterulet, kezd, vegez)
        {
            Ottelok = ottelok;
            Garazs = garazs;
            T_anyag = anyag;
        }
    }
}
