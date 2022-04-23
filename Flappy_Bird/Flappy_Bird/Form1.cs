using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace Flappy_Bird
{

   

    public partial class FrmGiris : Form
    {
        public static string gidenbilgi = "";



       SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiNesnesi"].ToString());

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayitOl _kayitOl = new FrmKayitOl();
            _kayitOl.ShowDialog();
        }

        // Form kapatıldığında
        DialogResult sonuc;
        private void FrmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            sonuc = MessageBox.Show("Bu güzel oyundan çıkmak istiyor musun?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // Oyuna giriş yaptığımız bölüm
        private void BtnOyunaGiris_Click(object sender, EventArgs e)
        {
            TxtKullaniciAdi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtKullaniciAdi.Text);
            baglanti.Open();
            string sql = "select * from Kayit  where KullaniciAd='" + TxtKullaniciAdi.Text + "'";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                if (TxtKullaniciAdi.Text == dr["KullaniciAd"].ToString().Trim() && TxtSifre.Text == dr["Sifre"].ToString().Trim())
                {
                    gidenbilgi = TxtKullaniciAdi.Text;
                    
                    FrmOyun _frmOyun = new FrmOyun();
                    _frmOyun.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            komut.Dispose();
            baglanti.Close();
            baglanti.Dispose();


            
            




        }
    }
}
