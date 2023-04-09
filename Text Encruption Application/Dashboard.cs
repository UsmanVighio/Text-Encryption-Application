using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Encruption_Application
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

     
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            EcryptionScreen es = new EcryptionScreen();
            Program.f.usercontrol(es);
        }

        private void decryption_btn_Click(object sender, EventArgs e)
        {
            decryptionScreen ds = new decryptionScreen();
            Program.f.usercontrol(ds);
        }
    }
}
