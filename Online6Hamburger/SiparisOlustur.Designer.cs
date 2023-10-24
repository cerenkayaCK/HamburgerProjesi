namespace Online6Hamburger
{
    partial class SiparisOlustur
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            pictureBox1 = new PictureBox();
            cboMenu = new ComboBox();
            label1 = new Label();
            radioKucuk = new RadioButton();
            bindingSource1 = new BindingSource(components);
            grpBoyut = new GroupBox();
            radioBuyuk = new RadioButton();
            radioORTA = new RadioButton();
            label2 = new Label();
            ADET = new Label();
            numericAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            label3 = new Label();
            label4 = new Label();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            lstMevcutSiparisler = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 25);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cboMenu
            // 
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(28, 198);
            cboMenu.Margin = new Padding(4, 3, 4, 3);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(355, 24);
            cboMenu.TabIndex = 1;
            cboMenu.SelectedIndexChanged += cboMenu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 2;
            label1.Text = "MENÜ SEÇİN";
            // 
            // radioKucuk
            // 
            radioKucuk.AutoSize = true;
            radioKucuk.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioKucuk.Location = new Point(21, 35);
            radioKucuk.Margin = new Padding(4, 3, 4, 3);
            radioKucuk.Name = "radioKucuk";
            radioKucuk.Size = new Size(67, 20);
            radioKucuk.TabIndex = 3;
            radioKucuk.TabStop = true;
            radioKucuk.Text = "KÜÇÜK";
            radioKucuk.UseVisualStyleBackColor = true;
            // 
            // grpBoyut
            // 
            grpBoyut.BackColor = SystemColors.Menu;
            grpBoyut.BackgroundImageLayout = ImageLayout.None;
            grpBoyut.Controls.Add(radioBuyuk);
            grpBoyut.Controls.Add(radioORTA);
            grpBoyut.Controls.Add(radioKucuk);
            grpBoyut.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyut.Location = new Point(28, 239);
            grpBoyut.Margin = new Padding(4, 3, 4, 3);
            grpBoyut.Name = "grpBoyut";
            grpBoyut.Padding = new Padding(4, 3, 4, 3);
            grpBoyut.Size = new Size(355, 75);
            grpBoyut.TabIndex = 4;
            grpBoyut.TabStop = false;
            grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // radioBuyuk
            // 
            radioBuyuk.AutoSize = true;
            radioBuyuk.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioBuyuk.Location = new Point(247, 36);
            radioBuyuk.Margin = new Padding(4, 3, 4, 3);
            radioBuyuk.Name = "radioBuyuk";
            radioBuyuk.Size = new Size(66, 20);
            radioBuyuk.TabIndex = 5;
            radioBuyuk.TabStop = true;
            radioBuyuk.Text = "BÜYÜK";
            radioBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioORTA
            // 
            radioORTA.AutoSize = true;
            radioORTA.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioORTA.Location = new Point(140, 36);
            radioORTA.Margin = new Padding(4, 3, 4, 3);
            radioORTA.Name = "radioORTA";
            radioORTA.Size = new Size(57, 20);
            radioORTA.TabIndex = 4;
            radioORTA.TabStop = true;
            radioORTA.Text = "ORTA";
            radioORTA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 317);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 5;
            label2.Text = "MALZEME SEÇİN";
            // 
            // ADET
            // 
            ADET.AutoSize = true;
            ADET.Location = new Point(421, 348);
            ADET.Margin = new Padding(4, 0, 4, 0);
            ADET.Name = "ADET";
            ADET.Size = new Size(38, 16);
            ADET.TabIndex = 12;
            ADET.Text = "ADET";
            // 
            // numericAdet
            // 
            numericAdet.Location = new Point(467, 346);
            numericAdet.Margin = new Padding(4, 3, 4, 3);
            numericAdet.Name = "numericAdet";
            numericAdet.Size = new Size(130, 23);
            numericAdet.TabIndex = 13;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(387, 415);
            btnSiparisEkle.Margin = new Padding(4, 3, 4, 3);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(123, 26);
            btnSiparisEkle.TabIndex = 14;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(518, 421);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 15;
            label3.Text = "TOPLAM TUTAR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(579, 438);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "₺0,00";
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.BackColor = Color.Transparent;
            flpEkstraMalzemeler.Location = new Point(13, 339);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(343, 121);
            flpEkstraMalzemeler.TabIndex = 17;
            flpEkstraMalzemeler.Paint += flpEkstraMalzemeler_Paint;
            // 
            // lstMevcutSiparisler
            // 
            lstMevcutSiparisler.FormattingEnabled = true;
            lstMevcutSiparisler.ItemHeight = 16;
            lstMevcutSiparisler.Location = new Point(408, 25);
            lstMevcutSiparisler.Name = "lstMevcutSiparisler";
            lstMevcutSiparisler.Size = new Size(209, 260);
            lstMevcutSiparisler.TabIndex = 18;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 472);
            Controls.Add(lstMevcutSiparisler);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSiparisEkle);
            Controls.Add(numericAdet);
            Controls.Add(ADET);
            Controls.Add(grpBoyut);
            Controls.Add(label1);
            Controls.Add(cboMenu);
            Controls.Add(pictureBox1);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(label2);
            Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            grpBoyut.ResumeLayout(false);
            grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton radioKucuk;
        private BindingSource bindingSource1;
        private GroupBox grpBoyut;
        private RadioButton radioBuyuk;
        private RadioButton radioORTA;
        private Label label2;
        private CheckBox chkKetcap;
        private CheckBox chkMayonez;
        private CheckBox chkBBQ;
        private CheckBox chkBuffalo;
        private CheckBox chkRanch;
        private Label ADET;
        private NumericUpDown numericAdet;
        private Button btnSiparisEkle;
        private Label label3;
        private Label label4;
        public ComboBox cboMenu;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private ListBox lstMevcutSiparisler;
        private CheckBox chkHardall;
    }
}