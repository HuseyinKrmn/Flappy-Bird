
namespace Flappy_Bird
{
    partial class FrmOyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyun));
            this.pcbFlappyBird = new System.Windows.Forms.PictureBox();
            this.pcbUstBoru1 = new System.Windows.Forms.PictureBox();
            this.pcbUstBoru2 = new System.Windows.Forms.PictureBox();
            this.pcbZemin = new System.Windows.Forms.PictureBox();
            this.pcbAltBoru2 = new System.Windows.Forms.PictureBox();
            this.pcbAltBoru = new System.Windows.Forms.PictureBox();
            this.OyunTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.LblBoardEnIyiSkor = new System.Windows.Forms.Label();
            this.LblEnIyiSkor = new System.Windows.Forms.Label();
            this.LblBoardSkorTxt = new System.Windows.Forms.Label();
            this.LblBoardSkor = new System.Windows.Forms.Label();
            this.LblOyunSkor = new System.Windows.Forms.Label();
            this.LblYardim = new System.Windows.Forms.Label();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.BtnTekrar = new System.Windows.Forms.Button();
            this.LblKullaniciIsmi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUstBoru1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUstBoru2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltBoru2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltBoru)).BeginInit();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbFlappyBird
            // 
            this.pcbFlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.pcbFlappyBird.BackgroundImage = global::Flappy_Bird.Properties.Resources.bird;
            this.pcbFlappyBird.Location = new System.Drawing.Point(342, 271);
            this.pcbFlappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.pcbFlappyBird.Name = "pcbFlappyBird";
            this.pcbFlappyBird.Size = new System.Drawing.Size(87, 64);
            this.pcbFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbFlappyBird.TabIndex = 0;
            this.pcbFlappyBird.TabStop = false;
            // 
            // pcbUstBoru1
            // 
            this.pcbUstBoru1.BackColor = System.Drawing.Color.Transparent;
            this.pcbUstBoru1.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pcbUstBoru1.Location = new System.Drawing.Point(602, -541);
            this.pcbUstBoru1.Margin = new System.Windows.Forms.Padding(0);
            this.pcbUstBoru1.Name = "pcbUstBoru1";
            this.pcbUstBoru1.Size = new System.Drawing.Size(138, 793);
            this.pcbUstBoru1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbUstBoru1.TabIndex = 1;
            this.pcbUstBoru1.TabStop = false;
            this.pcbUstBoru1.Visible = false;
            // 
            // pcbUstBoru2
            // 
            this.pcbUstBoru2.BackColor = System.Drawing.Color.Transparent;
            this.pcbUstBoru2.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pcbUstBoru2.Location = new System.Drawing.Point(436, -541);
            this.pcbUstBoru2.Margin = new System.Windows.Forms.Padding(0);
            this.pcbUstBoru2.Name = "pcbUstBoru2";
            this.pcbUstBoru2.Size = new System.Drawing.Size(138, 793);
            this.pcbUstBoru2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbUstBoru2.TabIndex = 2;
            this.pcbUstBoru2.TabStop = false;
            this.pcbUstBoru2.Visible = false;
            // 
            // pcbZemin
            // 
            this.pcbZemin.BackColor = System.Drawing.Color.Transparent;
            this.pcbZemin.BackgroundImage = global::Flappy_Bird.Properties.Resources.ground;
            this.pcbZemin.Location = new System.Drawing.Point(-12, 810);
            this.pcbZemin.Margin = new System.Windows.Forms.Padding(0);
            this.pcbZemin.Name = "pcbZemin";
            this.pcbZemin.Size = new System.Drawing.Size(752, 94);
            this.pcbZemin.TabIndex = 3;
            this.pcbZemin.TabStop = false;
            // 
            // pcbAltBoru2
            // 
            this.pcbAltBoru2.BackColor = System.Drawing.Color.Transparent;
            this.pcbAltBoru2.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe;
            this.pcbAltBoru2.Location = new System.Drawing.Point(449, 466);
            this.pcbAltBoru2.Margin = new System.Windows.Forms.Padding(0);
            this.pcbAltBoru2.Name = "pcbAltBoru2";
            this.pcbAltBoru2.Size = new System.Drawing.Size(138, 793);
            this.pcbAltBoru2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbAltBoru2.TabIndex = 4;
            this.pcbAltBoru2.TabStop = false;
            this.pcbAltBoru2.Visible = false;
            // 
            // pcbAltBoru
            // 
            this.pcbAltBoru.BackColor = System.Drawing.Color.Transparent;
            this.pcbAltBoru.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe;
            this.pcbAltBoru.Location = new System.Drawing.Point(602, 466);
            this.pcbAltBoru.Margin = new System.Windows.Forms.Padding(0);
            this.pcbAltBoru.Name = "pcbAltBoru";
            this.pcbAltBoru.Size = new System.Drawing.Size(138, 793);
            this.pcbAltBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbAltBoru.TabIndex = 5;
            this.pcbAltBoru.TabStop = false;
            this.pcbAltBoru.Visible = false;
            // 
            // OyunTimer
            // 
            this.OyunTimer.Interval = 15;
            this.OyunTimer.Tick += new System.EventHandler(this.OyunTimer_Tick);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackgroundImage = global::Flappy_Bird.Properties.Resources.board;
            this.pnlBoard.Controls.Add(this.LblBoardEnIyiSkor);
            this.pnlBoard.Controls.Add(this.LblEnIyiSkor);
            this.pnlBoard.Controls.Add(this.LblBoardSkorTxt);
            this.pnlBoard.Controls.Add(this.LblBoardSkor);
            this.pnlBoard.Location = new System.Drawing.Point(187, 271);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(418, 225);
            this.pnlBoard.TabIndex = 6;
            this.pnlBoard.Visible = false;
            // 
            // LblBoardEnIyiSkor
            // 
            this.LblBoardEnIyiSkor.AutoSize = true;
            this.LblBoardEnIyiSkor.BackColor = System.Drawing.Color.Transparent;
            this.LblBoardEnIyiSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBoardEnIyiSkor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblBoardEnIyiSkor.Location = new System.Drawing.Point(68, 132);
            this.LblBoardEnIyiSkor.Name = "LblBoardEnIyiSkor";
            this.LblBoardEnIyiSkor.Size = new System.Drawing.Size(174, 37);
            this.LblBoardEnIyiSkor.TabIndex = 9;
            this.LblBoardEnIyiSkor.Text = "EN İYİ SKOR";
            this.LblBoardEnIyiSkor.UseCompatibleTextRendering = true;
            // 
            // LblEnIyiSkor
            // 
            this.LblEnIyiSkor.AutoSize = true;
            this.LblEnIyiSkor.BackColor = System.Drawing.Color.Transparent;
            this.LblEnIyiSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEnIyiSkor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblEnIyiSkor.Location = new System.Drawing.Point(288, 127);
            this.LblEnIyiSkor.Name = "LblEnIyiSkor";
            this.LblEnIyiSkor.Size = new System.Drawing.Size(31, 45);
            this.LblEnIyiSkor.TabIndex = 11;
            this.LblEnIyiSkor.Text = "0";
            this.LblEnIyiSkor.UseCompatibleTextRendering = true;
            // 
            // LblBoardSkorTxt
            // 
            this.LblBoardSkorTxt.AutoSize = true;
            this.LblBoardSkorTxt.BackColor = System.Drawing.Color.Transparent;
            this.LblBoardSkorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBoardSkorTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblBoardSkorTxt.Location = new System.Drawing.Point(97, 43);
            this.LblBoardSkorTxt.Name = "LblBoardSkorTxt";
            this.LblBoardSkorTxt.Size = new System.Drawing.Size(109, 45);
            this.LblBoardSkorTxt.TabIndex = 8;
            this.LblBoardSkorTxt.Text = "SKOR";
            this.LblBoardSkorTxt.UseCompatibleTextRendering = true;
            // 
            // LblBoardSkor
            // 
            this.LblBoardSkor.AutoSize = true;
            this.LblBoardSkor.BackColor = System.Drawing.Color.Transparent;
            this.LblBoardSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBoardSkor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblBoardSkor.Location = new System.Drawing.Point(288, 43);
            this.LblBoardSkor.Name = "LblBoardSkor";
            this.LblBoardSkor.Size = new System.Drawing.Size(31, 45);
            this.LblBoardSkor.TabIndex = 10;
            this.LblBoardSkor.Text = "0";
            this.LblBoardSkor.UseCompatibleTextRendering = true;
            // 
            // LblOyunSkor
            // 
            this.LblOyunSkor.AutoSize = true;
            this.LblOyunSkor.BackColor = System.Drawing.Color.Transparent;
            this.LblOyunSkor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblOyunSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOyunSkor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblOyunSkor.Location = new System.Drawing.Point(187, 161);
            this.LblOyunSkor.MinimumSize = new System.Drawing.Size(400, 0);
            this.LblOyunSkor.Name = "LblOyunSkor";
            this.LblOyunSkor.Size = new System.Drawing.Size(400, 84);
            this.LblOyunSkor.TabIndex = 0;
            this.LblOyunSkor.Text = "0";
            this.LblOyunSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblOyunSkor.UseCompatibleTextRendering = true;
            // 
            // LblYardim
            // 
            this.LblYardim.AutoSize = true;
            this.LblYardim.BackColor = System.Drawing.Color.Transparent;
            this.LblYardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYardim.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblYardim.Location = new System.Drawing.Point(255, 539);
            this.LblYardim.Name = "LblYardim";
            this.LblYardim.Size = new System.Drawing.Size(352, 37);
            this.LblYardim.TabIndex = 7;
            this.LblYardim.Text = "Başlamak için SPACE basın";
            this.LblYardim.UseCompatibleTextRendering = true;
            // 
            // BtnBasla
            // 
            this.BtnBasla.BackgroundImage = global::Flappy_Bird.Properties.Resources.start;
            this.BtnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBasla.Location = new System.Drawing.Point(287, 429);
            this.BtnBasla.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(214, 75);
            this.BtnBasla.TabIndex = 12;
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnBasla_MouseClick);
            this.BtnBasla.MouseEnter += new System.EventHandler(this.BtnBasla_MouseEnter);
            this.BtnBasla.MouseLeave += new System.EventHandler(this.BtnBasla_MouseLeave);
            // 
            // BtnTekrar
            // 
            this.BtnTekrar.BackgroundImage = global::Flappy_Bird.Properties.Resources.restart;
            this.BtnTekrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTekrar.Location = new System.Drawing.Point(287, 525);
            this.BtnTekrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTekrar.Name = "BtnTekrar";
            this.BtnTekrar.Size = new System.Drawing.Size(214, 75);
            this.BtnTekrar.TabIndex = 13;
            this.BtnTekrar.UseVisualStyleBackColor = true;
            this.BtnTekrar.Visible = false;
            this.BtnTekrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTekrar_MouseClick);
            this.BtnTekrar.MouseEnter += new System.EventHandler(this.BtnTekrar_MouseEnter);
            this.BtnTekrar.MouseLeave += new System.EventHandler(this.BtnTekrar_MouseLeave);
            // 
            // LblKullaniciIsmi
            // 
            this.LblKullaniciIsmi.AutoSize = true;
            this.LblKullaniciIsmi.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciIsmi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblKullaniciIsmi.Location = new System.Drawing.Point(12, 18);
            this.LblKullaniciIsmi.Name = "LblKullaniciIsmi";
            this.LblKullaniciIsmi.Size = new System.Drawing.Size(226, 39);
            this.LblKullaniciIsmi.TabIndex = 14;
            this.LblKullaniciIsmi.Text = "___________";
            // 
            // FrmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 897);
            this.Controls.Add(this.LblKullaniciIsmi);
            this.Controls.Add(this.LblYardim);
            this.Controls.Add(this.pcbFlappyBird);
            this.Controls.Add(this.pcbZemin);
            this.Controls.Add(this.pcbUstBoru1);
            this.Controls.Add(this.pcbUstBoru2);
            this.Controls.Add(this.pcbAltBoru);
            this.Controls.Add(this.pcbAltBoru2);
            this.Controls.Add(this.LblOyunSkor);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.BtnTekrar);
            this.Controls.Add(this.pnlBoard);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmOyun";
            this.Text = "Flappy Bird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOyun_FormClosed);
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOyun_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmOyun_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUstBoru1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUstBoru2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltBoru2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltBoru)).EndInit();
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFlappyBird;
        private System.Windows.Forms.PictureBox pcbUstBoru1;
        private System.Windows.Forms.PictureBox pcbUstBoru2;
        private System.Windows.Forms.PictureBox pcbZemin;
        private System.Windows.Forms.PictureBox pcbAltBoru2;
        private System.Windows.Forms.PictureBox pcbAltBoru;
        private System.Windows.Forms.Timer OyunTimer;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label LblBoardEnIyiSkor;
        private System.Windows.Forms.Label LblEnIyiSkor;
        private System.Windows.Forms.Label LblBoardSkorTxt;
        private System.Windows.Forms.Label LblBoardSkor;
        private System.Windows.Forms.Label LblOyunSkor;
        private System.Windows.Forms.Label LblYardim;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Button BtnTekrar;
        public System.Windows.Forms.Label LblKullaniciIsmi;
    }
}