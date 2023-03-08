namespace Proje.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_MalzemeSecimi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_Buyuk = new System.Windows.Forms.RadioButton();
            this.rd_Orta = new System.Windows.Forms.RadioButton();
            this.rd_Kucuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ch_Ketcap = new System.Windows.Forms.CheckBox();
            this.ch_Mayonez = new System.Windows.Forms.CheckBox();
            this.ch_Hardal = new System.Windows.Forms.CheckBox();
            this.ch_Barbeku = new System.Windows.Forms.CheckBox();
            this.ch_Ranch = new System.Windows.Forms.CheckBox();
            this.ch_Buffaio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ToplamTutar = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmb_MalzemeSecimi
            // 
            this.cmb_MalzemeSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MalzemeSecimi.FormattingEnabled = true;
            this.cmb_MalzemeSecimi.Location = new System.Drawing.Point(33, 183);
            this.cmb_MalzemeSecimi.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_MalzemeSecimi.Name = "cmb_MalzemeSecimi";
            this.cmb_MalzemeSecimi.Size = new System.Drawing.Size(237, 21);
            this.cmb_MalzemeSecimi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_Buyuk);
            this.panel1.Controls.Add(this.rd_Orta);
            this.panel1.Controls.Add(this.rd_Kucuk);
            this.panel1.Location = new System.Drawing.Point(33, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 48);
            this.panel1.TabIndex = 3;
            // 
            // rd_Buyuk
            // 
            this.rd_Buyuk.AutoSize = true;
            this.rd_Buyuk.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Buyuk.Location = new System.Drawing.Point(113, 12);
            this.rd_Buyuk.Name = "rd_Buyuk";
            this.rd_Buyuk.Size = new System.Drawing.Size(54, 19);
            this.rd_Buyuk.TabIndex = 0;
            this.rd_Buyuk.TabStop = true;
            this.rd_Buyuk.Text = "Buyuk";
            this.rd_Buyuk.UseVisualStyleBackColor = true;
            // 
            // rd_Orta
            // 
            this.rd_Orta.AutoSize = true;
            this.rd_Orta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Orta.Location = new System.Drawing.Point(63, 12);
            this.rd_Orta.Name = "rd_Orta";
            this.rd_Orta.Size = new System.Drawing.Size(44, 19);
            this.rd_Orta.TabIndex = 0;
            this.rd_Orta.TabStop = true;
            this.rd_Orta.Text = "Orta";
            this.rd_Orta.UseVisualStyleBackColor = true;
            // 
            // rd_Kucuk
            // 
            this.rd_Kucuk.AutoSize = true;
            this.rd_Kucuk.Checked = true;
            this.rd_Kucuk.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Kucuk.Location = new System.Drawing.Point(3, 12);
            this.rd_Kucuk.Name = "rd_Kucuk";
            this.rd_Kucuk.Size = new System.Drawing.Size(54, 19);
            this.rd_Kucuk.TabIndex = 0;
            this.rd_Kucuk.TabStop = true;
            this.rd_Kucuk.Text = "Kucuk";
            this.rd_Kucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "BOYUT SEÇİNİZ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ch_Ketcap);
            this.flowLayoutPanel1.Controls.Add(this.ch_Mayonez);
            this.flowLayoutPanel1.Controls.Add(this.ch_Hardal);
            this.flowLayoutPanel1.Controls.Add(this.ch_Barbeku);
            this.flowLayoutPanel1.Controls.Add(this.ch_Ranch);
            this.flowLayoutPanel1.Controls.Add(this.ch_Buffaio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 298);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 93);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ch_Ketcap
            // 
            this.ch_Ketcap.AutoSize = true;
            this.ch_Ketcap.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Ketcap.Location = new System.Drawing.Point(3, 3);
            this.ch_Ketcap.Name = "ch_Ketcap";
            this.ch_Ketcap.Size = new System.Drawing.Size(57, 19);
            this.ch_Ketcap.TabIndex = 5;
            this.ch_Ketcap.Text = "Ketçap";
            this.ch_Ketcap.UseVisualStyleBackColor = true;
            // 
            // ch_Mayonez
            // 
            this.ch_Mayonez.AutoSize = true;
            this.ch_Mayonez.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Mayonez.Location = new System.Drawing.Point(66, 3);
            this.ch_Mayonez.Name = "ch_Mayonez";
            this.ch_Mayonez.Size = new System.Drawing.Size(66, 19);
            this.ch_Mayonez.TabIndex = 6;
            this.ch_Mayonez.Text = "Mayonez";
            this.ch_Mayonez.UseVisualStyleBackColor = true;
            // 
            // ch_Hardal
            // 
            this.ch_Hardal.AutoSize = true;
            this.ch_Hardal.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Hardal.Location = new System.Drawing.Point(138, 3);
            this.ch_Hardal.Name = "ch_Hardal";
            this.ch_Hardal.Size = new System.Drawing.Size(56, 19);
            this.ch_Hardal.TabIndex = 7;
            this.ch_Hardal.Text = "Hardal";
            this.ch_Hardal.UseVisualStyleBackColor = true;
            // 
            // ch_Barbeku
            // 
            this.ch_Barbeku.AutoSize = true;
            this.ch_Barbeku.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Barbeku.Location = new System.Drawing.Point(3, 28);
            this.ch_Barbeku.Name = "ch_Barbeku";
            this.ch_Barbeku.Size = new System.Drawing.Size(47, 19);
            this.ch_Barbeku.TabIndex = 8;
            this.ch_Barbeku.Text = "BBQ";
            this.ch_Barbeku.UseVisualStyleBackColor = true;
            // 
            // ch_Ranch
            // 
            this.ch_Ranch.AutoSize = true;
            this.ch_Ranch.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Ranch.Location = new System.Drawing.Point(56, 28);
            this.ch_Ranch.Name = "ch_Ranch";
            this.ch_Ranch.Size = new System.Drawing.Size(55, 19);
            this.ch_Ranch.TabIndex = 9;
            this.ch_Ranch.Text = "Ranch";
            this.ch_Ranch.UseVisualStyleBackColor = true;
            // 
            // ch_Buffaio
            // 
            this.ch_Buffaio.AutoSize = true;
            this.ch_Buffaio.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Buffaio.Location = new System.Drawing.Point(117, 28);
            this.ch_Buffaio.Name = "ch_Buffaio";
            this.ch_Buffaio.Size = new System.Drawing.Size(59, 19);
            this.ch_Buffaio.TabIndex = 10;
            this.ch_Buffaio.Text = "Buffalo";
            this.ch_Buffaio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADET";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(92, 403);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "SİPARİŞ EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOPLAM TUTAR";
            // 
            // lbl_ToplamTutar
            // 
            this.lbl_ToplamTutar.AutoSize = true;
            this.lbl_ToplamTutar.BackColor = System.Drawing.Color.Red;
            this.lbl_ToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToplamTutar.Location = new System.Drawing.Point(362, 451);
            this.lbl_ToplamTutar.Name = "lbl_ToplamTutar";
            this.lbl_ToplamTutar.Size = new System.Drawing.Size(17, 17);
            this.lbl_ToplamTutar.TabIndex = 1;
            this.lbl_ToplamTutar.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 394);
            this.listBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(642, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "SİPARİŞİ TAMAMLA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_MalzemeSecimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_Buyuk;
        private System.Windows.Forms.RadioButton rd_Orta;
        private System.Windows.Forms.RadioButton rd_Kucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ch_Ketcap;
        private System.Windows.Forms.CheckBox ch_Mayonez;
        private System.Windows.Forms.CheckBox ch_Hardal;
        private System.Windows.Forms.CheckBox ch_Barbeku;
        private System.Windows.Forms.CheckBox ch_Ranch;
        private System.Windows.Forms.CheckBox ch_Buffaio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ToplamTutar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cmb_MalzemeSecimi;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}