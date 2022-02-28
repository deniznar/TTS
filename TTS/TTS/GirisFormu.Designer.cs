namespace TTS
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.girisGrupKutusu = new System.Windows.Forms.GroupBox();
            this.kapatDugmesi = new System.Windows.Forms.Button();
            this.girisDugmesi = new System.Windows.Forms.Button();
            this.sfrMetinKutusu = new System.Windows.Forms.TextBox();
            this.adMetinKutusu = new System.Windows.Forms.TextBox();
            this.sfrEtiketi = new System.Windows.Forms.Label();
            this.adEtiketi = new System.Windows.Forms.Label();
            this.baslikEtiketi = new System.Windows.Forms.Label();
            this.lisansEtiketi = new System.Windows.Forms.Label();
            this.cteLogosu = new System.Windows.Forms.PictureBox();
            this.abLogosu = new System.Windows.Forms.PictureBox();
            this.girisGorseli = new System.Windows.Forms.PictureBox();
            this.girisGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cteLogosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abLogosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).BeginInit();
            this.SuspendLayout();
            // 
            // girisGrupKutusu
            // 
            this.girisGrupKutusu.Controls.Add(this.kapatDugmesi);
            this.girisGrupKutusu.Controls.Add(this.girisDugmesi);
            this.girisGrupKutusu.Controls.Add(this.sfrMetinKutusu);
            this.girisGrupKutusu.Controls.Add(this.adMetinKutusu);
            this.girisGrupKutusu.Controls.Add(this.sfrEtiketi);
            this.girisGrupKutusu.Controls.Add(this.adEtiketi);
            this.girisGrupKutusu.Location = new System.Drawing.Point(518, 364);
            this.girisGrupKutusu.Name = "girisGrupKutusu";
            this.girisGrupKutusu.Size = new System.Drawing.Size(347, 173);
            this.girisGrupKutusu.TabIndex = 1;
            this.girisGrupKutusu.TabStop = false;
            this.girisGrupKutusu.Text = "TTS: Giriş";
            // 
            // kapatDugmesi
            // 
            this.kapatDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kapatDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.kapatDugmesi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kapatDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapatDugmesi.Location = new System.Drawing.Point(115, 104);
            this.kapatDugmesi.Name = "kapatDugmesi";
            this.kapatDugmesi.Size = new System.Drawing.Size(110, 63);
            this.kapatDugmesi.TabIndex = 5;
            this.kapatDugmesi.Text = "KAPAT";
            this.kapatDugmesi.UseVisualStyleBackColor = false;
            this.kapatDugmesi.Click += new System.EventHandler(this.kapatDugmesi_Click);
            // 
            // girisDugmesi
            // 
            this.girisDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.girisDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.girisDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisDugmesi.Location = new System.Drawing.Point(231, 104);
            this.girisDugmesi.Name = "girisDugmesi";
            this.girisDugmesi.Size = new System.Drawing.Size(110, 63);
            this.girisDugmesi.TabIndex = 4;
            this.girisDugmesi.Text = "GİRİŞ";
            this.girisDugmesi.UseVisualStyleBackColor = false;
            this.girisDugmesi.Click += new System.EventHandler(this.girisDugmesi_Click);
            // 
            // sfrMetinKutusu
            // 
            this.sfrMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfrMetinKutusu.Location = new System.Drawing.Point(115, 63);
            this.sfrMetinKutusu.MaxLength = 16;
            this.sfrMetinKutusu.Name = "sfrMetinKutusu";
            this.sfrMetinKutusu.PasswordChar = '*';
            this.sfrMetinKutusu.Size = new System.Drawing.Size(226, 29);
            this.sfrMetinKutusu.TabIndex = 3;
            // 
            // adMetinKutusu
            // 
            this.adMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adMetinKutusu.Location = new System.Drawing.Point(115, 28);
            this.adMetinKutusu.MaxLength = 16;
            this.adMetinKutusu.Name = "adMetinKutusu";
            this.adMetinKutusu.Size = new System.Drawing.Size(226, 29);
            this.adMetinKutusu.TabIndex = 2;
            // 
            // sfrEtiketi
            // 
            this.sfrEtiketi.AutoSize = true;
            this.sfrEtiketi.Location = new System.Drawing.Point(6, 65);
            this.sfrEtiketi.Name = "sfrEtiketi";
            this.sfrEtiketi.Size = new System.Drawing.Size(48, 21);
            this.sfrEtiketi.TabIndex = 1;
            this.sfrEtiketi.Text = "Şifre:";
            // 
            // adEtiketi
            // 
            this.adEtiketi.AutoSize = true;
            this.adEtiketi.Location = new System.Drawing.Point(6, 30);
            this.adEtiketi.Name = "adEtiketi";
            this.adEtiketi.Size = new System.Drawing.Size(103, 21);
            this.adEtiketi.TabIndex = 0;
            this.adEtiketi.Text = "Kullanıcı Adı:";
            // 
            // baslikEtiketi
            // 
            this.baslikEtiketi.AutoSize = true;
            this.baslikEtiketi.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikEtiketi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.baslikEtiketi.Location = new System.Drawing.Point(12, 9);
            this.baslikEtiketi.Name = "baslikEtiketi";
            this.baslikEtiketi.Size = new System.Drawing.Size(607, 65);
            this.baslikEtiketi.TabIndex = 2;
            this.baslikEtiketi.Text = "TTS: Tabiplik Takip Sistemi";
            // 
            // lisansEtiketi
            // 
            this.lisansEtiketi.AutoSize = true;
            this.lisansEtiketi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lisansEtiketi.Location = new System.Drawing.Point(8, 546);
            this.lisansEtiketi.Name = "lisansEtiketi";
            this.lisansEtiketi.Size = new System.Drawing.Size(862, 21);
            this.lisansEtiketi.TabIndex = 3;
            this.lisansEtiketi.Text = "© Bu yazılım Bolu T Tipi Kapalı Ceza İnfaz Kurumu Bilgi İşlem Bürosu tarafından y" +
    "apılmış olup tüm hakları saklıdır. 2021";
            // 
            // cteLogosu
            // 
            this.cteLogosu.Image = global::TTS.Properties.Resources.ctelogoblur;
            this.cteLogosu.Location = new System.Drawing.Point(693, 77);
            this.cteLogosu.Name = "cteLogosu";
            this.cteLogosu.Size = new System.Drawing.Size(172, 211);
            this.cteLogosu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cteLogosu.TabIndex = 5;
            this.cteLogosu.TabStop = false;
            // 
            // abLogosu
            // 
            this.abLogosu.Image = global::TTS.Properties.Resources.ablogoblur;
            this.abLogosu.Location = new System.Drawing.Point(518, 94);
            this.abLogosu.Name = "abLogosu";
            this.abLogosu.Size = new System.Drawing.Size(169, 171);
            this.abLogosu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.abLogosu.TabIndex = 4;
            this.abLogosu.TabStop = false;
            // 
            // girisGorseli
            // 
            this.girisGorseli.Image = global::TTS.Properties.Resources.doktorvehemsire;
            this.girisGorseli.Location = new System.Drawing.Point(12, 77);
            this.girisGorseli.Name = "girisGorseli";
            this.girisGorseli.Size = new System.Drawing.Size(500, 466);
            this.girisGorseli.TabIndex = 0;
            this.girisGorseli.TabStop = false;
            // 
            // GirisFormu
            // 
            this.AcceptButton = this.girisDugmesi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kapatDugmesi;
            this.ClientSize = new System.Drawing.Size(877, 577);
            this.Controls.Add(this.cteLogosu);
            this.Controls.Add(this.abLogosu);
            this.Controls.Add(this.lisansEtiketi);
            this.Controls.Add(this.baslikEtiketi);
            this.Controls.Add(this.girisGrupKutusu);
            this.Controls.Add(this.girisGorseli);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Giriş";
            this.girisGrupKutusu.ResumeLayout(false);
            this.girisGrupKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cteLogosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abLogosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox girisGorseli;
        private System.Windows.Forms.GroupBox girisGrupKutusu;
        private System.Windows.Forms.Label baslikEtiketi;
        private System.Windows.Forms.Label lisansEtiketi;
        private System.Windows.Forms.PictureBox abLogosu;
        private System.Windows.Forms.PictureBox cteLogosu;
        private System.Windows.Forms.Button kapatDugmesi;
        private System.Windows.Forms.Button girisDugmesi;
        private System.Windows.Forms.TextBox sfrMetinKutusu;
        private System.Windows.Forms.TextBox adMetinKutusu;
        private System.Windows.Forms.Label sfrEtiketi;
        private System.Windows.Forms.Label adEtiketi;
    }
}

