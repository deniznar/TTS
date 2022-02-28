namespace TTS
{
    partial class IlacDagitimRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlacDagitimRaporu));
            this.ilacDagitimVeriTablosu = new System.Windows.Forms.DataGridView();
            this.exceleAktarDugmesi = new System.Windows.Forms.Button();
            this.tarihSecici = new System.Windows.Forms.DateTimePicker();
            this.filtreleDugmesi = new System.Windows.Forms.Button();
            this.blokAcilirKutu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ilacDagitimVeriTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // ilacDagitimVeriTablosu
            // 
            this.ilacDagitimVeriTablosu.AllowUserToAddRows = false;
            this.ilacDagitimVeriTablosu.AllowUserToDeleteRows = false;
            this.ilacDagitimVeriTablosu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ilacDagitimVeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilacDagitimVeriTablosu.Location = new System.Drawing.Point(12, 12);
            this.ilacDagitimVeriTablosu.Name = "ilacDagitimVeriTablosu";
            this.ilacDagitimVeriTablosu.ReadOnly = true;
            this.ilacDagitimVeriTablosu.Size = new System.Drawing.Size(1140, 620);
            this.ilacDagitimVeriTablosu.TabIndex = 4;
            // 
            // exceleAktarDugmesi
            // 
            this.exceleAktarDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exceleAktarDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.exceleAktarDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exceleAktarDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exceleAktarDugmesi.Location = new System.Drawing.Point(1039, 638);
            this.exceleAktarDugmesi.Name = "exceleAktarDugmesi";
            this.exceleAktarDugmesi.Size = new System.Drawing.Size(113, 32);
            this.exceleAktarDugmesi.TabIndex = 3;
            this.exceleAktarDugmesi.Text = "Excel\'e Aktar";
            this.exceleAktarDugmesi.UseVisualStyleBackColor = false;
            // 
            // tarihSecici
            // 
            this.tarihSecici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tarihSecici.Location = new System.Drawing.Point(12, 641);
            this.tarihSecici.Name = "tarihSecici";
            this.tarihSecici.Size = new System.Drawing.Size(274, 29);
            this.tarihSecici.TabIndex = 0;
            // 
            // filtreleDugmesi
            // 
            this.filtreleDugmesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtreleDugmesi.BackColor = System.Drawing.Color.DarkGreen;
            this.filtreleDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreleDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filtreleDugmesi.Location = new System.Drawing.Point(566, 638);
            this.filtreleDugmesi.Name = "filtreleDugmesi";
            this.filtreleDugmesi.Size = new System.Drawing.Size(72, 32);
            this.filtreleDugmesi.TabIndex = 2;
            this.filtreleDugmesi.Text = "Filtrele";
            this.filtreleDugmesi.UseVisualStyleBackColor = false;
            // 
            // blokAcilirKutu
            // 
            this.blokAcilirKutu.FormattingEnabled = true;
            this.blokAcilirKutu.Location = new System.Drawing.Point(292, 641);
            this.blokAcilirKutu.Name = "blokAcilirKutu";
            this.blokAcilirKutu.Size = new System.Drawing.Size(268, 29);
            this.blokAcilirKutu.TabIndex = 1;
            // 
            // IlacDagitimRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 682);
            this.Controls.Add(this.blokAcilirKutu);
            this.Controls.Add(this.filtreleDugmesi);
            this.Controls.Add(this.tarihSecici);
            this.Controls.Add(this.exceleAktarDugmesi);
            this.Controls.Add(this.ilacDagitimVeriTablosu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IlacDagitimRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: İlaç Dağıtım Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.ilacDagitimVeriTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ilacDagitimVeriTablosu;
        private System.Windows.Forms.Button exceleAktarDugmesi;
        private System.Windows.Forms.DateTimePicker tarihSecici;
        private System.Windows.Forms.Button filtreleDugmesi;
        private System.Windows.Forms.ComboBox blokAcilirKutu;
    }
}