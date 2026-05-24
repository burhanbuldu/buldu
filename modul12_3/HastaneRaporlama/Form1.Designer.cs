namespace HastaneRaporlama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblHastalik = new System.Windows.Forms.Label();
            this.lblTeshis = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();

            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtHastalik = new System.Windows.Forms.TextBox();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.dtpKayit = new System.Windows.Forms.DateTimePicker();

            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int x1 = 30;
            int x2 = 150;
            int y = 25;
            int gap = 35;

            // AD SOYAD
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.Location = new System.Drawing.Point(x1, y);

            this.txtAdSoyad.Location = new System.Drawing.Point(x2, y);
            this.txtAdSoyad.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // CİNSİYET
            this.lblCinsiyet.Text = "Cinsiyet";
            this.lblCinsiyet.Location = new System.Drawing.Point(x1, y);

            this.txtCinsiyet.Location = new System.Drawing.Point(x2, y);
            this.txtCinsiyet.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // YAŞ
            this.lblYas.Text = "Yaş";
            this.lblYas.Location = new System.Drawing.Point(x1, y);

            this.txtYas.Location = new System.Drawing.Point(x2, y);
            this.txtYas.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // ŞEHİR
            this.lblSehir.Text = "Şehir";
            this.lblSehir.Location = new System.Drawing.Point(x1, y);

            this.txtSehir.Location = new System.Drawing.Point(x2, y);
            this.txtSehir.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // HASTALIK
            this.lblHastalik.Text = "Hastalık";
            this.lblHastalik.Location = new System.Drawing.Point(x1, y);

            this.txtHastalik.Location = new System.Drawing.Point(x2, y);
            this.txtHastalik.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // TEŞHİS
            this.lblTeshis.Text = "Teşhis";
            this.lblTeshis.Location = new System.Drawing.Point(x1, y);

            this.txtTeshis.Location = new System.Drawing.Point(x2, y);
            this.txtTeshis.Size = new System.Drawing.Size(180, 22);

            y += gap;

            // TARİH
            this.lblTarih.Text = "Kayıt Tarihi";
            this.lblTarih.Location = new System.Drawing.Point(x1, y);

            this.dtpKayit.Location = new System.Drawing.Point(x2, y);
            this.dtpKayit.Size = new System.Drawing.Size(180, 22);

            y += 50;

            // KAYDET
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Location = new System.Drawing.Point(x1, y);
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // RAPOR
            this.btnRapor.Text = "Rapor";
            this.btnRapor.Location = new System.Drawing.Point(160, y);
            this.btnRapor.Size = new System.Drawing.Size(100, 30);
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);

            // FORM
            this.ClientSize = new System.Drawing.Size(400, 350);

            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblHastalik);
            this.Controls.Add(this.lblTeshis);
            this.Controls.Add(this.lblTarih);

            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtHastalik);
            this.Controls.Add(this.txtTeshis);
            this.Controls.Add(this.dtpKayit);

            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRapor);

            this.Text = "Hasta Kayıt Sistemi";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblHastalik;
        private System.Windows.Forms.Label lblTeshis;
        private System.Windows.Forms.Label lblTarih;

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtHastalik;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.DateTimePicker dtpKayit;

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnRapor;
    }
}