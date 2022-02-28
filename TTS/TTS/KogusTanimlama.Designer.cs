namespace TTS
{
    partial class KogusTanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KogusTanimlama));
            this.tanimliKoguslarGrupKutusu = new System.Windows.Forms.GroupBox();
            this.tanimliKoguslarVeriTablosu = new System.Windows.Forms.DataGridView();
            this.kogusTanimlamaGrupKutusu = new System.Windows.Forms.GroupBox();
            this.kogusAdiMetinKutusu = new System.Windows.Forms.TextBox();
            this.kogusAdiEtiketi = new System.Windows.Forms.Label();
            this.blokAcilirKutu = new System.Windows.Forms.ComboBox();
            this.blokEtiketi = new System.Windows.Forms.Label();
            this.kaydetDugmesi = new System.Windows.Forms.Button();
            this.tanimliKoguslarGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanimliKoguslarVeriTablosu)).BeginInit();
            this.kogusTanimlamaGrupKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tanimliKoguslarGrupKutusu
            // 
            this.tanimliKoguslarGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tanimliKoguslarGrupKutusu.Controls.Add(this.tanimliKoguslarVeriTablosu);
            this.tanimliKoguslarGrupKutusu.Location = new System.Drawing.Point(12, 12);
            this.tanimliKoguslarGrupKutusu.Name = "tanimliKoguslarGrupKutusu";
            this.tanimliKoguslarGrupKutusu.Size = new System.Drawing.Size(310, 488);
            this.tanimliKoguslarGrupKutusu.TabIndex = 0;
            this.tanimliKoguslarGrupKutusu.TabStop = false;
            this.tanimliKoguslarGrupKutusu.Text = "Tanımlı Koğuşlar";
            // 
            // tanimliKoguslarVeriTablosu
            // 
            this.tanimliKoguslarVeriTablosu.AllowUserToAddRows = false;
            this.tanimliKoguslarVeriTablosu.AllowUserToDeleteRows = false;
            this.tanimliKoguslarVeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tanimliKoguslarVeriTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanimliKoguslarVeriTablosu.Location = new System.Drawing.Point(3, 25);
            this.tanimliKoguslarVeriTablosu.Name = "tanimliKoguslarVeriTablosu";
            this.tanimliKoguslarVeriTablosu.ReadOnly = true;
            this.tanimliKoguslarVeriTablosu.Size = new System.Drawing.Size(304, 460);
            this.tanimliKoguslarVeriTablosu.TabIndex = 0;
            // 
            // kogusTanimlamaGrupKutusu
            // 
            this.kogusTanimlamaGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kogusTanimlamaGrupKutusu.Controls.Add(this.kogusAdiMetinKutusu);
            this.kogusTanimlamaGrupKutusu.Controls.Add(this.kogusAdiEtiketi);
            this.kogusTanimlamaGrupKutusu.Controls.Add(this.blokAcilirKutu);
            this.kogusTanimlamaGrupKutusu.Controls.Add(this.blokEtiketi);
            this.kogusTanimlamaGrupKutusu.Controls.Add(this.kaydetDugmesi);
            this.kogusTanimlamaGrupKutusu.Location = new System.Drawing.Point(328, 12);
            this.kogusTanimlamaGrupKutusu.Name = "kogusTanimlamaGrupKutusu";
            this.kogusTanimlamaGrupKutusu.Size = new System.Drawing.Size(476, 488);
            this.kogusTanimlamaGrupKutusu.TabIndex = 1;
            this.kogusTanimlamaGrupKutusu.TabStop = false;
            this.kogusTanimlamaGrupKutusu.Text = "Koğuş Tanımlama";
            // 
            // kogusAdiMetinKutusu
            // 
            this.kogusAdiMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kogusAdiMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kogusAdiMetinKutusu.Location = new System.Drawing.Point(101, 60);
            this.kogusAdiMetinKutusu.MaxLength = 255;
            this.kogusAdiMetinKutusu.Name = "kogusAdiMetinKutusu";
            this.kogusAdiMetinKutusu.Size = new System.Drawing.Size(369, 29);
            this.kogusAdiMetinKutusu.TabIndex = 9;
            // 
            // kogusAdiEtiketi
            // 
            this.kogusAdiEtiketi.AutoSize = true;
            this.kogusAdiEtiketi.Location = new System.Drawing.Point(6, 63);
            this.kogusAdiEtiketi.Name = "kogusAdiEtiketi";
            this.kogusAdiEtiketi.Size = new System.Drawing.Size(89, 21);
            this.kogusAdiEtiketi.TabIndex = 8;
            this.kogusAdiEtiketi.Text = "Koğuş Adı:";
            // 
            // blokAcilirKutu
            // 
            this.blokAcilirKutu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blokAcilirKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blokAcilirKutu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blokAcilirKutu.FormattingEnabled = true;
            this.blokAcilirKutu.Location = new System.Drawing.Point(101, 25);
            this.blokAcilirKutu.Name = "blokAcilirKutu";
            this.blokAcilirKutu.Size = new System.Drawing.Size(369, 29);
            this.blokAcilirKutu.TabIndex = 7;
            // 
            // blokEtiketi
            // 
            this.blokEtiketi.AutoSize = true;
            this.blokEtiketi.Location = new System.Drawing.Point(6, 28);
            this.blokEtiketi.Name = "blokEtiketi";
            this.blokEtiketi.Size = new System.Drawing.Size(46, 21);
            this.blokEtiketi.TabIndex = 6;
            this.blokEtiketi.Text = "Blok:";
            // 
            // kaydetDugmesi
            // 
            this.kaydetDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.kaydetDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydetDugmesi.Location = new System.Drawing.Point(350, 419);
            this.kaydetDugmesi.Name = "kaydetDugmesi";
            this.kaydetDugmesi.Size = new System.Drawing.Size(120, 63);
            this.kaydetDugmesi.TabIndex = 4;
            this.kaydetDugmesi.Text = "KAYDET";
            this.kaydetDugmesi.UseVisualStyleBackColor = false;
            // 
            // KogusTanimlama
            // 
            this.AcceptButton = this.kaydetDugmesi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 512);
            this.Controls.Add(this.kogusTanimlamaGrupKutusu);
            this.Controls.Add(this.tanimliKoguslarGrupKutusu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "KogusTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Koğuş Tanımlama";
            this.tanimliKoguslarGrupKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tanimliKoguslarVeriTablosu)).EndInit();
            this.kogusTanimlamaGrupKutusu.ResumeLayout(false);
            this.kogusTanimlamaGrupKutusu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tanimliKoguslarGrupKutusu;
        private System.Windows.Forms.GroupBox kogusTanimlamaGrupKutusu;
        private System.Windows.Forms.Button kaydetDugmesi;
        private System.Windows.Forms.DataGridView tanimliKoguslarVeriTablosu;
        private System.Windows.Forms.ComboBox blokAcilirKutu;
        private System.Windows.Forms.Label blokEtiketi;
        private System.Windows.Forms.TextBox kogusAdiMetinKutusu;
        private System.Windows.Forms.Label kogusAdiEtiketi;
    }
}