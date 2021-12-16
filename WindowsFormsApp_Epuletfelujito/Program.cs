using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Epuletfelujito
{
    static class Program
    {
        public static Form1 form1 = null;
        public static Form_Cs_epulet form_Cs_Epulet = null;
        public static Form_T_epulet form_T_Epulet = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            form_Cs_Epulet = new Form_Cs_epulet();
            form_T_Epulet = new Form_T_epulet();
            Application.Run(form1);
        }
    }
}
