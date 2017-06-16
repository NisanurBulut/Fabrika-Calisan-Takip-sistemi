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
    public partial class BolumYoneticiPaneli : Form
    {
        public BolumYoneticiPaneli()
        {
            InitializeComponent();
        }
        Sorgular sorgu = new Sorgular();
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                string[] b = sorgu.SelectUnvanCbox();

                for (int i = 0; i < b.Length; i++)
                {
                    ukategori.Items.Add(b[i]);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString(),"Hata Kod:10", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void Refresh1(int a,DateTime b,DateTime c)
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
                MessageBox.Show(e.ToString(),"Hata Kod:11", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mail frm6 = new Mail();
                frm6.formadi_Tb.Text = this.Name.ToString();
                frm6.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(),"Hata Kod:12", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cek_Click(object sender, EventArgs e)
        {
            try
            {
                int a = sorgu.sp_findBid_Bisim(Bname.Text);
                DateTime b = tarih1.Value;
                DateTime c = tarih2.Value;
                if(comboBox1.SelectedIndex==0)
                {
                    b=DateTime.Now;
                    c=DateTime.Now;
                    Refresh1(a, b, c);
                }
                else if(comboBox1.SelectedIndex==1)
                {
                    c = DateTime.Now;
                    b=c.AddDays(-7);
                    
                    Refresh1(a, b, c);
                }
                else if(comboBox1.SelectedIndex==2)
                {
                    c = DateTime.Now;
                    b=c.AddYears(-1);
                    Refresh1(a, b, c);
                }
                else 
                {
                    Refresh1(a, b, c);
                }
            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(), "Hata Kod:13", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch(Exception g)
            {
                MessageBox.Show (g.ToString(),"Hata Kod:14", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yıllıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void aylıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void yıllıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

        
}
   

    