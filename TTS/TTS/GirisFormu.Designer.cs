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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baslikEtiketi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisGorseli = new System.Windows.Forms.PictureBox();
            this.girisGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).BeginInit();
            this.SuspendLayout();
            // 
            // girisGrupKutusu
            // 
            this.girisGrupKutusu.Controls.Add(this.kapatDugmesi);
            this.girisGrupKutusu.Controls.Add(this.girisDugmesi);
            this.girisGrupKutusu.Controls.Add(this.textBox2);
            this.girisGrupKutusu.Controls.Add(this.textBox1);
            this.girisGrupKutusu.Controls.Add(this.label3);
            this.girisGrupKutusu.Controls.Add(this.label2);
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
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(115, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(226, 29);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(115, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(8, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "© Bu yazılım Bolu T Tipi Kapalı Ceza İnfaz Kurumu Bilgi İşlem Bürosu tarafından y" +
    "apılmış olup tüm hakları saklıdır. 2021";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TTS.Properties.Resources.ctelogoblur;
            this.pictureBox2.Location = new System.Drawing.Point(693, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 211);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTS.Properties.Resources.ablogoblur;
            this.pictureBox1.Location = new System.Drawing.Point(518, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox girisGorseli;
        private System.Windows.Forms.GroupBox girisGrupKutusu;
        private System.Windows.Forms.Label baslikEtiketi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button kapatDugmesi;
        private System.Windows.Forms.Button girisDugmesi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

