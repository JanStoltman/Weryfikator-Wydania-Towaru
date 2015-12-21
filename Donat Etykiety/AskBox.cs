using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Donat_Etykiety;

namespace Etykiety_Epl
{
    public partial class AskBox : Form
    {
        public int wynik = 0;
        public AskBox()
        {
            InitializeComponent();
        }

        private void Ok_Bt_Click(object sender, EventArgs e)
        {
            Int32.TryParse(Ile_Bx.Text, out wynik);
            this.Close();
        }


    }
}
