namespace Online6Hamburger
{
    partial class SiparisBilgileri
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
            label1 = new Label();
            lstTumSiparisler = new ListBox();
            groupBox1 = new GroupBox();
            lblCiro = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 16);
            label1.TabIndex = 0;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 12;
            lstTumSiparisler.Location = new Point(12, 51);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(264, 280);
            lstTumSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Location = new Point(303, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 61);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CİRO";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiro.Location = new Point(18, 25);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(38, 16);
            lblCiro.TabIndex = 4;
            lblCiro.Text = "₺0,00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(303, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 61);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "TOPLAM SİPARİŞ SAYISI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 27);
            label3.Name = "label3";
            label3.Size = new Size(14, 16);
            label3.TabIndex = 0;
            label3.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraMalzemeGeliri);
            groupBox3.Location = new Point(303, 185);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 61);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "EKSTRA MALZEME GELİRİ";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.Location = new Point(18, 27);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(38, 16);
            lblEkstraMalzemeGeliri.TabIndex = 5;
            lblEkstraMalzemeGeliri.Text = "₺0,00";
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 360);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(lstTumSiparisler);
            Controls.Add(label1);
            Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblCiro;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox3;
        private Label lblEkstraMalzemeGeliri;
        public ListBox lstTumSiparisler;
    }
}