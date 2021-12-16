using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletfelujito
{
    enum FentartasTipus
    {
        egyéni,
        szövetkezet,
        társasház
    }
    class T_epulet : Epuletek
    {
        readonly int lakasSzam;
        FentartasTipus fantartastipusa;
        readonly bool lift;

        public int LakasSzam => lakasSzam;

        internal FentartasTipus Fantartastipusa { get => fantartastipusa; set => fantartastipusa = value; }

        public bool Lift => lift;

        public T_epulet(string cim, Epitesanyagok anyagok, int alapterulet, DateTime kezd, DateTime vegez , int lakasSzam, bool lift, FentartasTipus fantartastipusa) : base(cim, anyagok, alapterulet, kezd, vegez)
        {
            this.lakasSzam = lakasSzam;
            this.lift = lift;
            Fantartastipusa = fantartastipusa;
        }
    }
}
