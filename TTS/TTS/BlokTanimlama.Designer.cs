namespace TTS
{
    partial class BlokTanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlokTanimlama));
            this.tanimliBloklarGrupKutusu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blokTanimlamaGrupKutusu = new System.Windows.Forms.GroupBox();
            this.blokAdiMetinKutusu = new System.Windows.Forms.TextBox();
            this.blokAdiEtiketi = new System.Windows.Forms.Label();
            this.kaydetDugmesi = new System.Windows.Forms.Button();
            this.tanimliBloklarGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.blokTanimlamaGrupKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tanimliBloklarGrupKutusu
            // 
            this.tanimliBloklarGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tanimliBloklarGrupKutusu.Controls.Add(this.dataGridView1);
            this.tanimliBloklarGrupKutusu.Location = new System.Drawing.Point(12, 12);
            this.tanimliBloklarGrupKutusu.Name = "tanimliBloklarGrupKutusu";
            this.tanimliBloklarGrupKutusu.Size = new System.Drawing.Size(310, 488);
            this.tanimliBloklarGrupKutusu.TabIndex = 4;
            this.tanimliBloklarGrupKutusu.TabStop = false;
            this.tanimliBloklarGrupKutusu.Text = "Tanımlı Bloklar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // blokTanimlamaGrupKutusu
            // 
            this.blokTanimlamaGrupKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blokTanimlamaGrupKutusu.Controls.Add(this.blokAdiMetinKutusu);
            this.blokTanimlamaGrupKutusu.Controls.Add(this.blokAdiEtiketi);
            this.blokTanimlamaGrupKutusu.Controls.Add(this.kaydetDugmesi);
            this.blokTanimlamaGrupKutusu.Location = new System.Drawing.Point(328, 12);
            this.blokTanimlamaGrupKutusu.Name = "blokTanimlamaGrupKutusu";
            this.blokTanimlamaGrupKutusu.Size = new System.Drawing.Size(476, 488);
            this.blokTanimlamaGrupKutusu.TabIndex = 1;
            this.blokTanimlamaGrupKutusu.TabStop = false;
            this.blokTanimlamaGrupKutusu.Text = "Blok Tanımlama";
            // 
            // blokAdiMetinKutusu
            // 
            this.blokAdiMetinKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blokAdiMetinKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blokAdiMetinKutusu.Location = new System.Drawing.Point(87, 28);
            this.blokAdiMetinKutusu.MaxLength = 255;
            this.blokAdiMetinKutusu.Name = "blokAdiMetinKutusu";
            this.blokAdiMetinKutusu.Size = new System.Drawing.Size(383, 29);
            this.blokAdiMetinKutusu.TabIndex = 0;
            this.blokAdiMetinKutusu.Tag = "";
            // 
            // blokAdiEtiketi
            // 
            this.blokAdiEtiketi.AutoSize = true;
            this.blokAdiEtiketi.Location = new System.Drawing.Point(6, 31);
            this.blokAdiEtiketi.Name = "blokAdiEtiketi";
            this.blokAdiEtiketi.Size = new System.Drawing.Size(75, 21);
            this.blokAdiEtiketi.TabIndex = 2;
            this.blokAdiEtiketi.Text = "Blok Adı:";
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
            this.kaydetDugmesi.TabIndex = 1;
            this.kaydetDugmesi.Text = "KAYDET";
            this.kaydetDugmesi.UseVisualStyleBackColor = false;
            // 
            // BlokTanimlama
            // 
            this.AcceptButton = this.kaydetDugmesi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 512);
            this.Controls.Add(this.blokTanimlamaGrupKutusu);
            this.Controls.Add(this.tanimliBloklarGrupKutusu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "BlokTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Blok Tanımlama";
            this.tanimliBloklarGrupKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.blokTanimlamaGrupKutusu.ResumeLayout(false);
            this.blokTanimlamaGrupKutusu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tanimliBloklarGrupKutusu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox blokTanimlamaGrupKutusu;
        private System.Windows.Forms.Button kaydetDugmesi;
        private System.Windows.Forms.Label blokAdiEtiketi;
        private System.Windows.Forms.TextBox blokAdiMetinKutusu;
    }
}