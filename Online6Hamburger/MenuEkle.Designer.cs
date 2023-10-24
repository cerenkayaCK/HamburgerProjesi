namespace Online6Hamburger
{
    partial class MenuEkle
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
            btnMenuyuKaydet = new Button();
            numericEklenenMenuFiyat = new NumericUpDown();
            label2 = new Label();
            txtMenuAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEklenenMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenuyuKaydet);
            groupBox1.Controls.Add(numericEklenenMenuFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe MDL2 Assets", 13F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuyuKaydet
            // 
            btnMenuyuKaydet.Location = new Point(54, 139);
            btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            btnMenuyuKaydet.Size = new Size(161, 36);
            btnMenuyuKaydet.TabIndex = 1;
            btnMenuyuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuyuKaydet.UseVisualStyleBackColor = true;
            btnMenuyuKaydet.Click += btnMenuyuKaydet_Click;
            // 
            // numericEklenenMenuFiyat
            // 
            numericEklenenMenuFiyat.Location = new Point(131, 93);
            numericEklenenMenuFiyat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericEklenenMenuFiyat.Name = "numericEklenenMenuFiyat";
            numericEklenenMenuFiyat.Size = new Size(120, 25);
            numericEklenenMenuFiyat.TabIndex = 3;
            numericEklenenMenuFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(131, 45);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(123, 25);
            txtMenuAdi.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 230);
            Controls.Add(groupBox1);
            Name = "MenuEkle";
            Text = "MenuEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEklenenMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnMenuyuKaydet;
        private NumericUpDown numericEklenenMenuFiyat;
        private Label label2;
        public TextBox txtMenuAdi;
    }
}