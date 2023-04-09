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
    public partial class EcryptionScreen : UserControl
    {
        public EcryptionScreen()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        //Simple  Encryption by reverse the string
        private void submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(plainTextBox.Text) && !string.IsNullOrWhiteSpace(plainTextBox.Text))
            {
                //hiding the btn
                submit.Visible = false;
                clear1_btn.Visible = false;
                paste_btn.Visible = false;
                //displaying the copy and clear btn for encrypted text
                clearbtn.Visible = true;
                copy_btn.Visible = true;
                // storing the input into the string
                string input = plainTextBox.Text;

                //declaring the string variable to hold the reverse text
                string answer = "";

                //Replacing the key by symbols
                input = input.Replace("a", "$");
                input = input.Replace("e", "/");
                input = input.Replace("i", "#");
                input = input.Replace("o", "!");
                input = input.Replace("u", "*");


                //using for loop for logic 
                for (int i = input.Length; i > 0; i--)
                {
                    answer += input[i - 1].ToString();

                }

                // displaying the result in ecryption text box
                encryptTextBox.Text = answer;
                // encryptTextBox.Visible = true;
                // gunaLabel3.Visible = true;
                plainTextBox.Enabled = false;
            }
            else
            {
                plainTextBox.Focus();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //hiding the clear btn
            clearbtn.Visible = false;
            copy_btn.Visible = false;
           
         
            //enabling the text box and displaying the enter btn
            plainTextBox.Enabled = true;
            submit.Visible = true;
            clear1_btn.Visible = true;
            paste_btn.Visible = true;
            //  clearing the string of plaintext
            plainTextBox.Text = string.Empty;
            encryptTextBox.Text = string.Empty;

            //focus on plain text box
            plainTextBox.Focus();
            
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(encryptTextBox.Text);
        }

        private void clear1_btn_Click(object sender, EventArgs e)
        {
            plainTextBox.Text = string.Empty;
        }

        private void paste_btn_Click(object sender, EventArgs e)
        {
            plainTextBox.Text = Clipboard.GetText();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            Program.f.usercontrol(dd);
        }

        private void EcryptionScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
