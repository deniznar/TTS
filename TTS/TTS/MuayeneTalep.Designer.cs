namespace TTS
{
    partial class MuayeneTalep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuayeneTalep));
            this.hukumluTutukluSorgulamaGrupKutusu = new System.Windows.Forms.GroupBox();
            this.sorgulaDugmesi = new System.Windows.Forms.Button();
            this.soyadEtiketi = new System.Windows.Forms.Label();
            this.soyadMetinKutusu = new System.Windows.Forms.TextBox();
            this.adMetinKutusu = new System.Windows.Forms.TextBox();
            this.adEtiketi = new System.Windows.Forms.Label();
            this.sorgulamaSonucListesiGrupKutusu = new System.Windows.Forms.GroupBox();
            this.sorgulamaSonucListesiVeriTablosu = new System.Windows.Forms.DataGridView();
            this.muayeneTalepBilgileriGrupKutusu = new System.Windows.Forms.GroupBox();
            this.kaydetDugmesi = new System.Windows.Forms.Button();
            this.talepNotuMetinKutusu = new System.Windows.Forms.TextBox();
            this.talepNotuEtiketi = new System.Windows.Forms.Label();
            this.talepTuruAcilanKutu = new System.Windows.Forms.ComboBox();
            this.talepTuruEtiketi = new System.Windows.Forms.Label();
            this.secilenHukumluTutukluGrupKutusu = new System.Windows.Forms.GroupBox();
            this.secilenKogusMetinKutusu = new System.Windows.Forms.TextBox();
            this.secilenSoyadMetinKutusu = new System.Windows.Forms.TextBox();
            this.secilenAdMetinKutusu = new System.Windows.Forms.TextBox();
            this.secilenTcKimlikNoMetinKutusu = new System.Windows.Forms.TextBox();
            this.secilenCikNoMetinKutusu = new System.Windows.Forms.TextBox();
            this.secilenKogusEtiketi = new System.Windows.Forms.Label();
            this.secilenSoyadEtiketi = new System.Windows.Forms.Label();
            this.secilenAdEtiketi = new System.Windows.Forms.Label();
            this.secilenTcKimlikNoEtiketi = new System.Windows.Forms.Label();
            this.secilenCikNoEtiketi = new System.Windows.Forms.Label();
            this.hukumluTutukluSorgulamaGrupKutusu.SuspendLayout();
            this.sorgulamaSonucListesiGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sorgulamaSonucListesiVeriTablosu)).BeginInit();
            this.muayeneTalepBilgileriGrupKutusu.SuspendLayout();
            this.secilenHukumluTutukluGrupKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // hukumluTutukluSorgulamaGrupKutusu
            // 
            this.hukumluTutukluSorgulamaGrupKutusu.Controls.Add(this.sorgulaDugmesi);
            this.hukumluTutukluSorgulamaGrupKutusu.Controls.Add(this.soyadEtiketi);
            this.hukumluTutukluSorgulamaGrupKutusu.Controls.Add(this.soyadMetinKutusu);
            this.hukumluTutukluSorgulamaGrupKutusu.Controls.Add(this.adMetinKutusu);
            this.hukumluTutukluSorgulamaGrupKutusu.Controls.Add(this.adEtiketi);
            this.hukumluTutukluSorgulamaGrupKutusu.Location = new System.Drawing.Point(12, 12);
            this.hukumluTutukluSorgulamaGrupKutusu.Name = "hukumluTutukluSorgulamaGrupKutusu";
            this.hukumluTutukluSorgulamaGrupKutusu.Size = new System.Drawing.Size(368, 136);
            this.hukumluTutukluSorgulamaGrupKutusu.TabIndex = 5;
            this.hukumluTutukluSorgulamaGrupKutusu.TabStop = false;
            this.hukumluTutukluSorgulamaGrupKutusu.Text = "Hükümlü/Tutuklu Sorgulama";
            // 
            // sorgulaDugmesi
            // 
            this.sorgulaDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sorgulaDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.sorgulaDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorgulaDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sorgulaDugmesi.Location = new System.Drawing.Point(262, 98);
            this.sorgulaDugmesi.Name = "sorgulaDugmesi";
            this.sorgulaDugmesi.Size = new System.Drawing.Size(100, 32);
            this.sorgulaDugmesi.TabIndex = 2;
            this.sorgulaDugmesi.Text = "SORGULA";
            this.sorgulaDugmesi.UseVisualStyleBackColor = false;
            // 
            // soyadEtiketi
            // 
            this.soyadEtiketi.AutoSize = true;
            this.soyadEtiketi.Location = new System.Drawing.Point(6, 66);
            this.soyadEtiketi.Name = "soyadEtiketi";
            this.soyadEtiketi.Size = new System.Drawing.Size(59, 21);
            this.soyadEtiketi.TabIndex = 4;
            this.soyadEtiketi.Text = "Soyad:";
            // 
            // soyadMetinKutusu
            // 
            this.soyadMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soyadMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyadMetinKutusu.Location = new System.Drawing.Point(71, 63);
            this.soyadMetinKutusu.MaxLength = 64;
            this.soyadMetinKutusu.Name = "soyadMetinKutusu";
            this.soyadMetinKutusu.Size = new System.Drawing.Size(291, 29);
            this.soyadMetinKutusu.TabIndex = 1;
            // 
            // adMetinKutusu
            // 
            this.adMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adMetinKutusu.Location = new System.Drawing.Point(71, 28);
            this.adMetinKutusu.MaxLength = 64;
            this.adMetinKutusu.Name = "adMetinKutusu";
            this.adMetinKutusu.Size = new System.Drawing.Size(291, 29);
            this.adMetinKutusu.TabIndex = 0;
            // 
            // adEtiketi
            // 
            this.adEtiketi.AutoSize = true;
            this.adEtiketi.Location = new System.Drawing.Point(6, 31);
            this.adEtiketi.Name = "adEtiketi";
            this.adEtiketi.Size = new System.Drawing.Size(35, 21);
            this.adEtiketi.TabIndex = 3;
            this.adEtiketi.Text = "Ad:";
            // 
            // sorgulamaSonucListesiGrupKutusu
            // 
            this.sorgulamaSonucListesiGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sorgulamaSonucListesiGrupKutusu.Controls.Add(this.sorgulamaSonucListesiVeriTablosu);
            this.sorgulamaSonucListesiGrupKutusu.Location = new System.Drawing.Point(12, 154);
            this.sorgulamaSonucListesiGrupKutusu.Name = "sorgulamaSonucListesiGrupKutusu";
            this.sorgulamaSonucListesiGrupKutusu.Size = new System.Drawing.Size(368, 516);
            this.sorgulamaSonucListesiGrupKutusu.TabIndex = 6;
            this.sorgulamaSonucListesiGrupKutusu.TabStop = false;
            this.sorgulamaSonucListesiGrupKutusu.Text = "Sorgulama Sonuç Listesi";
            // 
            // sorgulamaSonucListesiVeriTablosu
            // 
            this.sorgulamaSonucListesiVeriTablosu.AllowUserToAddRows = false;
            this.sorgulamaSonucListesiVeriTablosu.AllowUserToDeleteRows = false;
            this.sorgulamaSonucListesiVeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorgulamaSonucListesiVeriTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sorgulamaSonucListesiVeriTablosu.Location = new System.Drawing.Point(3, 25);
            this.sorgulamaSonucListesiVeriTablosu.Name = "sorgulamaSonucListesiVeriTablosu";
            this.sorgulamaSonucListesiVeriTablosu.ReadOnly = true;
            this.sorgulamaSonucListesiVeriTablosu.Size = new System.Drawing.Size(362, 488);
            this.sorgulamaSonucListesiVeriTablosu.TabIndex = 7;
            // 
            // muayeneTalepBilgileriGrupKutusu
            // 
            this.muayeneTalepBilgileriGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.muayeneTalepBilgileriGrupKutusu.Controls.Add(this.kaydetDugmesi);
            this.muayeneTalepBilgileriGrupKutusu.Controls.Add(this.talepNotuMetinKutusu);
            this.muayeneTalepBilgileriGrupKutusu.Controls.Add(this.talepNotuEtiketi);
            this.muayeneTalepBilgileriGrupKutusu.Controls.Add(this.talepTuruAcilanKutu);
            this.muayeneTalepBilgileriGrupKutusu.Controls.Add(this.talepTuruEtiketi);
            this.muayeneTalepBilgileriGrupKutusu.Location = new System.Drawing.Point(386, 364);
            this.muayeneTalepBilgileriGrupKutusu.Name = "muayeneTalepBilgileriGrupKutusu";
            this.muayeneTalepBilgileriGrupKutusu.Size = new System.Drawing.Size(463, 306);
            this.muayeneTalepBilgileriGrupKutusu.TabIndex = 13;
            this.muayeneTalepBilgileriGrupKutusu.TabStop = false;
            this.muayeneTalepBilgileriGrupKutusu.Text = "Muayene Talep Bilgileri";
            // 
            // kaydetDugmesi
            // 
            this.kaydetDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.kaydetDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydetDugmesi.Location = new System.Drawing.Point(307, 237);
            this.kaydetDugmesi.Name = "kaydetDugmesi";
            this.kaydetDugmesi.Size = new System.Drawing.Size(150, 63);
            this.kaydetDugmesi.TabIndex = 10;
            this.kaydetDugmesi.Text = "KAYDET";
            this.kaydetDugmesi.UseVisualStyleBackColor = false;
            // 
            // talepNotuMetinKutusu
            // 
            this.talepNotuMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.talepNotuMetinKutusu.Location = new System.Drawing.Point(107, 63);
            this.talepNotuMetinKutusu.MaxLength = 255;
            this.talepNotuMetinKutusu.Multiline = true;
            this.talepNotuMetinKutusu.Name = "talepNotuMetinKutusu";
            this.talepNotuMetinKutusu.Size = new System.Drawing.Size(350, 168);
            this.talepNotuMetinKutusu.TabIndex = 9;
            // 
            // talepNotuEtiketi
            // 
            this.talepNotuEtiketi.AutoSize = true;
            this.talepNotuEtiketi.Location = new System.Drawing.Point(6, 66);
            this.talepNotuEtiketi.Name = "talepNotuEtiketi";
            this.talepNotuEtiketi.Size = new System.Drawing.Size(95, 21);
            this.talepNotuEtiketi.TabIndex = 12;
            this.talepNotuEtiketi.Text = "Talep Notu:";
            // 
            // talepTuruAcilanKutu
            // 
            this.talepTuruAcilanKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.talepTuruAcilanKutu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talepTuruAcilanKutu.FormattingEnabled = true;
            this.talepTuruAcilanKutu.Location = new System.Drawing.Point(107, 28);
            this.talepTuruAcilanKutu.Name = "talepTuruAcilanKutu";
            this.talepTuruAcilanKutu.Size = new System.Drawing.Size(350, 29);
            this.talepTuruAcilanKutu.TabIndex = 8;
            // 
            // talepTuruEtiketi
            // 
            this.talepTuruEtiketi.AutoSize = true;
            this.talepTuruEtiketi.Location = new System.Drawing.Point(6, 31);
            this.talepTuruEtiketi.Name = "talepTuruEtiketi";
            this.talepTuruEtiketi.Size = new System.Drawing.Size(91, 21);
            this.talepTuruEtiketi.TabIndex = 11;
            this.talepTuruEtiketi.Text = "Talep Türü:";
            // 
            // secilenHukumluTutukluGrupKutusu
            // 
            this.secilenHukumluTutukluGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenKogusMetinKutusu);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenSoyadMetinKutusu);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenAdMetinKutusu);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenTcKimlikNoMetinKutusu);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenCikNoMetinKutusu);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenKogusEtiketi);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenSoyadEtiketi);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenAdEtiketi);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenTcKimlikNoEtiketi);
            this.secilenHukumluTutukluGrupKutusu.Controls.Add(this.secilenCikNoEtiketi);
            this.secilenHukumluTutukluGrupKutusu.Location = new System.Drawing.Point(386, 154);
            this.secilenHukumluTutukluGrupKutusu.Name = "secilenHukumluTutukluGrupKutusu";
            this.secilenHukumluTutukluGrupKutusu.Size = new System.Drawing.Size(463, 204);
            this.secilenHukumluTutukluGrupKutusu.TabIndex = 14;
            this.secilenHukumluTutukluGrupKutusu.TabStop = false;
            this.secilenHukumluTutukluGrupKutusu.Text = "Seçilen Hükümlü/Tutuklu";
            // 
            // secilenKogusMetinKutusu
            // 
            this.secilenKogusMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenKogusMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenKogusMetinKutusu.Location = new System.Drawing.Point(127, 168);
            this.secilenKogusMetinKutusu.Name = "secilenKogusMetinKutusu";
            this.secilenKogusMetinKutusu.ReadOnly = true;
            this.secilenKogusMetinKutusu.Size = new System.Drawing.Size(330, 29);
            this.secilenKogusMetinKutusu.TabIndex = 24;
            // 
            // secilenSoyadMetinKutusu
            // 
            this.secilenSoyadMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenSoyadMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenSoyadMetinKutusu.Location = new System.Drawing.Point(127, 133);
            this.secilenSoyadMetinKutusu.Name = "secilenSoyadMetinKutusu";
            this.secilenSoyadMetinKutusu.ReadOnly = true;
            this.secilenSoyadMetinKutusu.Size = new System.Drawing.Size(330, 29);
            this.secilenSoyadMetinKutusu.TabIndex = 23;
            // 
            // secilenAdMetinKutusu
            // 
            this.secilenAdMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenAdMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenAdMetinKutusu.Location = new System.Drawing.Point(127, 98);
            this.secilenAdMetinKutusu.Name = "secilenAdMetinKutusu";
            this.secilenAdMetinKutusu.ReadOnly = true;
            this.secilenAdMetinKutusu.Size = new System.Drawing.Size(330, 29);
            this.secilenAdMetinKutusu.TabIndex = 22;
            // 
            // secilenTcKimlikNoMetinKutusu
            // 
            this.secilenTcKimlikNoMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenTcKimlikNoMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenTcKimlikNoMetinKutusu.Location = new System.Drawing.Point(127, 63);
            this.secilenTcKimlikNoMetinKutusu.Name = "secilenTcKimlikNoMetinKutusu";
            this.secilenTcKimlikNoMetinKutusu.ReadOnly = true;
            this.secilenTcKimlikNoMetinKutusu.Size = new System.Drawing.Size(330, 29);
            this.secilenTcKimlikNoMetinKutusu.TabIndex = 21;
            // 
            // secilenCikNoMetinKutusu
            // 
            this.secilenCikNoMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secilenCikNoMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenCikNoMetinKutusu.Location = new System.Drawing.Point(127, 28);
            this.secilenCikNoMetinKutusu.Name = "secilenCikNoMetinKutusu";
            this.secilenCikNoMetinKutusu.ReadOnly = true;
            this.secilenCikNoMetinKutusu.Size = new System.Drawing.Size(330, 29);
            this.secilenCikNoMetinKutusu.TabIndex = 20;
            // 
            // secilenKogusEtiketi
            // 
            this.secilenKogusEtiketi.AutoSize = true;
            this.secilenKogusEtiketi.Location = new System.Drawing.Point(6, 171);
            this.secilenKogusEtiketi.Name = "secilenKogusEtiketi";
            this.secilenKogusEtiketi.Size = new System.Drawing.Size(60, 21);
            this.secilenKogusEtiketi.TabIndex = 19;
            this.secilenKogusEtiketi.Text = "Koğuş:";
            // 
            // secilenSoyadEtiketi
            // 
            this.secilenSoyadEtiketi.AutoSize = true;
            this.secilenSoyadEtiketi.Location = new System.Drawing.Point(6, 136);
            this.secilenSoyadEtiketi.Name = "secilenSoyadEtiketi";
            this.secilenSoyadEtiketi.Size = new System.Drawing.Size(59, 21);
            this.secilenSoyadEtiketi.TabIndex = 18;
            this.secilenSoyadEtiketi.Text = "Soyad:";
            // 
            // secilenAdEtiketi
            // 
            this.secilenAdEtiketi.AutoSize = true;
            this.secilenAdEtiketi.Location = new System.Drawing.Point(6, 101);
            this.secilenAdEtiketi.Name = "secilenAdEtiketi";
            this.secilenAdEtiketi.Size = new System.Drawing.Size(35, 21);
            this.secilenAdEtiketi.TabIndex = 17;
            this.secilenAdEtiketi.Text = "Ad:";
            // 
            // secilenTcKimlikNoEtiketi
            // 
            this.secilenTcKimlikNoEtiketi.AutoSize = true;
            this.secilenTcKimlikNoEtiketi.Location = new System.Drawing.Point(6, 66);
            this.secilenTcKimlikNoEtiketi.Name = "secilenTcKimlikNoEtiketi";
            this.secilenTcKimlikNoEtiketi.Size = new System.Drawing.Size(115, 21);
            this.secilenTcKimlikNoEtiketi.TabIndex = 16;
            this.secilenTcKimlikNoEtiketi.Text = "T.C. Kimlik No:";
            // 
            // secilenCikNoEtiketi
            // 
            this.secilenCikNoEtiketi.AutoSize = true;
            this.secilenCikNoEtiketi.Location = new System.Drawing.Point(6, 31);
            this.secilenCikNoEtiketi.Name = "secilenCikNoEtiketi";
            this.secilenCikNoEtiketi.Size = new System.Drawing.Size(65, 21);
            this.secilenCikNoEtiketi.TabIndex = 15;
            this.secilenCikNoEtiketi.Text = "CİK No:";
            // 
            // MuayeneTalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 682);
            this.Controls.Add(this.secilenHukumluTutukluGrupKutusu);
            this.Controls.Add(this.muayeneTalepBilgileriGrupKutusu);
            this.Controls.Add(this.sorgulamaSonucListesiGrupKutusu);
            this.Controls.Add(this.hukumluTutukluSorgulamaGrupKutusu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "MuayeneTalep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Muayene Talep";
            this.hukumluTutukluSorgulamaGrupKutusu.ResumeLayout(false);
            this.hukumluTutukluSorgulamaGrupKutusu.PerformLayout();
            this.sorgulamaSonucListesiGrupKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sorgulamaSonucListesiVeriTablosu)).EndInit();
            this.muayeneTalepBilgileriGrupKutusu.ResumeLayout(false);
            this.muayeneTalepBilgileriGrupKutusu.PerformLayout();
            this.secilenHukumluTutukluGrupKutusu.ResumeLayout(false);
            this.secilenHukumluTutukluGrupKutusu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox hukumluTutukluSorgulamaGrupKutusu;
        private System.Windows.Forms.Button sorgulaDugmesi;
        private System.Windows.Forms.Label soyadEtiketi;
        private System.Windows.Forms.TextBox soyadMetinKutusu;
        private System.Windows.Forms.TextBox adMetinKutusu;
        private System.Windows.Forms.Label adEtiketi;
        private System.Windows.Forms.GroupBox sorgulamaSonucListesiGrupKutusu;
        private System.Windows.Forms.DataGridView sorgulamaSonucListesiVeriTablosu;
        private System.Windows.Forms.GroupBox muayeneTalepBilgileriGrupKutusu;
        private System.Windows.Forms.GroupBox secilenHukumluTutukluGrupKutusu;
        private System.Windows.Forms.TextBox secilenKogusMetinKutusu;
        private System.Windows.Forms.TextBox secilenSoyadMetinKutusu;
        private System.Windows.Forms.TextBox secilenAdMetinKutusu;
        private System.Windows.Forms.TextBox secilenTcKimlikNoMetinKutusu;
        private System.Windows.Forms.TextBox secilenCikNoMetinKutusu;
        private System.Windows.Forms.Label secilenKogusEtiketi;
        private System.Windows.Forms.Label secilenSoyadEtiketi;
        private System.Windows.Forms.Label secilenAdEtiketi;
        private System.Windows.Forms.Label secilenTcKimlikNoEtiketi;
        private System.Windows.Forms.Label secilenCikNoEtiketi;
        private System.Windows.Forms.Button kaydetDugmesi;
        private System.Windows.Forms.TextBox talepNotuMetinKutusu;
        private System.Windows.Forms.Label talepNotuEtiketi;
        private System.Windows.Forms.ComboBox talepTuruAcilanKutu;
        private System.Windows.Forms.Label talepTuruEtiketi;
    }
}