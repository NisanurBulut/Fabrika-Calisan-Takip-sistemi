using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementProject
{
    public partial class SekreterPaneli : Form
    {
        public SekreterPaneli()
        {
            InitializeComponent();
        }
        Sorgular sorgu=new Sorgular();
     
        private void Form4_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

                string[] a = sorgu.SelectBolumCBox();

                for (int i = 0; i < a.Length; i++)
                {
                    Bolum_Cbox.Items.Add(a[i]);
                }

                string[] b = sorgu.SelectUnvanCbox();

                for (int i = 0; i < b.Length; i++)
                {
                    Unvan_Cbox.Items.Add(b[i]);
                }

                string[] c = sorgu.SelectMeslekCBox();

                for (int i = 0; i < c.Length; i++)
                {
                    Meslek_Cbox.Items.Add(c[i]);
                }


                Refresh1();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.ToString(),"Hata Kod:15", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Refresh1()
        {
            try
            {
                DateTime today = DateTime.Now;
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand();
                mycommand.Connection = myconnection;
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_FullRecordDatagrid";

                SqlDataAdapter myAdaptor = new SqlDataAdapter(mycommand);
                DataTable dt = new DataTable();
                myAdaptor.Fill(dt);
                MydataGridView.DataSource = dt;
                MydataGridView.Refresh();
                myconnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(),"Hata Kod:16", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void izinYazToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinYazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                label_iName.Visible = true;

                Izın_Textbox.Visible = true;


                label_izinSure.Visible = true;

                dateTimePicker_izinbas.Visible = true;

                label_arasi.Visible = true;

                dateTimePicker_izinbit.Visible = true;

                islem_Cbox.SelectedItem = 3;
            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(),"Hata Kod:17", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Unvan_Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Altu_Cbox.Items.Clear();
                string Unvan = Unvan_Cbox.SelectedItem.ToString();
                string[] Altu = sorgu.SelectAuCbox(Unvan);
                for (int i = 0; i < Altu.Length; i++)
                {
                    Altu_Cbox.Items.Add(Altu[i]);
                }
            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(),"Hata Kod:18", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_islemtamam_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = dateTimePicker_Dtarih.Value;
                DateTime Ba = dateTimePicker_BsTarih.Value;
                DateTime Today = DateTime.Now;
                if(Tel_txtbox.Text==""||isim_txtbox.Text==""||soyisim_txtbox.Text==""||TC_txtbox.Text==""||Adres_txtbox.Text==""||Altu_Cbox.SelectedIndex==-1||Bolum_Cbox.SelectedIndex==-1||Meslek_Cbox.SelectedIndex==-1)
                    MessageBox.Show("Hata","Mail dışındaki tüm bölümlerde boşluk olamaz", MessageBoxButtons.OK, MessageBoxIcon.Error); 
               
                else if (islem_Cbox.SelectedItem.ToString() == "Ekle")
                {
                    sorgu.Personel_Ekle(TC_txtbox.Text, isim_txtbox.Text, soyisim_txtbox.Text, a, Convert.ToChar(Cinsiyet_Cbox.SelectedItem), Mail_txtbox.Text, Tel_txtbox.Text, Adres_txtbox.Text);
                    int p = sorgu.FindPid(TC_txtbox.Text);

                    int b = sorgu.FindBid(Bolum_Cbox.SelectedItem.ToString());
                    sorgu.insertCalisirTable(p, b, Ba);
                    int u = sorgu.findUid(Altu_Cbox.SelectedItem.ToString());
                    sorgu.insertSahiptirpuTable(p, u);
                    int m = sorgu.FindMid(Meslek_Cbox.SelectedItem.ToString());
                    sorgu.insertSahiptirTable(m, p);

                    Refresh1();
                }
                else if (islem_Cbox.SelectedItem.ToString() == "Çıkar")
                {
                    int p = sorgu.FindPid(TC_txtbox.Text);

                    sorgu.PersonelSil(p);
                    Refresh1();
                }
                else if (islem_Cbox.SelectedItem.ToString() == "Güncelle")
                {
                    int p = sorgu.FindPid(TC_txtbox.Text);
                    int m = sorgu.FindMid(Meslek_Cbox.SelectedItem.ToString());
                    int u = sorgu.findUid(Altu_Cbox.SelectedItem.ToString());
                    int b = sorgu.FindBid(Bolum_Cbox.SelectedItem.ToString());
                    //Update Personel Eklenicek
                    sorgu.sp_Update(p, m, b, u);
                    Refresh1();
                }
                else if (islem_Cbox.SelectedItem.ToString() == "İzin Yaz")
                {
                    DateTime bas = dateTimePicker_izinbas.Value;
                    DateTime bit = dateTimePicker_izinbit.Value;
                    int p = sorgu.FindPid(TC_txtbox.Text);
                    sorgu.sp_insertizinTable(Izın_Textbox.Text, bas, bit);
                    int i = sorgu.sp_finIid(Izın_Textbox.Text, bas, bit);
                    sorgu.sp_insertAlırIpTable(p, i);

                }
                else if (islem_Cbox.SelectedItem.ToString() == "Ara")
                {
                    try
                    {
                        int Pid = sorgu.FindPid(AraTc_Tb.Text);
                        Arama(Pid);
                    }
                    catch (Exception h)
                    {
                        MessageBox.Show(h.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else if(MaasOnayla_rb.Checked)
                {
                    
                    sorgu.TodayMaasOnayla(Today);
                }
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }


            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(),"Hata Kod:19", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_Cbox.SelectedIndex = 0;
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_Cbox.SelectedIndex = 1;
        }

        private void çıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_Cbox.SelectedIndex = 3;
        }

        private void MydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Sorgular sorgu = new Sorgular();
                int rowindex = MydataGridView.CurrentCell.RowIndex;
                string[] a = new string[11];
                for (int i = 0; i < 11; i++)
                {
                    a[i] = MydataGridView.Rows[rowindex].Cells[i].Value.ToString();
                }
                TC_txtbox.Text = a[0];
                isim_txtbox.Text = a[1];
                soyisim_txtbox.Text = a[2];
                if (a[3] == "E")
                {
                    Cinsiyet_Cbox.SelectedIndex = 0;
                }
                else
                    Cinsiyet_Cbox.SelectedIndex = 1;
                dateTimePicker_Dtarih.Text = a[4];
                Adres_txtbox.Text = a[5];
                Mail_txtbox.Text = a[6];
                Tel_txtbox.Text = a[7];
                string Ust;
                Ust = sorgu.sp_findUstUnvan(a[10]);
                bool bitti = false;
                int j = 0;
                int a1 = 0;
                int a2 = 0;
                int a3 = 0;
                while (bitti == false)
                {
                    if (a1 == 0)
                        Meslek_Cbox.SelectedIndex = j;
                    if (a2 == 0)
                        Bolum_Cbox.SelectedIndex = j;
                    if (a3 == 0)
                        Unvan_Cbox.SelectedIndex = j;
                    if (Meslek_Cbox.SelectedItem.ToString() == a[8])
                    {
                        if (a1 == 0)
                            Meslek_Cbox.SelectedIndex = j;
                        a1 = 1;
                    }
                    if (Bolum_Cbox.SelectedItem.ToString() == a[9])
                    {
                        if (a2 == 0)
                            Bolum_Cbox.SelectedIndex = j;
                        a2 = 1;
                    }
                    if (Unvan_Cbox.SelectedItem.ToString() == Ust)
                    {
                        if (a3 == 0)
                            Unvan_Cbox.SelectedIndex = j;
                        a3 = 1;
                    }
                    if (a1 * a2 * a3 == 1)
                        bitti = true;
                    else
                        j++;
                }
                j = 0;
                while (bitti == true)
                {
                    Altu_Cbox.SelectedIndex = j;
                    if (Altu_Cbox.SelectedItem.ToString() == a[10])
                        bitti = false;
                    else
                        j++;
                }
            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(),"Hata Kod:19", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Arama(int Pid)
        {
            try
            {
                Sorgular sorgu = new Sorgular();
                
                string[] a = new string[11];
                for (int i = 0; i < 11; i++)
                {
                    a[i] = MydataGridView.Rows[Pid-1].Cells[i].Value.ToString();
                }
                TC_txtbox.Text = a[0];
                isim_txtbox.Text = a[1];
                soyisim_txtbox.Text = a[2];
                if (a[3] == "E")
                {
                    Cinsiyet_Cbox.SelectedIndex = 0;
                }
                else
                    Cinsiyet_Cbox.SelectedIndex = 1;
                dateTimePicker_Dtarih.Text = a[4];
                Adres_txtbox.Text = a[5];
                Mail_txtbox.Text = a[6];
                Tel_txtbox.Text = a[7];
                string Ust;
                Ust = sorgu.sp_findUstUnvan(a[10]);
                bool bitti = false;
                int j = 0;
                int a1 = 0;
                int a2 = 0;
                int a3 = 0;
                while (bitti == false)
                {
                    if (a1 == 0)
                        Meslek_Cbox.SelectedIndex = j;
                    if (a2 == 0)
                        Bolum_Cbox.SelectedIndex = j;
                    if (a3 == 0)
                        Unvan_Cbox.SelectedIndex = j;
                    if (Meslek_Cbox.SelectedItem.ToString() == a[8])
                    {
                        if (a1 == 0)
                            Meslek_Cbox.SelectedIndex = j;
                        a1 = 1;
                    }
                    if (Bolum_Cbox.SelectedItem.ToString() == a[9])
                    {
                        if (a2 == 0)
                            Bolum_Cbox.SelectedIndex = j;
                        a2 = 1;
                    }
                    if (Unvan_Cbox.SelectedItem.ToString() == Ust)
                    {
                        if (a3 == 0)
                            Unvan_Cbox.SelectedIndex = j;
                        a3 = 1;
                    }
                    if (a1 * a2 * a3 == 1)
                        bitti = true;
                    else
                        j++;
                }
                j = 0;
                while (bitti == true)
                {
                    Altu_Cbox.SelectedIndex = j;
                    if (Altu_Cbox.SelectedItem.ToString() == a[10])
                        bitti = false;
                    else
                        j++;
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(),"Hata Kod:19", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        public int j { get; set; }

        private void eklemelerPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EklemelerPaneli BolumEkle = new EklemelerPaneli();
            BolumEkle.Show();
            this.Hide();
            
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AraTc_Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaasOnayla_rb_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
