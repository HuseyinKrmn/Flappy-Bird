
namespace Flappy_Bird
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnOyunaGiris = new System.Windows.Forms.Button();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.LblSifre = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(274, 162);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(236, 20);
            this.TxtKullaniciAdi.TabIndex = 0;
            // 
            // BtnOyunaGiris
            // 
            this.BtnOyunaGiris.Location = new System.Drawing.Point(322, 225);
            this.BtnOyunaGiris.Name = "BtnOyunaGiris";
            this.BtnOyunaGiris.Size = new System.Drawing.Size(107, 44);
            this.BtnOyunaGiris.TabIndex = 1;
            this.BtnOyunaGiris.Text = "Oyuna Giriş";
            this.BtnOyunaGiris.UseVisualStyleBackColor = true;
            this.BtnOyunaGiris.Click += new System.EventHandler(this.BtnOyunaGiris_Click);
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.Location = new System.Drawing.Point(322, 275);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(107, 44);
            this.BtnKayitOl.TabIndex = 5;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = true;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.ForeColor = System.Drawing.Color.White;
            this.LblSifre.Location = new System.Drawing.Point(163, 188);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(54, 20);
            this.LblSifre.TabIndex = 4;
            this.LblSifre.Text = "Şifre : ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(274, 188);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(236, 20);
            this.TxtSifre.TabIndex = 3;
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.LblKullaniciAdi.Location = new System.Drawing.Point(163, 162);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(105, 20);
            this.LblKullaniciAdi.TabIndex = 2;
            this.LblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 455);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.BtnOyunaGiris);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Name = "FrmGiris";
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnKayitOl;
        public System.Windows.Forms.TextBox TxtKullaniciAdi;
        public System.Windows.Forms.Button BtnOyunaGiris;
        public System.Windows.Forms.Label LblSifre;
        public System.Windows.Forms.TextBox TxtSifre;
        public System.Windows.Forms.Label LblKullaniciAdi;
    }
}

