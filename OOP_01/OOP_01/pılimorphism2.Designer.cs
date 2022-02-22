
namespace OOP_01
{
    partial class pılimorphism2
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
            this.btntekstil = new System.Windows.Forms.Button();
            this.btncep = new System.Windows.Forms.Button();
            this.btnekmek = new System.Windows.Forms.Button();
            this.dgvsepet = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVliFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).BeginInit();
            this.SuspendLayout();
            // 
            // btntekstil
            // 
            this.btntekstil.Location = new System.Drawing.Point(22, 35);
            this.btntekstil.Name = "btntekstil";
            this.btntekstil.Size = new System.Drawing.Size(75, 23);
            this.btntekstil.TabIndex = 0;
            this.btntekstil.Text = "TEKSTİL";
            this.btntekstil.UseVisualStyleBackColor = true;
            this.btntekstil.Click += new System.EventHandler(this.btntekstil_Click);
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(22, 64);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(75, 23);
            this.btncep.TabIndex = 0;
            this.btncep.Text = "CEP";
            this.btncep.UseVisualStyleBackColor = true;
            this.btncep.Click += new System.EventHandler(this.btncep_Click);
            // 
            // btnekmek
            // 
            this.btnekmek.Location = new System.Drawing.Point(22, 93);
            this.btnekmek.Name = "btnekmek";
            this.btnekmek.Size = new System.Drawing.Size(75, 23);
            this.btnekmek.TabIndex = 0;
            this.btnekmek.Text = "EKMEK";
            this.btnekmek.UseVisualStyleBackColor = true;
            this.btnekmek.Click += new System.EventHandler(this.btnekmek_Click);
            // 
            // dgvsepet
            // 
            this.dgvsepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.fiyat,
            this.KDVliFiyat});
            this.dgvsepet.Location = new System.Drawing.Point(129, 6);
            this.dgvsepet.Name = "dgvsepet";
            this.dgvsepet.Size = new System.Drawing.Size(400, 295);
            this.dgvsepet.TabIndex = 1;
            // 
            // urunAd
            // 
            this.urunAd.HeaderText = "ÜRÜN AD";
            this.urunAd.Name = "urunAd";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "FİYAT";
            this.fiyat.Name = "fiyat";
            // 
            // KDVliFiyat
            // 
            this.KDVliFiyat.HeaderText = "KDV DAHİL FİYAT";
            this.KDVliFiyat.Name = "KDVliFiyat";
            // 
            // pılimorphism2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 313);
            this.Controls.Add(this.dgvsepet);
            this.Controls.Add(this.btnekmek);
            this.Controls.Add(this.btncep);
            this.Controls.Add(this.btntekstil);
            this.Name = "pılimorphism2";
            this.Text = "pılimorphism2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntekstil;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.Button btnekmek;
        private System.Windows.Forms.DataGridView dgvsepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVliFiyat;
    }
}