namespace DatabaseManagementProject
{
    partial class BolumYoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BolumYoneticiPaneli));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yıllıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yıllıkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cek = new System.Windows.Forms.Button();
            this.akategori = new System.Windows.Forms.ComboBox();
            this.ukategori = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.tarih = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelRaporuToolStripMenuItem,
            this.raporGönderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelRaporuToolStripMenuItem
            // 
            this.personelRaporuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aylıkToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.personelRaporuToolStripMenuItem.Name = "personelRaporuToolStripMenuItem";
            this.personelRaporuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.personelRaporuToolStripMenuItem.Text = "Menu";
            // 
            // aylıkToolStripMenuItem
            // 
            this.aylıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aylıkToolStripMenuItem1,
            this.yıllıkToolStripMenuItem,
            this.yıllıkToolStripMenuItem1});
            this.aylıkToolStripMenuItem.Name = "aylıkToolStripMenuItem";
            this.aylıkToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aylıkToolStripMenuItem.Text = "Özet Rapor";
            // 
            // aylıkToolStripMenuItem1
            // 
            this.aylıkToolStripMenuItem1.Name = "aylıkToolStripMenuItem1";
            this.aylıkToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.aylıkToolStripMenuItem1.Text = "Günlük";
            this.aylıkToolStripMenuItem1.Click += new System.EventHandler(this.aylıkToolStripMenuItem1_Click);
            // 
            // yıllıkToolStripMenuItem
            // 
            this.yıllıkToolStripMenuItem.Name = "yıllıkToolStripMenuItem";
            this.yıllıkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.yıllıkToolStripMenuItem.Text = "Aylık";
            this.yıllıkToolStripMenuItem.Click += new System.EventHandler(this.yıllıkToolStripMenuItem_Click);
            // 
            // yıllıkToolStripMenuItem1
            // 
            this.yıllıkToolStripMenuItem1.Name = "yıllıkToolStripMenuItem1";
            this.yıllıkToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.yıllıkToolStripMenuItem1.Text = "Yıllık";
            this.yıllıkToolStripMenuItem1.Click += new System.EventHandler(this.yıllıkToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // raporGönderToolStripMenuItem
            // 
            this.raporGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderToolStripMenuItem});
            this.raporGönderToolStripMenuItem.Name = "raporGönderToolStripMenuItem";
            this.raporGönderToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.raporGönderToolStripMenuItem.Text = "Rapor Gönder";
            // 
            // gönderToolStripMenuItem
            // 
            this.gönderToolStripMenuItem.Name = "gönderToolStripMenuItem";
            this.gönderToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gönderToolStripMenuItem.Text = "Gönder";
            this.gönderToolStripMenuItem.Click += new System.EventHandler(this.gönderToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Günlük Çalışma Raporu",
            "Aylık Çalışma Raporu",
            "Yıllık Çalışma Raporu",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(428, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Rapor Seç(İsteğe Bağlı)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Rapor:";
            // 
            // Cek
            // 
            this.Cek.Location = new System.Drawing.Point(465, 91);
            this.Cek.Name = "Cek";
            this.Cek.Size = new System.Drawing.Size(136, 34);
            this.Cek.TabIndex = 23;
            this.Cek.Text = "Verileri Al";
            this.Cek.UseVisualStyleBackColor = true;
            this.Cek.Click += new System.EventHandler(this.Cek_Click);
            // 
            // akategori
            // 
            this.akategori.FormattingEnabled = true;
            this.akategori.Location = new System.Drawing.Point(229, 74);
            this.akategori.Name = "akategori";
            this.akategori.Size = new System.Drawing.Size(102, 21);
            this.akategori.TabIndex = 22;
            this.akategori.Text = "Unvan";
            // 
            // ukategori
            // 
            this.ukategori.FormattingEnabled = true;
            this.ukategori.Location = new System.Drawing.Point(119, 74);
            this.ukategori.Name = "ukategori";
            this.ukategori.Size = new System.Drawing.Size(104, 21);
            this.ukategori.TabIndex = 21;
            this.ukategori.Text = "Birim";
            this.ukategori.SelectedIndexChanged += new System.EventHandler(this.ukategori_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Görev:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tarih2
            // 
            this.tarih2.Location = new System.Drawing.Point(230, 50);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(101, 20);
            this.tarih2.TabIndex = 17;
            // 
            // tarih1
            // 
            this.tarih1.Location = new System.Drawing.Point(119, 51);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(104, 20);
            this.tarih1.TabIndex = 16;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(60, 53);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(53, 17);
            this.tarih.TabIndex = 15;
            this.tarih.Text = "Tarih:";
            this.tarih.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 257);
            this.dataGridView1.TabIndex = 26;
            // 
            // Bname
            // 
            this.Bname.Location = new System.Drawing.Point(230, 105);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(100, 20);
            this.Bname.TabIndex = 27;
            this.Bname.Visible = false;
            // 
            // BolumYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(831, 446);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cek);
            this.Controls.Add(this.akategori);
            this.Controls.Add(this.ukategori);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tarih2);
            this.Controls.Add(this.tarih1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BolumYoneticiPaneli";
            this.Text = "Alt Yönetici Paneli";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yıllıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yıllıkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporGönderToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cek;
        private System.Windows.Forms.ComboBox akategori;
        private System.Windows.Forms.ComboBox ukategori;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private System.Windows.Forms.CheckBox tarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem gönderToolStripMenuItem;
        public System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}