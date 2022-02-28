namespace TTS
{
    partial class UnvanTanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnvanTanimlama));
            this.mevcutUnvanlarGrupKutusu = new System.Windows.Forms.GroupBox();
            this.mevcutUnvanlarVeriTablosu = new System.Windows.Forms.DataGridView();
            this.unvanTanimlaGrupKutusu = new System.Windows.Forms.GroupBox();
            this.unvanMetinKutusu = new System.Windows.Forms.TextBox();
            this.unvanEtiketi = new System.Windows.Forms.Label();
            this.kaydetDugmesi = new System.Windows.Forms.Button();
            this.mevcutUnvanlarGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mevcutUnvanlarVeriTablosu)).BeginInit();
            this.unvanTanimlaGrupKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mevcutUnvanlarGrupKutusu
            // 
            this.mevcutUnvanlarGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mevcutUnvanlarGrupKutusu.Controls.Add(this.mevcutUnvanlarVeriTablosu);
            this.mevcutUnvanlarGrupKutusu.Location = new System.Drawing.Point(12, 12);
            this.mevcutUnvanlarGrupKutusu.Name = "mevcutUnvanlarGrupKutusu";
            this.mevcutUnvanlarGrupKutusu.Size = new System.Drawing.Size(347, 399);
            this.mevcutUnvanlarGrupKutusu.TabIndex = 4;
            this.mevcutUnvanlarGrupKutusu.TabStop = false;
            this.mevcutUnvanlarGrupKutusu.Text = "Mevcut Unvanlar";
            // 
            // mevcutUnvanlarVeriTablosu
            // 
            this.mevcutUnvanlarVeriTablosu.AllowUserToAddRows = false;
            this.mevcutUnvanlarVeriTablosu.AllowUserToDeleteRows = false;
            this.mevcutUnvanlarVeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mevcutUnvanlarVeriTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mevcutUnvanlarVeriTablosu.Location = new System.Drawing.Point(3, 25);
            this.mevcutUnvanlarVeriTablosu.Name = "mevcutUnvanlarVeriTablosu";
            this.mevcutUnvanlarVeriTablosu.ReadOnly = true;
            this.mevcutUnvanlarVeriTablosu.Size = new System.Drawing.Size(341, 371);
            this.mevcutUnvanlarVeriTablosu.TabIndex = 5;
            // 
            // unvanTanimlaGrupKutusu
            // 
            this.unvanTanimlaGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unvanTanimlaGrupKutusu.Controls.Add(this.unvanMetinKutusu);
            this.unvanTanimlaGrupKutusu.Controls.Add(this.unvanEtiketi);
            this.unvanTanimlaGrupKutusu.Controls.Add(this.kaydetDugmesi);
            this.unvanTanimlaGrupKutusu.Location = new System.Drawing.Point(365, 12);
            this.unvanTanimlaGrupKutusu.Name = "unvanTanimlaGrupKutusu";
            this.unvanTanimlaGrupKutusu.Size = new System.Drawing.Size(396, 399);
            this.unvanTanimlaGrupKutusu.TabIndex = 3;
            this.unvanTanimlaGrupKutusu.TabStop = false;
            this.unvanTanimlaGrupKutusu.Text = "Unvan Tanımla";
            // 
            // unvanMetinKutusu
            // 
            this.unvanMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unvanMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unvanMetinKutusu.Location = new System.Drawing.Point(71, 28);
            this.unvanMetinKutusu.MaxLength = 64;
            this.unvanMetinKutusu.Name = "unvanMetinKutusu";
            this.unvanMetinKutusu.Size = new System.Drawing.Size(319, 29);
            this.unvanMetinKutusu.TabIndex = 0;
            // 
            // unvanEtiketi
            // 
            this.unvanEtiketi.AutoSize = true;
            this.unvanEtiketi.Location = new System.Drawing.Point(6, 31);
            this.unvanEtiketi.Name = "unvanEtiketi";
            this.unvanEtiketi.Size = new System.Drawing.Size(59, 21);
            this.unvanEtiketi.TabIndex = 2;
            this.unvanEtiketi.Text = "Unvan:";
            // 
            // kaydetDugmesi
            // 
            this.kaydetDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.kaydetDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetDugmesi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydetDugmesi.Location = new System.Drawing.Point(270, 330);
            this.kaydetDugmesi.Name = "kaydetDugmesi";
            this.kaydetDugmesi.Size = new System.Drawing.Size(120, 63);
            this.kaydetDugmesi.TabIndex = 1;
            this.kaydetDugmesi.Text = "KAYDET";
            this.kaydetDugmesi.UseVisualStyleBackColor = false;
            // 
            // UnvanTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 423);
            this.Controls.Add(this.unvanTanimlaGrupKutusu);
            this.Controls.Add(this.mevcutUnvanlarGrupKutusu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnvanTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Unvan Tanımlama";
            this.mevcutUnvanlarGrupKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mevcutUnvanlarVeriTablosu)).EndInit();
            this.unvanTanimlaGrupKutusu.ResumeLayout(false);
            this.unvanTanimlaGrupKutusu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mevcutUnvanlarGrupKutusu;
        private System.Windows.Forms.DataGridView mevcutUnvanlarVeriTablosu;
        private System.Windows.Forms.GroupBox unvanTanimlaGrupKutusu;
        private System.Windows.Forms.TextBox unvanMetinKutusu;
        private System.Windows.Forms.Label unvanEtiketi;
        private System.Windows.Forms.Button kaydetDugmesi;
    }
}