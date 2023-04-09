namespace Text_Encruption_Application
{
    partial class Dashboard
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
            this.encrypttion_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.decryption_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // encrypttion_btn
            // 
            this.encrypttion_btn.BackColor = System.Drawing.Color.Transparent;
            this.encrypttion_btn.BorderColor = System.Drawing.Color.DarkGray;
            this.encrypttion_btn.BorderRadius = 12;
            this.encrypttion_btn.BorderThickness = 1;
            this.encrypttion_btn.CheckedState.Parent = this.encrypttion_btn;
            this.encrypttion_btn.CustomImages.Parent = this.encrypttion_btn;
            this.encrypttion_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.encrypttion_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(76)))), ((int)(((byte)(48)))));
            this.encrypttion_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.encrypttion_btn.ForeColor = System.Drawing.Color.White;
            this.encrypttion_btn.HoverState.Parent = this.encrypttion_btn;
            this.encrypttion_btn.Location = new System.Drawing.Point(55, 146);
            this.encrypttion_btn.Name = "encrypttion_btn";
            this.encrypttion_btn.ShadowDecoration.BorderRadius = 13;
            this.encrypttion_btn.ShadowDecoration.Depth = 20;
            this.encrypttion_btn.ShadowDecoration.Enabled = true;
            this.encrypttion_btn.ShadowDecoration.Parent = this.encrypttion_btn;
            this.encrypttion_btn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 2, 3);
            this.encrypttion_btn.Size = new System.Drawing.Size(180, 126);
            this.encrypttion_btn.TabIndex = 0;
            this.encrypttion_btn.Text = "Encryption";
            this.encrypttion_btn.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(212, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Dashboard";
            // 
            // decryption_btn
            // 
            this.decryption_btn.BackColor = System.Drawing.Color.Transparent;
            this.decryption_btn.BorderColor = System.Drawing.Color.DarkGray;
            this.decryption_btn.BorderRadius = 12;
            this.decryption_btn.BorderThickness = 1;
            this.decryption_btn.CheckedState.Parent = this.decryption_btn;
            this.decryption_btn.CustomImages.Parent = this.decryption_btn;
            this.decryption_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(187)))), ((int)(((byte)(73)))));
            this.decryption_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(8)))));
            this.decryption_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decryption_btn.ForeColor = System.Drawing.Color.White;
            this.decryption_btn.HoverState.Parent = this.decryption_btn;
            this.decryption_btn.Location = new System.Drawing.Point(325, 146);
            this.decryption_btn.Name = "decryption_btn";
            this.decryption_btn.ShadowDecoration.BorderRadius = 13;
            this.decryption_btn.ShadowDecoration.Depth = 20;
            this.decryption_btn.ShadowDecoration.Enabled = true;
            this.decryption_btn.ShadowDecoration.Parent = this.decryption_btn;
            this.decryption_btn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 2, 3);
            this.decryption_btn.Size = new System.Drawing.Size(180, 126);
            this.decryption_btn.TabIndex = 2;
            this.decryption_btn.Text = "Decryption";
            this.decryption_btn.Click += new System.EventHandler(this.decryption_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.decryption_btn);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.encrypttion_btn);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(569, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton encrypttion_btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton decryption_btn;
    }
}
