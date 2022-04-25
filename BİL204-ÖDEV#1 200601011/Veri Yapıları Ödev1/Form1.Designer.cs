
namespace Veri_Yapıları_Ödev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.cbMusteriTuru = new System.Windows.Forms.ComboBox();
            this.gbMusteri = new System.Windows.Forms.GroupBox();
            this.lblSıra = new System.Windows.Forms.Label();
            this.txtSıra = new System.Windows.Forms.TextBox();
            this.lblAramaZamani = new System.Windows.Forms.Label();
            this.txtAramaZamani = new System.Windows.Forms.TextBox();
            this.lblMusteriTanimlayici = new System.Windows.Forms.Label();
            this.txtMusteriTanimlayici = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNotDefteri = new System.Windows.Forms.Label();
            this.rtxtNotDefteri = new System.Windows.Forms.RichTextBox();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.lblCagriTanimlayici = new System.Windows.Forms.Label();
            this.txtCagriTanimlayici = new System.Windows.Forms.TextBox();
            this.btnCagriAta = new System.Windows.Forms.Button();
            this.cbTemsilciTuru = new System.Windows.Forms.ComboBox();
            this.gbMusteri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(95, 237);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(159, 53);
            this.btnAramaYap.TabIndex = 0;
            this.btnAramaYap.Text = "ARAMA YAP";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // cbMusteriTuru
            // 
            this.cbMusteriTuru.FormattingEnabled = true;
            this.cbMusteriTuru.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.cbMusteriTuru.Location = new System.Drawing.Point(18, 38);
            this.cbMusteriTuru.Name = "cbMusteriTuru";
            this.cbMusteriTuru.Size = new System.Drawing.Size(159, 24);
            this.cbMusteriTuru.TabIndex = 3;
            this.cbMusteriTuru.Text = "Bireysel";
            // 
            // gbMusteri
            // 
            this.gbMusteri.Controls.Add(this.lblSıra);
            this.gbMusteri.Controls.Add(this.txtSıra);
            this.gbMusteri.Controls.Add(this.lblAramaZamani);
            this.gbMusteri.Controls.Add(this.txtAramaZamani);
            this.gbMusteri.Controls.Add(this.lblMusteriTanimlayici);
            this.gbMusteri.Controls.Add(this.txtMusteriTanimlayici);
            this.gbMusteri.Controls.Add(this.cbMusteriTuru);
            this.gbMusteri.Controls.Add(this.btnAramaYap);
            this.gbMusteri.Location = new System.Drawing.Point(44, 48);
            this.gbMusteri.Name = "gbMusteri";
            this.gbMusteri.Size = new System.Drawing.Size(406, 616);
            this.gbMusteri.TabIndex = 4;
            this.gbMusteri.TabStop = false;
            this.gbMusteri.Text = "Müşteri";
            // 
            // lblSıra
            // 
            this.lblSıra.AutoSize = true;
            this.lblSıra.Location = new System.Drawing.Point(282, 217);
            this.lblSıra.Name = "lblSıra";
            this.lblSıra.Size = new System.Drawing.Size(73, 17);
            this.lblSıra.TabIndex = 9;
            this.lblSıra.Text = "Kalan Sıra";
            // 
            // txtSıra
            // 
            this.txtSıra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSıra.Location = new System.Drawing.Point(285, 237);
            this.txtSıra.Multiline = true;
            this.txtSıra.Name = "txtSıra";
            this.txtSıra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSıra.Size = new System.Drawing.Size(69, 53);
            this.txtSıra.TabIndex = 8;
            this.txtSıra.Text = "0";
            this.txtSıra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAramaZamani
            // 
            this.lblAramaZamani.AutoSize = true;
            this.lblAramaZamani.Location = new System.Drawing.Point(15, 162);
            this.lblAramaZamani.Name = "lblAramaZamani";
            this.lblAramaZamani.Size = new System.Drawing.Size(100, 17);
            this.lblAramaZamani.TabIndex = 7;
            this.lblAramaZamani.Text = "Arama Zamanı";
            // 
            // txtAramaZamani
            // 
            this.txtAramaZamani.Location = new System.Drawing.Point(18, 182);
            this.txtAramaZamani.Name = "txtAramaZamani";
            this.txtAramaZamani.Size = new System.Drawing.Size(159, 22);
            this.txtAramaZamani.TabIndex = 6;
            // 
            // lblMusteriTanimlayici
            // 
            this.lblMusteriTanimlayici.AutoSize = true;
            this.lblMusteriTanimlayici.Location = new System.Drawing.Point(15, 89);
            this.lblMusteriTanimlayici.Name = "lblMusteriTanimlayici";
            this.lblMusteriTanimlayici.Size = new System.Drawing.Size(138, 17);
            this.lblMusteriTanimlayici.TabIndex = 5;
            this.lblMusteriTanimlayici.Text = "Müşteri Tanımlayıcısı";
            // 
            // txtMusteriTanimlayici
            // 
            this.txtMusteriTanimlayici.Location = new System.Drawing.Point(18, 109);
            this.txtMusteriTanimlayici.Name = "txtMusteriTanimlayici";
            this.txtMusteriTanimlayici.Size = new System.Drawing.Size(159, 22);
            this.txtMusteriTanimlayici.TabIndex = 4;
            this.txtMusteriTanimlayici.Text = "200601";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTemsilciTuru);
            this.groupBox2.Controls.Add(this.lblNotDefteri);
            this.groupBox2.Controls.Add(this.rtxtNotDefteri);
            this.groupBox2.Controls.Add(this.btnCagriBitir);
            this.groupBox2.Controls.Add(this.lblCagriTanimlayici);
            this.groupBox2.Controls.Add(this.txtCagriTanimlayici);
            this.groupBox2.Controls.Add(this.btnCagriAta);
            this.groupBox2.Location = new System.Drawing.Point(495, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 616);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Temsilcisi";
            // 
            // lblNotDefteri
            // 
            this.lblNotDefteri.AutoSize = true;
            this.lblNotDefteri.Location = new System.Drawing.Point(17, 202);
            this.lblNotDefteri.Name = "lblNotDefteri";
            this.lblNotDefteri.Size = new System.Drawing.Size(76, 17);
            this.lblNotDefteri.TabIndex = 14;
            this.lblNotDefteri.Text = "Not Defteri";
            // 
            // rtxtNotDefteri
            // 
            this.rtxtNotDefteri.Location = new System.Drawing.Point(20, 222);
            this.rtxtNotDefteri.Name = "rtxtNotDefteri";
            this.rtxtNotDefteri.Size = new System.Drawing.Size(370, 148);
            this.rtxtNotDefteri.TabIndex = 13;
            this.rtxtNotDefteri.Text = "";
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.Location = new System.Drawing.Point(130, 406);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(159, 53);
            this.btnCagriBitir.TabIndex = 12;
            this.btnCagriBitir.Text = "ÇAĞRIYI BİTİR";
            this.btnCagriBitir.UseVisualStyleBackColor = true;
            // 
            // lblCagriTanimlayici
            // 
            this.lblCagriTanimlayici.AutoSize = true;
            this.lblCagriTanimlayici.Location = new System.Drawing.Point(17, 89);
            this.lblCagriTanimlayici.Name = "lblCagriTanimlayici";
            this.lblCagriTanimlayici.Size = new System.Drawing.Size(125, 17);
            this.lblCagriTanimlayici.TabIndex = 11;
            this.lblCagriTanimlayici.Text = "Çağrı Tanımlayıcısı";
            // 
            // txtCagriTanimlayici
            // 
            this.txtCagriTanimlayici.Location = new System.Drawing.Point(20, 109);
            this.txtCagriTanimlayici.Name = "txtCagriTanimlayici";
            this.txtCagriTanimlayici.Size = new System.Drawing.Size(159, 22);
            this.txtCagriTanimlayici.TabIndex = 10;
            this.txtCagriTanimlayici.Text = "19374";
            // 
            // btnCagriAta
            // 
            this.btnCagriAta.Location = new System.Drawing.Point(130, 151);
            this.btnCagriAta.Name = "btnCagriAta";
            this.btnCagriAta.Size = new System.Drawing.Size(159, 53);
            this.btnCagriAta.TabIndex = 10;
            this.btnCagriAta.Text = "ÇAĞRIYI ATA";
            this.btnCagriAta.UseVisualStyleBackColor = true;
            this.btnCagriAta.Click += new System.EventHandler(this.btnCagriAta_Click);
            // 
            // cbTemsilciTuru
            // 
            this.cbTemsilciTuru.FormattingEnabled = true;
            this.cbTemsilciTuru.Items.AddRange(new object[] {
            "Bireysel #1",
            "Bireysel #2",
            "Ticari #1",
            "Ticari #2"});
            this.cbTemsilciTuru.Location = new System.Drawing.Point(20, 38);
            this.cbTemsilciTuru.Name = "cbTemsilciTuru";
            this.cbTemsilciTuru.Size = new System.Drawing.Size(159, 24);
            this.cbTemsilciTuru.TabIndex = 10;
            this.cbTemsilciTuru.Text = "Bireysel #1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMusteri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMusteri.ResumeLayout(false);
            this.gbMusteri.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.ComboBox cbMusteriTuru;
        private System.Windows.Forms.GroupBox gbMusteri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSıra;
        private System.Windows.Forms.TextBox txtSıra;
        private System.Windows.Forms.Label lblAramaZamani;
        private System.Windows.Forms.TextBox txtAramaZamani;
        private System.Windows.Forms.Label lblMusteriTanimlayici;
        private System.Windows.Forms.TextBox txtMusteriTanimlayici;
        private System.Windows.Forms.Label lblNotDefteri;
        private System.Windows.Forms.RichTextBox rtxtNotDefteri;
        private System.Windows.Forms.Button btnCagriBitir;
        private System.Windows.Forms.Label lblCagriTanimlayici;
        private System.Windows.Forms.TextBox txtCagriTanimlayici;
        private System.Windows.Forms.Button btnCagriAta;
        private System.Windows.Forms.ComboBox cbTemsilciTuru;
    }
}

