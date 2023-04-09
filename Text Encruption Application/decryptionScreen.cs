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
    public partial class decryptionScreen : UserControl
    {
        public decryptionScreen()
        {
            InitializeComponent();
        }

        private void decryptionScreen_Load(object sender, EventArgs e)
        {

        }

        private void paste_btn_Click(object sender, EventArgs e)
        {
            encryptedTextBox.Text = Clipboard.GetText();
        }

        private void clear1_btn_Click(object sender, EventArgs e)
        {
            encryptedTextBox.Text = String.Empty;
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(decryptTextBox.Text);

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //clearing the strings 
            //hiding the clear btn
            clearbtn.Visible = false;
            copy_btn.Visible = false;


            //enabling the text box and displaying the enter btn
            encryptedTextBox.Enabled = true;
            submit.Visible = true;
            clear1_btn.Visible = true;
            paste_btn.Visible = true;
            //  clearing the string of plaintext
            encryptedTextBox.Text = string.Empty;
            decryptTextBox.Text = string.Empty;

            //focus on plain text box
            encryptedTextBox.Focus();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(encryptedTextBox.Text) && !string.IsNullOrWhiteSpace(encryptedTextBox.Text))
            {
                string input = encryptedTextBox.Text;
                string decrypt = "";

                input = input.Replace("$", "a");
                input = input.Replace("/", "e");
                input = input.Replace("#", "i");
                input = input.Replace("!", "o");
                input = input.Replace("*", "u");

                for (int i = input.Length; i > 0; i--)
                {
                    //now we set the login
                    decrypt += input[i - 1].ToString();
                }

                //now display  the text to the  user

                decryptTextBox.Text = decrypt;

                //Hiding some button 
                submit.Visible = false;
                clear1_btn.Visible = false;
                paste_btn.Visible = false;
                encryptedTextBox.Enabled = false;

                //displaying other btns
                clearbtn.Visible = true;
                copy_btn.Visible = true;
            }
            else
            {
                encryptedTextBox.Focus();
            }
        }

    
        private void back_btn_Click(object sender, EventArgs e)
        {
             Dashboard  dd = new Dashboard();   
             Program.f.usercontrol(dd);
        }
    }
}
