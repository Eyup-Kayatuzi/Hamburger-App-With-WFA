namespace Proje.Forms
{
    partial class TumSiparis
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Ciro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_SiparisSayisi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_EkstraMalzemeGel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_SatilanUrunAd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 433);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Ciro);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Ciro
            // 
            this.lbl_Ciro.AutoSize = true;
            this.lbl_Ciro.BackColor = System.Drawing.Color.Red;
            this.lbl_Ciro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciro.Location = new System.Drawing.Point(6, 32);
            this.lbl_Ciro.Name = "lbl_Ciro";
            this.lbl_Ciro.Size = new System.Drawing.Size(17, 17);
            this.lbl_Ciro.TabIndex = 2;
            this.lbl_Ciro.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_SiparisSayisi);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(370, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl_SiparisSayisi
            // 
            this.lbl_SiparisSayisi.AutoSize = true;
            this.lbl_SiparisSayisi.BackColor = System.Drawing.Color.Red;
            this.lbl_SiparisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SiparisSayisi.Location = new System.Drawing.Point(6, 32);
            this.lbl_SiparisSayisi.Name = "lbl_SiparisSayisi";
            this.lbl_SiparisSayisi.Size = new System.Drawing.Size(17, 17);
            this.lbl_SiparisSayisi.TabIndex = 2;
            this.lbl_SiparisSayisi.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_EkstraMalzemeGel);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(370, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra Malzeme Geliri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_EkstraMalzemeGel
            // 
            this.lbl_EkstraMalzemeGel.AutoSize = true;
            this.lbl_EkstraMalzemeGel.BackColor = System.Drawing.Color.Red;
            this.lbl_EkstraMalzemeGel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EkstraMalzemeGel.Location = new System.Drawing.Point(6, 32);
            this.lbl_EkstraMalzemeGel.Name = "lbl_EkstraMalzemeGel";
            this.lbl_EkstraMalzemeGel.Size = new System.Drawing.Size(17, 17);
            this.lbl_EkstraMalzemeGel.TabIndex = 2;
            this.lbl_EkstraMalzemeGel.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_SatilanUrunAd);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(370, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 61);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lbl_SatilanUrunAd
            // 
            this.lbl_SatilanUrunAd.AutoSize = true;
            this.lbl_SatilanUrunAd.BackColor = System.Drawing.Color.Red;
            this.lbl_SatilanUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SatilanUrunAd.Location = new System.Drawing.Point(6, 32);
            this.lbl_SatilanUrunAd.Name = "lbl_SatilanUrunAd";
            this.lbl_SatilanUrunAd.Size = new System.Drawing.Size(17, 17);
            this.lbl_SatilanUrunAd.TabIndex = 2;
            this.lbl_SatilanUrunAd.Text = "0";
            // 
            // TumSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TumSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TumSiparis";
            this.Load += new System.EventHandler(this.TumSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label lbl_SiparisSayisi;
        public System.Windows.Forms.Label lbl_Ciro;
        public System.Windows.Forms.Label lbl_EkstraMalzemeGel;
        public System.Windows.Forms.Label lbl_SatilanUrunAd;
        public System.Windows.Forms.GroupBox groupBox2;
    }
}