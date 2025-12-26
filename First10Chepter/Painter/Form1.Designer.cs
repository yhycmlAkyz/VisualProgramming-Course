namespace Painter
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
            this.Tuval = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Palet = new System.Windows.Forms.GroupBox();
            this.Fırca = new System.Windows.Forms.GroupBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.Kırmızı = new System.Windows.Forms.RadioButton();
            this.Mavi = new System.Windows.Forms.RadioButton();
            this.Yesil = new System.Windows.Forms.RadioButton();
            this.Siyah = new System.Windows.Forms.RadioButton();
            this.Silgi = new System.Windows.Forms.RadioButton();
            this.Minik = new System.Windows.Forms.RadioButton();
            this.Orta = new System.Windows.Forms.RadioButton();
            this.Kocaman = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tuval)).BeginInit();
            this.panel1.SuspendLayout();
            this.Palet.SuspendLayout();
            this.Fırca.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tuval
            // 
            this.Tuval.Location = new System.Drawing.Point(323, 12);
            this.Tuval.Name = "Tuval";
            this.Tuval.Size = new System.Drawing.Size(895, 591);
            this.Tuval.TabIndex = 0;
            this.Tuval.TabStop = false;
            this.Tuval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tuval_MouseDown);
            this.Tuval.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tuval_MouseMove);
            this.Tuval.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tuval_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Temizle);
            this.panel1.Controls.Add(this.Fırca);
            this.panel1.Controls.Add(this.Palet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 591);
            this.panel1.TabIndex = 1;
            // 
            // Palet
            // 
            this.Palet.Controls.Add(this.Silgi);
            this.Palet.Controls.Add(this.Siyah);
            this.Palet.Controls.Add(this.Yesil);
            this.Palet.Controls.Add(this.Mavi);
            this.Palet.Controls.Add(this.Kırmızı);
            this.Palet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Palet.Location = new System.Drawing.Point(3, 3);
            this.Palet.Name = "Palet";
            this.Palet.Size = new System.Drawing.Size(297, 304);
            this.Palet.TabIndex = 0;
            this.Palet.TabStop = false;
            this.Palet.Text = "Palet";
            // 
            // Fırca
            // 
            this.Fırca.Controls.Add(this.Kocaman);
            this.Fırca.Controls.Add(this.Orta);
            this.Fırca.Controls.Add(this.Minik);
            this.Fırca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fırca.Location = new System.Drawing.Point(3, 313);
            this.Fırca.Name = "Fırca";
            this.Fırca.Size = new System.Drawing.Size(297, 169);
            this.Fırca.TabIndex = 0;
            this.Fırca.TabStop = false;
            this.Fırca.Text = "Fırca";
            // 
            // Temizle
            // 
            this.Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(34, 508);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(232, 53);
            this.Temizle.TabIndex = 0;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click_1);
            // 
            // Kırmızı
            // 
            this.Kırmızı.AutoSize = true;
            this.Kırmızı.Location = new System.Drawing.Point(80, 57);
            this.Kırmızı.Name = "Kırmızı";
            this.Kırmızı.Size = new System.Drawing.Size(121, 36);
            this.Kırmızı.TabIndex = 0;
            this.Kırmızı.TabStop = true;
            this.Kırmızı.Text = "Kırmızı";
            this.Kırmızı.UseVisualStyleBackColor = true;
            // 
            // Mavi
            // 
            this.Mavi.AutoSize = true;
            this.Mavi.Location = new System.Drawing.Point(80, 99);
            this.Mavi.Name = "Mavi";
            this.Mavi.Size = new System.Drawing.Size(95, 36);
            this.Mavi.TabIndex = 1;
            this.Mavi.TabStop = true;
            this.Mavi.Text = "Mavi";
            this.Mavi.UseVisualStyleBackColor = true;
            // 
            // Yesil
            // 
            this.Yesil.AutoSize = true;
            this.Yesil.Location = new System.Drawing.Point(80, 141);
            this.Yesil.Name = "Yesil";
            this.Yesil.Size = new System.Drawing.Size(98, 36);
            this.Yesil.TabIndex = 2;
            this.Yesil.TabStop = true;
            this.Yesil.Text = "Yesil";
            this.Yesil.UseVisualStyleBackColor = true;
            // 
            // Siyah
            // 
            this.Siyah.AutoSize = true;
            this.Siyah.Location = new System.Drawing.Point(80, 183);
            this.Siyah.Name = "Siyah";
            this.Siyah.Size = new System.Drawing.Size(107, 36);
            this.Siyah.TabIndex = 3;
            this.Siyah.TabStop = true;
            this.Siyah.Text = "Siyah";
            this.Siyah.UseVisualStyleBackColor = true;
            // 
            // Silgi
            // 
            this.Silgi.AutoSize = true;
            this.Silgi.Location = new System.Drawing.Point(80, 225);
            this.Silgi.Name = "Silgi";
            this.Silgi.Size = new System.Drawing.Size(91, 36);
            this.Silgi.TabIndex = 4;
            this.Silgi.TabStop = true;
            this.Silgi.Text = "Silgi";
            this.Silgi.UseVisualStyleBackColor = true;
            // 
            // Minik
            // 
            this.Minik.AutoSize = true;
            this.Minik.Location = new System.Drawing.Point(80, 37);
            this.Minik.Name = "Minik";
            this.Minik.Size = new System.Drawing.Size(102, 36);
            this.Minik.TabIndex = 5;
            this.Minik.TabStop = true;
            this.Minik.Text = "Minik";
            this.Minik.UseVisualStyleBackColor = true;
            // 
            // Orta
            // 
            this.Orta.AutoSize = true;
            this.Orta.Location = new System.Drawing.Point(80, 76);
            this.Orta.Name = "Orta";
            this.Orta.Size = new System.Drawing.Size(90, 36);
            this.Orta.TabIndex = 6;
            this.Orta.TabStop = true;
            this.Orta.Text = "Orta";
            this.Orta.UseVisualStyleBackColor = true;
            // 
            // Kocaman
            // 
            this.Kocaman.AutoSize = true;
            this.Kocaman.Location = new System.Drawing.Point(80, 118);
            this.Kocaman.Name = "Kocaman";
            this.Kocaman.Size = new System.Drawing.Size(155, 36);
            this.Kocaman.TabIndex = 7;
            this.Kocaman.TabStop = true;
            this.Kocaman.Text = "Kocaman";
            this.Kocaman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tuval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Çizim Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tuval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Palet.ResumeLayout(false);
            this.Palet.PerformLayout();
            this.Fırca.ResumeLayout(false);
            this.Fırca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tuval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Fırca;
        private System.Windows.Forms.GroupBox Palet;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.RadioButton Kocaman;
        private System.Windows.Forms.RadioButton Orta;
        private System.Windows.Forms.RadioButton Minik;
        private System.Windows.Forms.RadioButton Silgi;
        private System.Windows.Forms.RadioButton Siyah;
        private System.Windows.Forms.RadioButton Yesil;
        private System.Windows.Forms.RadioButton Mavi;
        private System.Windows.Forms.RadioButton Kırmızı;
    }
}

