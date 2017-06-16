namespace DatabaseManagementProject
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişÇıkışDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yıllıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talimatGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.bolumadı = new System.Windows.Forms.ComboBox();
            this.Cek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tb_Pid = new System.Windows.Forms.TextBox();
            this.Gorev_Checked = new System.Windows.Forms.CheckBox();
            this.ukategori = new System.Windows.Forms.ComboBox();
            this.akategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanRaporuToolStripMenuItem,
            this.talimatGönderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanRaporuToolStripMenuItem
            // 
            this.çalışanRaporuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişÇıkışDurumuToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.çalışanRaporuToolStripMenuItem.Name = "çalışanRaporuToolStripMenuItem";
            this.çalışanRaporuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.çalışanRaporuToolStripMenuItem.Text = "Menu";
            // 
            // girişÇıkışDurumuToolStripMenuItem
            // 
            this.girişÇıkışDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükToolStripMenuItem,
            this.aylıkToolStripMenuItem,
            this.yıllıkToolStripMenuItem});
            this.girişÇıkışDurumuToolStripMenuItem.Name = "girişÇıkışDurumuToolStripMenuItem";
            this.girişÇıkışDurumuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.girişÇıkışDurumuToolStripMenuItem.Text = "Özet Raporu";
            // 
            // günlükToolStripMenuItem
            // 
            this.günlükToolStripMenuItem.Name = "günlükToolStripMenuItem";
            this.günlükToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.günlükToolStripMenuItem.Text = "Günlük";
            this.günlükToolStripMenuItem.Click += new System.EventHandler(this.günlükToolStripMenuItem_Click);
            // 
            // aylıkToolStripMenuItem
            // 
            this.aylıkToolStripMenuItem.Name = "aylıkToolStripMenuItem";
            this.aylıkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aylıkToolStripMenuItem.Text = "Aylık";
            this.aylıkToolStripMenuItem.Click += new System.EventHandler(this.aylıkToolStripMenuItem_Click);
            // 
            // yıllıkToolStripMenuItem
            // 
            this.yıllıkToolStripMenuItem.Name = "yıllıkToolStripMenuItem";
            this.yıllıkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.yıllıkToolStripMenuItem.Text = "Yıllık";
            this.yıllıkToolStripMenuItem.Click += new System.EventHandler(this.yıllıkToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // talimatGönderToolStripMenuItem
            // 
            this.talimatGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderToolStripMenuItem});
            this.talimatGönderToolStripMenuItem.Name = "talimatGönderToolStripMenuItem";
            this.talimatGönderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.talimatGönderToolStripMenuItem.Text = "Talimat Gönder";
            // 
            // gönderToolStripMenuItem
            // 
            this.gönderToolStripMenuItem.Name = "gönderToolStripMenuItem";
            this.gönderToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gönderToolStripMenuItem.Text = "Gönder";
            this.gönderToolStripMenuItem.Click += new System.EventHandler(this.gönderToolStripMenuItem_Click);
            // 
            // tarih1
            // 
            this.tarih1.Location = new System.Drawing.Point(172, 66);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(104, 20);
            this.tarih1.TabIndex = 4;
            // 
            // tarih2
            // 
            this.tarih2.Location = new System.Drawing.Point(283, 65);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(101, 20);
            this.tarih2.TabIndex = 5;
            // 
            // bolumadı
            // 
            this.bolumadı.FormattingEnabled = true;
            this.bolumadı.Location = new System.Drawing.Point(172, 90);
            this.bolumadı.Name = "bolumadı";
            this.bolumadı.Size = new System.Drawing.Size(104, 21);
            this.bolumadı.TabIndex = 7;
            // 
            // Cek
            // 
            this.Cek.Location = new System.Drawing.Point(518, 117);
            this.Cek.Name = "Cek";
            this.Cek.Size = new System.Drawing.Size(136, 34);
            this.Cek.TabIndex = 12;
            this.Cek.Text = "Verileri Al";
            this.Cek.UseVisualStyleBackColor = true;
            this.Cek.Click += new System.EventHandler(this.Cek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rapor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Günlük Çalışma Raporu",
            "Aylık Çalışma Raporu",
            "Yıllık Çalışma Raporu"});
            this.comboBox1.Location = new System.Drawing.Point(481, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Rapor Seç(Isteğe Bağlı)";
            // 
            // Tb_Pid
            // 
            this.Tb_Pid.Location = new System.Drawing.Point(176, 40);
            this.Tb_Pid.Name = "Tb_Pid";
            this.Tb_Pid.Size = new System.Drawing.Size(100, 20);
            this.Tb_Pid.TabIndex = 15;
            this.Tb_Pid.Visible = false;
            // 
            // Gorev_Checked
            // 
            this.Gorev_Checked.AutoSize = true;
            this.Gorev_Checked.Location = new System.Drawing.Point(113, 119);
            this.Gorev_Checked.Name = "Gorev_Checked";
            this.Gorev_Checked.Size = new System.Drawing.Size(58, 17);
            this.Gorev_Checked.TabIndex = 9;
            this.Gorev_Checked.Text = "Görev:";
            this.Gorev_Checked.UseVisualStyleBackColor = true;
            // 
            // ukategori
            // 
            this.ukategori.FormattingEnabled = true;
            this.ukategori.Location = new System.Drawing.Point(172, 117);
            this.ukategori.Name = "ukategori";
            this.ukategori.Size = new System.Drawing.Size(104, 21);
            this.ukategori.TabIndex = 10;
            this.ukategori.Text = "Birim";
            this.ukategori.SelectedIndexChanged += new System.EventHandler(this.ukategori_SelectedIndexChanged);
            // 
            // akategori
            // 
            this.akategori.FormattingEnabled = true;
            this.akategori.Location = new System.Drawing.Point(282, 117);
            this.akategori.Name = "akategori";
            this.akategori.Size = new System.Drawing.Size(102, 21);
            this.akategori.TabIndex = 11;
            this.akategori.Text = "Unvan";
            this.akategori.SelectedIndexChanged += new System.EventHandler(this.akategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bölüm:";
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(816, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_Pid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cek);
            this.Controls.Add(this.akategori);
            this.Controls.Add(this.ukategori);
            this.Controls.Add(this.Gorev_Checked);
            this.Controls.Add(this.bolumadı);
            this.Controls.Add(this.tarih2);
            this.Controls.Add(this.tarih1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişÇıkışDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yıllıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talimatGönderToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker tarih1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.ComboBox bolumadı;
        private System.Windows.Forms.Button Cek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gönderToolStripMenuItem;
        public System.Windows.Forms.TextBox Tb_Pid;
        private System.Windows.Forms.CheckBox Gorev_Checked;
        private System.Windows.Forms.ComboBox ukategori;
        private System.Windows.Forms.ComboBox akategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}