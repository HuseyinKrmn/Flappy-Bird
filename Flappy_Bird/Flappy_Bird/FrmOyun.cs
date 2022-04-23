using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;

namespace Flappy_Bird
{



    public partial class FrmOyun : Form
    {

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiNesnesi"].ToString());

        public PrivateFontCollection pcf = new PrivateFontCollection();
        public int BirdTopCount = 0;
        public int OyunSkor = 0;
        public int OyunEnIyiSkor = 0;

        public FrmOyun()
        {
            InitializeComponent();
        }


        // Oyun içi font değişikliği
        private void FrmOyun_Load(object sender, EventArgs e)
        {

            LblKullaniciIsmi.Text = FrmGiris.gidenbilgi;

            int fontLenght = Properties.Resources.flappyfont.Length;
            byte[] fontdata = Properties.Resources.flappyfont;
            IntPtr data = Marshal.AllocCoTaskMem(fontLenght);
            Marshal.Copy(fontdata, 0, data, fontLenght);
            pcf.AddMemoryFont(data, fontLenght);
            Marshal.FreeCoTaskMem(data);


            LblOyunSkor.Font = new Font(pcf.Families[0], LblOyunSkor.Font.Size);
            LblYardim.Font = new Font(pcf.Families[0], LblYardim.Font.Size);
            LblBoardSkor.Font = new Font(pcf.Families[0], LblBoardSkor.Font.Size);
            LblBoardSkorTxt.Font = new Font(pcf.Families[0], LblBoardSkorTxt.Font.Size);
            LblEnIyiSkor.Font = new Font(pcf.Families[0], LblEnIyiSkor.Font.Size);
            LblBoardEnIyiSkor.Font = new Font(pcf.Families[0], LblBoardEnIyiSkor.Font.Size);

            TemaMuzik();
        }
        // genel kurallar
        private void OyunTimer_Tick(object sender, EventArgs e)
        {
            if ((pcbUstBoru1.Bottom + BirdTopCount) >= pcbZemin.Bounds.Top)
            {
                OyunSonu();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbAltBoru.Bounds))
            {
                OyunSonu();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbUstBoru1.Bounds))
            {
                OyunSonu();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbAltBoru2.Bounds))
            {
                OyunSonu();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbUstBoru2.Bounds))
            {
                OyunSonu();
            }
            else
            {
                if (pcbFlappyBird.Left >= pcbUstBoru1.Right && pcbFlappyBird.Left - 10 <= pcbUstBoru1.Right)
                {
                    OyunSkor++;
                    LblOyunSkor.Text = OyunSkor.ToString();
                    MuzikCalar("point");
                }
                else if (pcbFlappyBird.Left >= pcbUstBoru2.Right && pcbFlappyBird.Left - 10 <= pcbUstBoru2.Right)
                {
                    OyunSkor++;
                    LblOyunSkor.Text = OyunSkor.ToString();
                    MuzikCalar("point");
                }

                pcbFlappyBird.Top += BirdTopCount;

                pcbAltBoru.Left -= 10;
                pcbUstBoru1.Left -= 10;

                pcbAltBoru2.Left -= 10;
                pcbUstBoru2.Left -= 10;



                Random _random = new Random();
                if (pcbAltBoru.Left < -pcbAltBoru.Width)
                {
                    pcbAltBoru.Left = this.Size.Width;
                    pcbUstBoru1.Left = this.Size.Width;

                    int rndUstBorular = _random.Next(500, 750);
                    int fark = pcbAltBoru.Top - rndUstBorular;
                    pcbAltBoru.Top = rndUstBorular;
                    pcbUstBoru1.Top -= fark;
                }
                if (pcbAltBoru2.Left < -pcbAltBoru2.Width)
                {
                    int rndMesafe = _random.Next(450, 590);
                    pcbAltBoru2.Left = pcbAltBoru.Left + rndMesafe;
                    pcbUstBoru2.Left = pcbAltBoru.Left + rndMesafe;

                    int rndUstBoru = _random.Next(500, 750);
                    int fark = pcbAltBoru2.Top - rndUstBoru;
                    pcbAltBoru2.Top = rndUstBoru;
                    pcbUstBoru2.Top -= fark;
                }




            }
        }
        // başlamada ve sonlanmada olan kurallar
        private void OyunaBasla()
        {
            OyunSkor = 0;
            LblOyunSkor.Text = "0";
            BoruDuzen();
            BtnBasla.Visible = false;
            LblYardim.Visible = false;
            BtnTekrar.Visible = false;
            pnlBoard.Visible = false;
            BirdTopCount = 0;
            OyunTimer.Start();
        }
        private void OyunSonu()
        {
            MuzikCalar("hit");
            LblBoardSkor.Text = "Oyun Bitti";
            OyunTimer.Stop();

            Thread.Sleep(1000);
            


            MuzikCalar("die");

            pcbUstBoru1.Visible = false;
            pcbAltBoru.Visible = false;

            pcbUstBoru2.Visible = false;
            pcbAltBoru2.Visible = false;

            BtnTekrar.Visible = true;
            pcbFlappyBird.Visible = false;

            LblBoardSkor.Text = OyunSkor.ToString();
            LblEnIyiSkor.Text = OyunEnIyiSkor.ToString();

            pnlBoard.Visible = true;


            string ad = FrmGiris.gidenbilgi;
            SqlCommand komut;
            baglanti.Open();
            string sorgu = "select KullaniciAd,Skor from Kayit";
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAd"].ToString() == ad)
                {
                    int dSkor = int.Parse(oku["Skor"].ToString());
                    if (dSkor < OyunSkor)
                    {
                        oku.Close();
                        sorgu = "UPDATE Kayit SET Skor=@skor where KullaniciAd=@Ad";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Ad", ad);
                        komut.Parameters.AddWithValue("@skor", OyunSkor);
                        komut.ExecuteNonQuery();
                        break;
                    }
                }
            }
            baglanti.Close();
            oku.Close();
            baglanti.Open();
            SqlCommand komut2;
            string sorgu2 = "select KullaniciAd,Skor from Kayit";
            komut2 = new SqlCommand(sorgu2, baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["KullaniciAd"].ToString()==ad)
                {
                    LblEnIyiSkor.Text = oku2["Skor"].ToString();
                }
            }
            oku2.Close();
            baglanti.Close();
            TemaMuzik();
        }

        // kuşun hareketi
        private void FrmOyun_KeyDown(object sender, KeyEventArgs e)
        {
            if (BtnBasla.Visible)
            {
                OyunaBasla();
            }
            if (e.KeyCode == Keys.Space)
            {
                BirdTopCount = -15;
                MuzikCalar("jump");
            }
        }
        private void FrmOyun_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                BirdTopCount = 15;
            }

        }

        // butonların işlevi
        private void BtnBasla_MouseClick(object sender, MouseEventArgs e)
        {
            OyunaBasla();
        }
        private void BtnBasla_MouseEnter(object sender, EventArgs e)
        {
            BtnBasla.Top += 2;
        }
        private void BtnBasla_MouseLeave(object sender, EventArgs e)
        {
            BtnBasla.Top -= 2;
        }

        private void BtnTekrar_MouseClick(object sender, MouseEventArgs e)
        {
            
            OyunaBasla();
        }
        private void BtnTekrar_MouseEnter(object sender, EventArgs e)
        {
            BtnTekrar.Top += 2;
        }
        private void BtnTekrar_MouseLeave(object sender, EventArgs e)
        {
            BtnTekrar.Top -= 2;
        }

        // form kapatıldığında
        private void FrmOyun_FormClosed(object sender, FormClosedEventArgs e)
        {
            pcf.Dispose();
        }

        // ratgele gelen boruların düzeni
        private void BoruDuzen()
        {
            pcbUstBoru1.Location = new Point(602, -535);
            pcbAltBoru.Location = new Point(602, 500);
            pcbUstBoru2.Location = new Point(1000, -535);
            pcbAltBoru2.Location = new Point(1000, 500);
            pcbFlappyBird.Location = new Point(345, 271);

            pcbUstBoru1.Visible = true;
            pcbAltBoru.Visible = true;
            pcbUstBoru2.Visible = true;
            pcbAltBoru2.Visible = true;
            pcbFlappyBird.Visible = true;
        }

        // Müzikler
        private void MuzikCalar(string MuzikIsmi)
        {
            SoundPlayer sound = new SoundPlayer();
            switch (MuzikIsmi)
            {
                case "jump":
                    sound.Stream = Properties.Resources.JumpSound;
                    break;
                case "point":
                    sound.Stream = Properties.Resources.PointSound;
                    break;
                case "die":
                    sound.Stream = Properties.Resources.DieSound;
                    break;
                case "hit":
                    sound.Stream = Properties.Resources.HitSound;
                    break;
            }
            sound.Play();
        }
        private void TemaMuzik()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.ThemeSound);
            sound.PlayLooping();
        }
    }
}
