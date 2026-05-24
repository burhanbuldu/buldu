namespace HastaneRaporlama
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnGetir = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Size = new System.Drawing.Size(760, 380);
            this.dataGridView1.Name = "dataGridView1";

            // cmbFiltre
            this.cmbFiltre.Location = new System.Drawing.Point(12, 20);
            this.cmbFiltre.Size = new System.Drawing.Size(200, 24);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Items.AddRange(new object[] {
                "Tümü",
                "Erkek",
                "Kadın",
                "İzmir",
                "50 Yaş Üstü"
            });
            this.cmbFiltre.Text = "Tümü";

            // btnGetir
            this.btnGetir.Location = new System.Drawing.Point(230, 18);
            this.btnGetir.Size = new System.Drawing.Size(120, 28);
            this.btnGetir.Text = "Rapor Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);

            // Form2
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnGetir);
            this.Text = "Hasta Raporları";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Button btnGetir;
    }
}