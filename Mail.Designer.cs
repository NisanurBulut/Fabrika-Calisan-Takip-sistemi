namespace DatabaseManagementProject
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.Message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.formadi_Tb = new System.Windows.Forms.TextBox();
            this.mailto = new System.Windows.Forms.TextBox();
            this.mailfrom = new System.Windows.Forms.TextBox();
            this.konu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 62);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(286, 202);
            this.Message.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(13, 300);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(285, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Mail Şifrenizi Buraya Ekleyin--Şifreniz kaydedilmemektedir";
            // 
            // formadi_Tb
            // 
            this.formadi_Tb.Location = new System.Drawing.Point(304, 97);
            this.formadi_Tb.Name = "formadi_Tb";
            this.formadi_Tb.Size = new System.Drawing.Size(100, 20);
            this.formadi_Tb.TabIndex = 3;
            this.formadi_Tb.Visible = false;
            // 
            // mailto
            // 
            this.mailto.Location = new System.Drawing.Point(11, 12);
            this.mailto.Name = "mailto";
            this.mailto.Size = new System.Drawing.Size(286, 20);
            this.mailto.TabIndex = 4;
            this.mailto.Text = "Göndereceğiniz Email";
            // 
            // mailfrom
            // 
            this.mailfrom.Location = new System.Drawing.Point(12, 274);
            this.mailfrom.Name = "mailfrom";
            this.mailfrom.Size = new System.Drawing.Size(285, 20);
            this.mailfrom.TabIndex = 5;
            this.mailfrom.Text = "Emailiniz";
            // 
            // konu
            // 
            this.konu.Location = new System.Drawing.Point(11, 36);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(286, 20);
            this.konu.TabIndex = 6;
            this.konu.Text = "Konu:";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(391, 350);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.mailfrom);
            this.Controls.Add(this.mailto);
            this.Controls.Add(this.formadi_Tb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox formadi_Tb;
        public System.Windows.Forms.TextBox mailto;
        private System.Windows.Forms.TextBox mailfrom;
        private System.Windows.Forms.TextBox konu;
    }
}