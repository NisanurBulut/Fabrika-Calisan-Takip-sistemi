using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DatabaseManagementProject
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }
        Sorgular sorgu = new Sorgular();
        private void asdToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void Refresh1(int a, DateTime b, DateTime c)
        {
            try
            {
                Sorgular sorgu = new Sorgular();
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                myconnection.Open();
                SqlCommand sorgu1 = new SqlCommand();
                sorgu1.Connection = myconnection;
                sorgu1.CommandType = CommandType.StoredProcedure;
                sorgu1.CommandText = "sp_GosterCalisanBolum";
                sorgu1.Parameters.AddWithValue("@Bid", a);
                sorgu1.Parameters.AddWithValue("@Tarih1", b);
                sorgu1.Parameters.AddWithValue("Tarih2", c);
                SqlDataAdapter myAdaptor = new SqlDataAdapter(sorgu1);
                DataTable dt = new DataTable();
                myAdaptor.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                myconnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(),"Hata Kod:3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Refresh2(int a, DateTime b, DateTime c,string unvan)
        {
            try
            {
                Sorgular sorgu = new Sorgular();
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                myconnection.Open();
                SqlCommand sorgu1 = new SqlCommand();
                sorgu1.Connection = myconnection;
                sorgu1.CommandType = CommandType.StoredProcedure;
                sorgu1.CommandText = "sp_GosterCalisan_Unvan";
                sorgu1.Parameters.AddWithValue("@Bid", a);
                sorgu1.Parameters.AddWithValue("@Tarih1", b);
                sorgu1.Parameters.AddWithValue("@Tarih2", c);
                sorgu1.Parameters.AddWithValue("@UnvanName", unvan);
                SqlDataAdapter myAdaptor = new SqlDataAdapter(sorgu1);
                DataTable dt = new DataTable();
                myAdaptor.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                myconnection.Close();
            }
            catch (Exception e)
                {
                    MessageBox.Show(e.ToString(),"Hata Kod:4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                string[] a = sorgu.SelectBolumCBox();

                for (int i = 0; i < a.Length; i++)
                {
                    bolumadı.Items.Add(a[i]);
                }

                string[] b = sorgu.SelectUnvanCbox();

                for (int i = 0; i < b.Length; i++)
                {
                    ukategori.Items.Add(b[i]);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString(), "Hata Kod:5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                Mail mail = new Mail();
                mail.formadi_Tb.Text = this.Name.ToString();
                mail.Show();
                this.Hide();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.ToString(),"Hata Kod:6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cek_Click(object sender, EventArgs e)
        {
            DateTime b= tarih1.Value;
            DateTime c=tarih2.Value;
            
            if (Gorev_Checked.Checked&&akategori.SelectedIndex!=-1)
            {
                try
                {
                    int a = sorgu.sp_findBid_Bisim(bolumadı.SelectedItem.ToString());
                    string d = akategori.SelectedItem.ToString();
                    if (comboBox1.SelectedIndex == 0)
                    {

                        c = DateTime.Now;
                        b = c.AddDays(-1);
                        Refresh2(a, b, c,d);
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        c = DateTime.Now;
                        b = c.AddMonths(-1);
                        Refresh2(a, b, c,d);
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        c = DateTime.Now;
                        b = c.AddYears(-1);
                        Refresh2(a, b, c,d);
                    }
                    else
                    {
                        Refresh2(a, b, c, d);
                    }
                }
                catch(Exception g)
                {
                    MessageBox.Show(g.ToString(), "Hata Kod:7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    int a = sorgu.sp_findBid_Bisim(bolumadı.SelectedItem.ToString());
                    if (comboBox1.SelectedIndex == 0)
                    {
                        
                        c = DateTime.Now;
                        b = c.AddDays(-1);
                        Refresh1(a, b, c);
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        c = DateTime.Now;
                        b = c.AddMonths(-1);
                        Refresh1(a, b, c);
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        c = DateTime.Now;
                        b = c.AddYears(-1);
                        Refresh1(a, b, c);
                    }
                    else
                    {
                        Refresh1(a, b, c);
                    }
                }
                catch(Exception h)
                {
                    MessageBox.Show(h.ToString(),"Hata Kod:8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ukategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                akategori.Items.Clear();
                string Unvan = ukategori.SelectedItem.ToString();
                string[] Altu = sorgu.SelectAuCbox(Unvan);
                for (int i = 0; i < Altu.Length; i++)
                {
                    akategori.Items.Add(Altu[i]);
                }
            }
            catch(Exception j)
            {
                MessageBox.Show(j.ToString(),"Hata Kod:9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void akategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void aylıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void yıllıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        
    }
}
