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
    public partial class EklemelerPaneli : Form
    {
        public EklemelerPaneli()
        {
            InitializeComponent();
        }
        Sorgular sorgu = new Sorgular();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int[] a = new int[4];
                if (textBox_bolum.Text != "")
                {
                    a[0] = 1;
                    sorgu.sp_insertBolum(textBox_bolum.Text);
                }
                if (textBox_Meslek.Text != "")
                {
                    a[1] = 1;
                    sorgu.insertMeslekTable(textBox_Meslek.Text);
                }
                if (textBox_Birim.Text != "")
                {
                    a[2] = 1;
                    sorgu.sp_insertBirim(textBox_Birim.Text);
                }
                if (textBox_Unvan.Text != "")
                    if (Unvan_comboBox.SelectedItem.ToString() == "")
                        MessageBox.Show("Unvanın yanında bulunan birimi seçiniz unvan eklemek istemiyorsanız unvan ve maas carpanı bölmelerini siliniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (textBox_MaasCarpani.Text == "")
                            MessageBox.Show("Unvanın yanında bulunan birimi seçiniz unvan eklemek istemiyorsanız unvan ve maas carpanı bölmelerini siliniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            a[3] = 1;
                            int u = sorgu.findUid(Unvan_comboBox.SelectedItem.ToString());
                            sorgu.sp_insertAltU(u, textBox_Unvan.Text, Convert.ToInt32(textBox_MaasCarpani.Text.ToString()));
                        }
                SekreterPaneli frm2 = new SekreterPaneli();
                frm2.Show();
                this.Close();
            }
            catch(Exception g)
            {
                MessageBox.Show(g.ToString(), "Hata Kod:20", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                string[] b = sorgu.SelectUnvanCbox();

                for (int i = 0; i < b.Length; i++)
                {
                    Unvan_comboBox.Items.Add(b[i]);
                }
            }
            catch(Exception h)
            {
                MessageBox.Show(h.ToString(),"Hata Kod:21", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
