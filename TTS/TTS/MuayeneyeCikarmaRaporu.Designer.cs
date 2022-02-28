namespace TTS
{
    partial class MuayeneyeCikarmaRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuayeneyeCikarmaRaporu));
            this.muayeneyeCikacaklarVeriTablosu = new System.Windows.Forms.DataGridView();
            this.exceleAktarDugmesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneyeCikacaklarVeriTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // muayeneyeCikacaklarVeriTablosu
            // 
            this.muayeneyeCikacaklarVeriTablosu.AllowUserToAddRows = false;
            this.muayeneyeCikacaklarVeriTablosu.AllowUserToDeleteRows = false;
            this.muayeneyeCikacaklarVeriTablosu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.muayeneyeCikacaklarVeriTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayeneyeCikacaklarVeriTablosu.Location = new System.Drawing.Point(12, 12);
            this.muayeneyeCikacaklarVeriTablosu.Name = "muayeneyeCikacaklarVeriTablosu";
            this.muayeneyeCikacaklarVeriTablosu.ReadOnly = true;
            this.muayeneyeCikacaklarVeriTablosu.Size = new System.Drawing.Size(1140, 620);
            this.muayeneyeCikacaklarVeriTablosu.TabIndex = 1;
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
            this.exceleAktarDugmesi.TabIndex = 0;
            this.exceleAktarDugmesi.Text = "Excel\'e Aktar";
            this.exceleAktarDugmesi.UseVisualStyleBackColor = false;
            // 
            // MuayeneyeCikarmaRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 682);
            this.Controls.Add(this.exceleAktarDugmesi);
            this.Controls.Add(this.muayeneyeCikacaklarVeriTablosu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "MuayeneyeCikarmaRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTS: Muayeneye Çıkarma Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.muayeneyeCikacaklarVeriTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView muayeneyeCikacaklarVeriTablosu;
        private System.Windows.Forms.Button exceleAktarDugmesi;
    }
}