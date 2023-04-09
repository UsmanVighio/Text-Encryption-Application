using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Encruption_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // function for usercontrol
        public void usercontrol(UserControl uc)
        {
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            usercontrol(d);

        }
    }
}
