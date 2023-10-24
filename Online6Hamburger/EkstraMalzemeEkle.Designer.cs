namespace Online6Hamburger
{
    partial class EkstraMalzemeEkle
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
            groupBox1 = new GroupBox();
            btnEkstraMalzemeyiKaydet = new Button();
            numericEkstraMalzemeFiyat = new NumericUpDown();
            label2 = new Label();
            txtEkstraMalzemeAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEkstraMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkstraMalzemeyiKaydet);
            groupBox1.Controls.Add(numericEkstraMalzemeFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEkstraMalzemeAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(284, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeyiKaydet
            // 
            btnEkstraMalzemeyiKaydet.Location = new Point(20, 116);
            btnEkstraMalzemeyiKaydet.Name = "btnEkstraMalzemeyiKaydet";
            btnEkstraMalzemeyiKaydet.Size = new Size(242, 33);
            btnEkstraMalzemeyiKaydet.TabIndex = 3;
            btnEkstraMalzemeyiKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnEkstraMalzemeyiKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeyiKaydet.Click += btnEkstraMalzemeyiKaydet_Click;
            // 
            // numericEkstraMalzemeFiyat
            // 
            numericEkstraMalzemeFiyat.Location = new Point(145, 76);
            numericEkstraMalzemeFiyat.Margin = new Padding(3, 2, 3, 2);
            numericEkstraMalzemeFiyat.Name = "numericEkstraMalzemeFiyat";
            numericEkstraMalzemeFiyat.Size = new Size(117, 23);
            numericEkstraMalzemeFiyat.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(145, 39);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(117, 23);
            txtEkstraMalzemeAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 16);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 196);
            Controls.Add(groupBox1);
            Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEkstraMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        public Button btnEkstraMalzemeyiKaydet;
        public NumericUpDown numericEkstraMalzemeFiyat;
        public TextBox txtEkstraMalzemeAdi;
    }
}