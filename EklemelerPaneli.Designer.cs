namespace DatabaseManagementProject
{
    partial class EklemelerPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EklemelerPaneli));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_bolum = new System.Windows.Forms.TextBox();
            this.textBox_Meslek = new System.Windows.Forms.TextBox();
            this.textBox_Birim = new System.Windows.Forms.TextBox();
            this.textBox_Unvan = new System.Windows.Forms.TextBox();
            this.textBox_MaasCarpani = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.Unvan_comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_bolum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Meslek, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Birim, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Unvan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_MaasCarpani, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_ekle, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Unvan_comboBox, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.62697F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.64904F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4942F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.53291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01817F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 92);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meslek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 68);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unvan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 57);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş Çarpanı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_bolum
            // 
            this.textBox_bolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bolum.Location = new System.Drawing.Point(385, 18);
            this.textBox_bolum.Name = "textBox_bolum";
            this.textBox_bolum.Size = new System.Drawing.Size(190, 20);
            this.textBox_bolum.TabIndex = 6;
            this.textBox_bolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Meslek
            // 
            this.textBox_Meslek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Meslek.Location = new System.Drawing.Point(385, 93);
            this.textBox_Meslek.Name = "textBox_Meslek";
            this.textBox_Meslek.Size = new System.Drawing.Size(190, 20);
            this.textBox_Meslek.TabIndex = 7;
            // 
            // textBox_Birim
            // 
            this.textBox_Birim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Birim.Location = new System.Drawing.Point(385, 169);
            this.textBox_Birim.Name = "textBox_Birim";
            this.textBox_Birim.Size = new System.Drawing.Size(190, 20);
            this.textBox_Birim.TabIndex = 8;
            // 
            // textBox_Unvan
            // 
            this.textBox_Unvan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Unvan.Location = new System.Drawing.Point(385, 233);
            this.textBox_Unvan.Name = "textBox_Unvan";
            this.textBox_Unvan.Size = new System.Drawing.Size(190, 20);
            this.textBox_Unvan.TabIndex = 9;
            // 
            // textBox_MaasCarpani
            // 
            this.textBox_MaasCarpani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MaasCarpani.Location = new System.Drawing.Point(385, 295);
            this.textBox_MaasCarpani.Name = "textBox_MaasCarpani";
            this.textBox_MaasCarpani.Size = new System.Drawing.Size(190, 20);
            this.textBox_MaasCarpani.TabIndex = 10;
            // 
            // button_ekle
            // 
            this.button_ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_ekle.Location = new System.Drawing.Point(643, 364);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(314, 25);
            this.button_ekle.TabIndex = 12;
            this.button_ekle.Text = "Kayıt Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // Unvan_comboBox
            // 
            this.Unvan_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unvan_comboBox.FormattingEnabled = true;
            this.Unvan_comboBox.Location = new System.Drawing.Point(717, 232);
            this.Unvan_comboBox.Name = "Unvan_comboBox";
            this.Unvan_comboBox.Size = new System.Drawing.Size(165, 21);
            this.Unvan_comboBox.TabIndex = 13;
            // 
            // EklemelerPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(960, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EklemelerPaneli";
            this.Text = "Eklemeler Paneli";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_bolum;
        private System.Windows.Forms.TextBox textBox_Meslek;
        private System.Windows.Forms.TextBox textBox_Birim;
        private System.Windows.Forms.TextBox textBox_Unvan;
        private System.Windows.Forms.TextBox textBox_MaasCarpani;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.ComboBox Unvan_comboBox;

    }
}