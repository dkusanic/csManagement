namespace CS
{
    partial class loginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.korisnikTextbox = new System.Windows.Forms.TextBox();
            this.lozinkaTextbox = new System.Windows.Forms.TextBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.korisnikLabel = new System.Windows.Forms.Label();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // korisnikTextbox
            // 
            this.korisnikTextbox.Location = new System.Drawing.Point(108, 114);
            this.korisnikTextbox.Name = "korisnikTextbox";
            this.korisnikTextbox.Size = new System.Drawing.Size(117, 22);
            this.korisnikTextbox.TabIndex = 0;
            // 
            // lozinkaTextbox
            // 
            this.lozinkaTextbox.Location = new System.Drawing.Point(108, 186);
            this.lozinkaTextbox.Name = "lozinkaTextbox";
            this.lozinkaTextbox.Size = new System.Drawing.Size(117, 22);
            this.lozinkaTextbox.TabIndex = 1;
            this.lozinkaTextbox.UseSystemPasswordChar = true;
            this.lozinkaTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lozinkaTextbox_KeyDown);
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(108, 258);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(117, 23);
            this.prijavaButton.TabIndex = 2;
            this.prijavaButton.Text = "PRIJAVA";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // korisnikLabel
            // 
            this.korisnikLabel.AutoSize = true;
            this.korisnikLabel.Location = new System.Drawing.Point(105, 84);
            this.korisnikLabel.Name = "korisnikLabel";
            this.korisnikLabel.Size = new System.Drawing.Size(103, 17);
            this.korisnikLabel.TabIndex = 3;
            this.korisnikLabel.Text = "Korisničko ime:";
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(105, 156);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(61, 17);
            this.lozinkaLabel.TabIndex = 4;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 515);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.korisnikLabel);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.lozinkaTextbox);
            this.Controls.Add(this.korisnikTextbox);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava u sustav";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korisnikTextbox;
        private System.Windows.Forms.TextBox lozinkaTextbox;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label korisnikLabel;
        private System.Windows.Forms.Label lozinkaLabel;
    }
}