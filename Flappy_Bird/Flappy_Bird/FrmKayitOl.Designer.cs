
namespace Flappy_Bird
{
    partial class FrmKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitOl));
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnVeriTabaniKaydet = new System.Windows.Forms.Button();
            this.LblSifre = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.LblKullaniciAdi.Location = new System.Drawing.Point(101, 89);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.LblKullaniciAdi.TabIndex = 0;
            this.LblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(253, 89);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(172, 20);
            this.TxtKullaniciAdi.TabIndex = 1;
            // 
            // BtnVeriTabaniKaydet
            // 
            this.BtnVeriTabaniKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeriTabaniKaydet.Location = new System.Drawing.Point(253, 190);
            this.BtnVeriTabaniKaydet.Name = "BtnVeriTabaniKaydet";
            this.BtnVeriTabaniKaydet.Size = new System.Drawing.Size(172, 23);
            this.BtnVeriTabaniKaydet.TabIndex = 2;
            this.BtnVeriTabaniKaydet.Text = "Kaydet";
            this.BtnVeriTabaniKaydet.UseVisualStyleBackColor = true;
            this.BtnVeriTabaniKaydet.Click += new System.EventHandler(this.BtnVeriTabaniKaydet_Click);
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.ForeColor = System.Drawing.Color.White;
            this.LblSifre.Location = new System.Drawing.Point(101, 130);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(62, 20);
            this.LblSifre.TabIndex = 3;
            this.LblSifre.Text = "Şifre : ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(253, 130);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(172, 20);
            this.TxtSifre.TabIndex = 4;
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(532, 299);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.BtnVeriTabaniKaydet);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Name = "FrmKayitOl";
            this.Text = "FrmKayitOl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKayitOl_FormClosing);
            this.Load += new System.EventHandler(this.FrmKayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKullaniciAdi;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Button BtnVeriTabaniKaydet;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}