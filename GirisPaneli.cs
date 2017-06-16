using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementProject
{
    public partial class GirisPaneli : Form
    {
       
        public GirisPaneli()
        {
            InitializeComponent();

        }

        Sorgular sorgu = new Sorgular();

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" || tbUsername.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş olamaz", "Hata Kod:1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string a;
                string b;
                a = tbUsername.Text;
                b = tbPassword.Text;
                int c;
                c = sorgu.FindPid(tbPassword.Text);
                string[] d = sorgu.sp_FindBU(b);
                if (d[1] == "Bölüm Yöneticisi")
                {
                    BolumYoneticiPaneli frm3 = new BolumYoneticiPaneli();
                    frm3.Bname.Text = d[0];
                    frm3.Show();
                    this.Hide();
                }
                else if (d[1] == "Fabrika Yöneticisi")
                {
                    YoneticiPaneli frm2 = new YoneticiPaneli();
                    frm2.Tb_Pid.Text = c.ToString();
                    frm2.Show();
                    this.Hide();
                }
                else if (d[1] == "Fabrika Sekreteri")
                {
                    SekreterPaneli frm4 = new SekreterPaneli();
                    frm4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Buraya Giriş Hakkınız Yok", "Hata Kod:2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
