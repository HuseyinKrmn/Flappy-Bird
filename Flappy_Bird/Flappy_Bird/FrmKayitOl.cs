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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {

        }
        // Formun kapatılması
        private void FrmKayitOl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
                FrmGiris _frmGiris = new FrmGiris();
                _frmGiris.ShowDialog();
            }
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiNesnesi"].ToString());
        // Kullanıcıları veri tabanına kaydettiğimiz yer
        private void BtnVeriTabaniKaydet_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(TxtKullaniciAdi.Text) || string.IsNullOrEmpty(TxtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TxtKullaniciAdi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtKullaniciAdi.Text);
                string sql = "insert into Kayit(KullaniciAd,Sifre,Skor) values(@KullaniciAd,@Sifre,@Skor)";
                SqlCommand Yonet = new SqlCommand(sql, baglanti);
                Yonet.Parameters.AddWithValue("@KullaniciAd", TxtKullaniciAdi.Text);
                Yonet.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                Yonet.Parameters.AddWithValue("@Skor", 0);
                baglanti.Open();
                Yonet.ExecuteNonQuery();
                Yonet.Dispose();
                baglanti.Close();
                baglanti.Dispose();
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();

                MessageBox.Show("Bilgileriniz veri tabanına kayıt olmuşur. İyi eğlenceler.", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FrmGiris frmGiris = new FrmGiris();
                frmGiris.ShowDialog();
            }

        }
    }
}
