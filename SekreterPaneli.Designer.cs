namespace DatabaseManagementProject
{
    partial class SekreterPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterPaneli));
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemelerPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker_BsTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isim_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soyisim_txtbox = new System.Windows.Forms.TextBox();
            this.TC_txtbox = new System.Windows.Forms.TextBox();
            this.Tel_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cinsiyet_Cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mail_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Adres_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_Dtarih = new System.Windows.Forms.DateTimePicker();
            this.button_islemtamam = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.islem_Cbox = new System.Windows.Forms.ComboBox();
            this.label_iName = new System.Windows.Forms.Label();
            this.label_izinSure = new System.Windows.Forms.Label();
            this.dateTimePicker_izinbas = new System.Windows.Forms.DateTimePicker();
            this.label_arasi = new System.Windows.Forms.Label();
            this.dateTimePicker_izinbit = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.Bolum_Cbox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Altu_Cbox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Unvan_Cbox = new System.Windows.Forms.ComboBox();
            this.Meslek_Cbox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Label_Unvan = new System.Windows.Forms.Label();
            this.Izın_Textbox = new System.Windows.Forms.TextBox();
            this.MaasOnayla_rb = new System.Windows.Forms.RadioButton();
            this.AraTc_Tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MydataGridView
            // 
            this.MydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MydataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.MydataGridView, "MydataGridView");
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MydataGridView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.eklemelerPaneliToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.çıkarToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.izinYazToolStripMenuItem,
            this.araToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            resources.ApplyResources(this.personelToolStripMenuItem, "personelToolStripMenuItem");
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            resources.ApplyResources(this.ekleToolStripMenuItem, "ekleToolStripMenuItem");
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // çıkarToolStripMenuItem
            // 
            this.çıkarToolStripMenuItem.Name = "çıkarToolStripMenuItem";
            resources.ApplyResources(this.çıkarToolStripMenuItem, "çıkarToolStripMenuItem");
            this.çıkarToolStripMenuItem.Click += new System.EventHandler(this.çıkarToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            resources.ApplyResources(this.düzenleToolStripMenuItem, "düzenleToolStripMenuItem");
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // izinYazToolStripMenuItem
            // 
            this.izinYazToolStripMenuItem.Name = "izinYazToolStripMenuItem";
            resources.ApplyResources(this.izinYazToolStripMenuItem, "izinYazToolStripMenuItem");
            this.izinYazToolStripMenuItem.Click += new System.EventHandler(this.izinYazToolStripMenuItem_Click_1);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            resources.ApplyResources(this.araToolStripMenuItem, "araToolStripMenuItem");
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // eklemelerPaneliToolStripMenuItem
            // 
            this.eklemelerPaneliToolStripMenuItem.Name = "eklemelerPaneliToolStripMenuItem";
            resources.ApplyResources(this.eklemelerPaneliToolStripMenuItem, "eklemelerPaneliToolStripMenuItem");
            this.eklemelerPaneliToolStripMenuItem.Click += new System.EventHandler(this.eklemelerPaneliToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            resources.ApplyResources(this.çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dateTimePicker_BsTarih
            // 
            this.dateTimePicker_BsTarih.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dateTimePicker_BsTarih, "dateTimePicker_BsTarih");
            this.dateTimePicker_BsTarih.Name = "dateTimePicker_BsTarih";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Name = "label3";
            // 
            // isim_txtbox
            // 
            this.isim_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.isim_txtbox, "isim_txtbox");
            this.isim_txtbox.Name = "isim_txtbox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Name = "label2";
            // 
            // soyisim_txtbox
            // 
            this.soyisim_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.soyisim_txtbox, "soyisim_txtbox");
            this.soyisim_txtbox.Name = "soyisim_txtbox";
            // 
            // TC_txtbox
            // 
            this.TC_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.TC_txtbox, "TC_txtbox");
            this.TC_txtbox.Name = "TC_txtbox";
            // 
            // Tel_txtbox
            // 
            this.Tel_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.Tel_txtbox, "Tel_txtbox");
            this.Tel_txtbox.Name = "Tel_txtbox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Name = "label4";
            // 
            // Cinsiyet_Cbox
            // 
            this.Cinsiyet_Cbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cinsiyet_Cbox.FormattingEnabled = true;
            this.Cinsiyet_Cbox.Items.AddRange(new object[] {
            resources.GetString("Cinsiyet_Cbox.Items"),
            resources.GetString("Cinsiyet_Cbox.Items1")});
            resources.ApplyResources(this.Cinsiyet_Cbox, "Cinsiyet_Cbox");
            this.Cinsiyet_Cbox.Name = "Cinsiyet_Cbox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Name = "label7";
            // 
            // Mail_txtbox
            // 
            this.Mail_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.Mail_txtbox, "Mail_txtbox");
            this.Mail_txtbox.Name = "Mail_txtbox";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Name = "label8";
            // 
            // Adres_txtbox
            // 
            this.Adres_txtbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.Adres_txtbox, "Adres_txtbox");
            this.Adres_txtbox.Name = "Adres_txtbox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Name = "label9";
            // 
            // dateTimePicker_Dtarih
            // 
            this.dateTimePicker_Dtarih.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dateTimePicker_Dtarih, "dateTimePicker_Dtarih");
            this.dateTimePicker_Dtarih.Name = "dateTimePicker_Dtarih";
            // 
            // button_islemtamam
            // 
            this.button_islemtamam.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.button_islemtamam, "button_islemtamam");
            this.button_islemtamam.Name = "button_islemtamam";
            this.button_islemtamam.UseVisualStyleBackColor = true;
            this.button_islemtamam.Click += new System.EventHandler(this.button_islemtamam_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Name = "label10";
            // 
            // islem_Cbox
            // 
            this.islem_Cbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.islem_Cbox.FormattingEnabled = true;
            this.islem_Cbox.Items.AddRange(new object[] {
            resources.GetString("islem_Cbox.Items"),
            resources.GetString("islem_Cbox.Items1"),
            resources.GetString("islem_Cbox.Items2"),
            resources.GetString("islem_Cbox.Items3"),
            resources.GetString("islem_Cbox.Items4")});
            resources.ApplyResources(this.islem_Cbox, "islem_Cbox");
            this.islem_Cbox.Name = "islem_Cbox";
            // 
            // label_iName
            // 
            resources.ApplyResources(this.label_iName, "label_iName");
            this.label_iName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_iName.Name = "label_iName";
            // 
            // label_izinSure
            // 
            resources.ApplyResources(this.label_izinSure, "label_izinSure");
            this.label_izinSure.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_izinSure.Name = "label_izinSure";
            // 
            // dateTimePicker_izinbas
            // 
            this.dateTimePicker_izinbas.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dateTimePicker_izinbas, "dateTimePicker_izinbas");
            this.dateTimePicker_izinbas.Name = "dateTimePicker_izinbas";
            // 
            // label_arasi
            // 
            resources.ApplyResources(this.label_arasi, "label_arasi");
            this.label_arasi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_arasi.Name = "label_arasi";
            // 
            // dateTimePicker_izinbit
            // 
            this.dateTimePicker_izinbit.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dateTimePicker_izinbit, "dateTimePicker_izinbit");
            this.dateTimePicker_izinbit.Name = "dateTimePicker_izinbit";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Name = "label14";
            // 
            // Bolum_Cbox
            // 
            this.Bolum_Cbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bolum_Cbox.FormattingEnabled = true;
            resources.ApplyResources(this.Bolum_Cbox, "Bolum_Cbox");
            this.Bolum_Cbox.Name = "Bolum_Cbox";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label17.Name = "label17";
            // 
            // Altu_Cbox
            // 
            this.Altu_Cbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Altu_Cbox.FormattingEnabled = true;
            resources.ApplyResources(this.Altu_Cbox, "Altu_Cbox");
            this.Altu_Cbox.Name = "Altu_Cbox";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // Unvan_Cbox
            // 
            this.Unvan_Cbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Unvan_Cbox.FormattingEnabled = true;
            resources.ApplyResources(this.Unvan_Cbox, "Unvan_Cbox");
            this.Unvan_Cbox.Name = "Unvan_Cbox";
            this.Unvan_Cbox.SelectedIndexChanged += new System.EventHandler(this.Unvan_Cbox_SelectedIndexChanged);
            // 
            // Meslek_Cbox
            // 
            this.Meslek_Cbox.FormattingEnabled = true;
            resources.ApplyResources(this.Meslek_Cbox, "Meslek_Cbox");
            this.Meslek_Cbox.Name = "Meslek_Cbox";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Label_Unvan
            // 
            resources.ApplyResources(this.Label_Unvan, "Label_Unvan");
            this.Label_Unvan.Name = "Label_Unvan";
            // 
            // Izın_Textbox
            // 
            resources.ApplyResources(this.Izın_Textbox, "Izın_Textbox");
            this.Izın_Textbox.Name = "Izın_Textbox";
            // 
            // MaasOnayla_rb
            // 
            resources.ApplyResources(this.MaasOnayla_rb, "MaasOnayla_rb");
            this.MaasOnayla_rb.Name = "MaasOnayla_rb";
            this.MaasOnayla_rb.UseVisualStyleBackColor = true;
            this.MaasOnayla_rb.CheckedChanged += new System.EventHandler(this.MaasOnayla_rb_CheckedChanged);
            // 
            // AraTc_Tb
            // 
            resources.ApplyResources(this.AraTc_Tb, "AraTc_Tb");
            this.AraTc_Tb.Name = "AraTc_Tb";
            this.AraTc_Tb.TextChanged += new System.EventHandler(this.AraTc_Tb_TextChanged);
            // 
            // SekreterPaneli
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.AraTc_Tb);
            this.Controls.Add(this.Izın_Textbox);
            this.Controls.Add(this.Label_Unvan);
            this.Controls.Add(this.MaasOnayla_rb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Meslek_Cbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Bolum_Cbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Altu_Cbox);
            this.Controls.Add(this.Unvan_Cbox);
            this.Controls.Add(this.dateTimePicker_izinbit);
            this.Controls.Add(this.label_arasi);
            this.Controls.Add(this.dateTimePicker_izinbas);
            this.Controls.Add(this.label_izinSure);
            this.Controls.Add(this.label_iName);
            this.Controls.Add(this.islem_Cbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_islemtamam);
            this.Controls.Add(this.dateTimePicker_Dtarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Adres_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Mail_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cinsiyet_Cbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tel_txtbox);
            this.Controls.Add(this.TC_txtbox);
            this.Controls.Add(this.soyisim_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isim_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_BsTarih);
            this.Controls.Add(this.MydataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SekreterPaneli";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BsTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isim_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyisim_txtbox;
        private System.Windows.Forms.TextBox TC_txtbox;
        private System.Windows.Forms.TextBox Tel_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cinsiyet_Cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mail_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Adres_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Dtarih;
        private System.Windows.Forms.Button button_islemtamam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox islem_Cbox;
        private System.Windows.Forms.Label label_iName;
        private System.Windows.Forms.Label label_izinSure;
        private System.Windows.Forms.DateTimePicker dateTimePicker_izinbas;
        private System.Windows.Forms.Label label_arasi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_izinbit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Bolum_Cbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Altu_Cbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Unvan_Cbox;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ComboBox Meslek_Cbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Label_Unvan;
        private System.Windows.Forms.ToolStripMenuItem eklemelerPaneliToolStripMenuItem;
        private System.Windows.Forms.TextBox Izın_Textbox;
        private System.Windows.Forms.RadioButton MaasOnayla_rb;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.TextBox AraTc_Tb;
    }
}