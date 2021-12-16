using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Epuletfelujito
{
    public partial class Form_Cs_epulet : Form
    {
        public Form_Cs_epulet()
        {
            InitializeComponent();
        }

        private void Form_Cs_epulet_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(TetoAnyaga)))
            {
                comboBox_Cs_Anyag.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(Epitesanyagok)))
            {
                comboBox_Cs_Teto.Items.Add(item)
            }
        }
    }
}
