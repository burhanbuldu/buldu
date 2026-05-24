namespace HesapMakinesi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonTopla;
        private System.Windows.Forms.Button buttonCikar;
        private System.Windows.Forms.Button buttonCarp;
        private System.Windows.Forms.Button buttonBol;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonTopla = new System.Windows.Forms.Button();
            this.buttonCikar = new System.Windows.Forms.Button();
            this.buttonCarp = new System.Windows.Forms.Button();
            this.buttonBol = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(40, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(40, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);

            // textBox3
            this.textBox3.Location = new System.Drawing.Point(40, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.ReadOnly = true;

            // buttonTopla
            this.buttonTopla.Location = new System.Drawing.Point(40, 150);
            this.buttonTopla.Size = new System.Drawing.Size(90, 30);
            this.buttonTopla.Text = "Topla";
            this.buttonTopla.Click += new System.EventHandler(this.buttonTopla_Click);

            // buttonCikar
            this.buttonCikar.Location = new System.Drawing.Point(150, 150);
            this.buttonCikar.Size = new System.Drawing.Size(90, 30);
            this.buttonCikar.Text = "Çıkar";
            this.buttonCikar.Click += new System.EventHandler(this.buttonCikar_Click);

            // buttonCarp
            this.buttonCarp.Location = new System.Drawing.Point(40, 190);
            this.buttonCarp.Size = new System.Drawing.Size(90, 30);
            this.buttonCarp.Text = "Çarp";
            this.buttonCarp.Click += new System.EventHandler(this.buttonCarp_Click);

            // buttonBol
            this.buttonBol.Location = new System.Drawing.Point(150, 190);
            this.buttonBol.Size = new System.Drawing.Size(90, 30);
            this.buttonBol.Text = "Böl";
            this.buttonBol.Click += new System.EventHandler(this.buttonBol_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonTopla);
            this.Controls.Add(this.buttonCikar);
            this.Controls.Add(this.buttonCarp);
            this.Controls.Add(this.buttonBol);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}