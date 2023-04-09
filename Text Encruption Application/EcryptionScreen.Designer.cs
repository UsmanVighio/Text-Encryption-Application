namespace Text_Encruption_Application
{
    partial class EcryptionScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptTextBox = new System.Windows.Forms.RichTextBox();
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.submit = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.clear1_btn = new System.Windows.Forms.Button();
            this.paste_btn = new System.Windows.Forms.Button();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(309, 140);
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.ReadOnly = true;
            this.encryptTextBox.Size = new System.Drawing.Size(227, 132);
            this.encryptTextBox.TabIndex = 1;
            this.encryptTextBox.Text = "";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(35, 140);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(227, 132);
            this.plainTextBox.TabIndex = 1;
            this.plainTextBox.Text = "";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(89, 104);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(121, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Enter your text here";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(382, 105);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(91, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Encrypted Text";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(112, 296);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Enter";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(390, 296);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Visible = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(471, 296);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(65, 23);
            this.copy_btn.TabIndex = 5;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Visible = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // clear1_btn
            // 
            this.clear1_btn.Location = new System.Drawing.Point(197, 296);
            this.clear1_btn.Name = "clear1_btn";
            this.clear1_btn.Size = new System.Drawing.Size(56, 23);
            this.clear1_btn.TabIndex = 6;
            this.clear1_btn.Text = "Clear";
            this.clear1_btn.UseVisualStyleBackColor = true;
            this.clear1_btn.Click += new System.EventHandler(this.clear1_btn_Click);
            // 
            // paste_btn
            // 
            this.paste_btn.Location = new System.Drawing.Point(46, 296);
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.Size = new System.Drawing.Size(56, 23);
            this.paste_btn.TabIndex = 7;
            this.paste_btn.Text = "Paste";
            this.paste_btn.UseVisualStyleBackColor = true;
            this.paste_btn.Click += new System.EventHandler(this.paste_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ControlText;
            this.back_btn.CheckedState.Parent = this.back_btn;
            this.back_btn.CustomImages.Parent = this.back_btn;
            this.back_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.HoverState.Parent = this.back_btn;
            this.back_btn.Location = new System.Drawing.Point(243, 369);
            this.back_btn.Name = "back_btn";
            this.back_btn.ShadowDecoration.Parent = this.back_btn;
            this.back_btn.Size = new System.Drawing.Size(81, 24);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(220, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "Encryption";
            // 
            // EcryptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.paste_btn);
            this.Controls.Add(this.clear1_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.encryptTextBox);
            this.Name = "EcryptionScreen";
            this.Size = new System.Drawing.Size(569, 408);
            this.Load += new System.EventHandler(this.EcryptionScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox encryptTextBox;
        private System.Windows.Forms.RichTextBox plainTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button clear1_btn;
        private System.Windows.Forms.Button paste_btn;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;

    }
}
