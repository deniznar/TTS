namespace TTS
{
    partial class Degistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Degistirme));
            this.girisGorseli = new System.Windows.Forms.PictureBox();
            this.baslikEtiketi = new System.Windows.Forms.Label();
            this.degistemeGrupKutusu = new System.Windows.Forms.GroupBox();
            this.sfrEtiketi = new System.Windows.Forms.Label();
            this.sfrMetinKutusu = new System.Windows.Forms.TextBox();
            this.ynsfrEtiketi = new System.Windows.Forms.Label();
            this.ynsfrMetinKutusu = new System.Windows.Forms.TextBox();
            this.ynsfrtEtiketi = new System.Windows.Forms.Label();
            this.ynsfrtMetinKutusu = new System.Windows.Forms.TextBox();
            this.onaylaDugmesi = new System.Windows.Forms.Button();
            this.kapatDugmesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).BeginInit();
            this.degistemeGrupKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisGorseli
            // 
            this.girisGorseli.Image = global::TTS.Properties.Resources.doktorvehemsire;
            this.girisGorseli.Location = new System.Drawing.Point(13, 59);
            this.girisGorseli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.girisGorseli.Name = "girisGorseli";
            this.girisGorseli.Size = new System.Drawing.Size(250, 222);
            this.girisGorseli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.girisGorseli.TabIndex = 0;
            this.girisGorseli.TabStop = false;
            // 
            // baslikEtiketi
            // 
            this.baslikEtiketi.AutoSize = true;
            this.baslikEtiketi.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikEtiketi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.baslikEtiketi.Location = new System.Drawing.Point(13, 9);
            this.baslikEtiketi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslikEtiketi.Name = "baslikEtiketi";
            this.baslikEtiketi.Size = new System.Drawing.Size(322, 45);
            this.baslikEtiketi.TabIndex = 1;
            this.baslikEtiketi.Text = "TTS: Şifre Değiştirme";
            // 
            // degistemeGrupKutusu
            // 
            this.degistemeGrupKutusu.Controls.Add(this.kapatDugmesi);
            this.degistemeGrupKutusu.Controls.Add(this.onaylaDugmesi);
            this.degistemeGrupKutusu.Controls.Add(this.ynsfrtMetinKutusu);
            this.degistemeGrupKutusu.Controls.Add(this.ynsfrtEtiketi);
            this.degistemeGrupKutusu.Controls.Add(this.ynsfrMetinKutusu);
            this.degistemeGrupKutusu.Controls.Add(this.ynsfrEtiketi);
            this.degistemeGrupKutusu.Controls.Add(this.sfrMetinKutusu);
            this.degistemeGrupKutusu.Controls.Add(this.sfrEtiketi);
            this.degistemeGrupKutusu.Location = new System.Drawing.Point(270, 59);
            this.degistemeGrupKutusu.Name = "degistemeGrupKutusu";
            this.degistemeGrupKutusu.Size = new System.Drawing.Size(356, 222);
            this.degistemeGrupKutusu.TabIndex = 2;
            this.degistemeGrupKutusu.TabStop = false;
            this.degistemeGrupKutusu.Text = "Şifre Değiştirme";
            // 
            // sfrEtiketi
            // 
            this.sfrEtiketi.AutoSize = true;
            this.sfrEtiketi.Location = new System.Drawing.Point(6, 31);
            this.sfrEtiketi.Name = "sfrEtiketi";
            this.sfrEtiketi.Size = new System.Drawing.Size(107, 21);
            this.sfrEtiketi.TabIndex = 0;
            this.sfrEtiketi.Text = "Mevcut Şifre:";
            // 
            // sfrMetinKutusu
            // 
            this.sfrMetinKutusu.Location = new System.Drawing.Point(155, 28);
            this.sfrMetinKutusu.Name = "sfrMetinKutusu";
            this.sfrMetinKutusu.Size = new System.Drawing.Size(195, 29);
            this.sfrMetinKutusu.TabIndex = 1;
            // 
            // ynsfrEtiketi
            // 
            this.ynsfrEtiketi.AutoSize = true;
            this.ynsfrEtiketi.Location = new System.Drawing.Point(6, 66);
            this.ynsfrEtiketi.Name = "ynsfrEtiketi";
            this.ynsfrEtiketi.Size = new System.Drawing.Size(83, 21);
            this.ynsfrEtiketi.TabIndex = 2;
            this.ynsfrEtiketi.Text = "Yeni Şifre:";
            // 
            // ynsfrMetinKutusu
            // 
            this.ynsfrMetinKutusu.Location = new System.Drawing.Point(155, 63);
            this.ynsfrMetinKutusu.Name = "ynsfrMetinKutusu";
            this.ynsfrMetinKutusu.Size = new System.Drawing.Size(195, 29);
            this.ynsfrMetinKutusu.TabIndex = 3;
            // 
            // ynsfrtEtiketi
            // 
            this.ynsfrtEtiketi.AutoSize = true;
            this.ynsfrtEtiketi.Location = new System.Drawing.Point(6, 101);
            this.ynsfrtEtiketi.Name = "ynsfrtEtiketi";
            this.ynsfrtEtiketi.Size = new System.Drawing.Size(143, 21);
            this.ynsfrtEtiketi.TabIndex = 4;
            this.ynsfrtEtiketi.Text = "Yeni Şifre (Tekrar):";
            // 
            // ynsfrtMetinKutusu
            // 
            this.ynsfrtMetinKutusu.Location = new System.Drawing.Point(155, 98);
            this.ynsfrtMetinKutusu.Name = "ynsfrtMetinKutusu";
            this.ynsfrtMetinKutusu.Size = new System.Drawing.Size(195, 29);
            this.ynsfrtMetinKutusu.TabIndex = 5;
            // 
            // onaylaDugmesi
            // 
            this.onaylaDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onaylaDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.onaylaDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onaylaDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onaylaDugmesi.Location = new System.Drawing.Point(230, 153);
            this.onaylaDugmesi.Name = "onaylaDugmesi";
            this.onaylaDugmesi.Size = new System.Drawing.Size(120, 63);
            this.onaylaDugmesi.TabIndex = 6;
            this.onaylaDugmesi.Text = "ONAYLA";
            this.onaylaDugmesi.UseVisualStyleBackColor = false;
            // 
            // kapatDugmesi
            // 
            this.kapatDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kapatDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.kapatDugmesi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kapatDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapatDugmesi.Location = new System.Drawing.Point(104, 153);
            this.kapatDugmesi.Name = "kapatDugmesi";
            this.kapatDugmesi.Size = new System.Drawing.Size(120, 63);
            this.kapatDugmesi.TabIndex = 7;
            this.kapatDugmesi.Text = "KAPAT";
            this.kapatDugmesi.UseVisualStyleBackColor = false;
            // 
            // Degistirme
            // 
            this.AcceptButton = this.onaylaDugmesi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kapatDugmesi;
            this.ClientSize = new System.Drawing.Size(638, 295);
            this.Controls.Add(this.degistemeGrupKutusu);
            this.Controls.Add(this.baslikEtiketi);
            this.Controls.Add(this.girisGorseli);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Degistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Şifre Değiştirme";
            ((System.ComponentModel.ISupportInitialize)(this.girisGorseli)).EndInit();
            this.degistemeGrupKutusu.ResumeLayout(false);
            this.degistemeGrupKutusu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox girisGorseli;
        private System.Windows.Forms.Label baslikEtiketi;
        private System.Windows.Forms.GroupBox degistemeGrupKutusu;
        private System.Windows.Forms.TextBox ynsfrtMetinKutusu;
        private System.Windows.Forms.Label ynsfrtEtiketi;
        private System.Windows.Forms.TextBox ynsfrMetinKutusu;
        private System.Windows.Forms.Label ynsfrEtiketi;
        private System.Windows.Forms.TextBox sfrMetinKutusu;
        private System.Windows.Forms.Label sfrEtiketi;
        private System.Windows.Forms.Button onaylaDugmesi;
        private System.Windows.Forms.Button kapatDugmesi;
    }
}