namespace BilgiYarismasiApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblDogruNo = new System.Windows.Forms.Label();
            this.lblYanlisNo = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(503, 152);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Bilgi Yarışmamıza Hoş Geldiniz!\n\nBaşlamak İçin Sonraki Butonuna Basınız!\n";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(540, 35);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(59, 16);
            this.lblSoru.TabIndex = 1;
            this.lblSoru.Text = "Soru No:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(552, 62);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(47, 16);
            this.lblDogru.TabIndex = 2;
            this.lblDogru.Text = "Doğru:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(552, 93);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(47, 16);
            this.lblYanlis.TabIndex = 3;
            this.lblYanlis.Text = "Yanlış:";
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(605, 35);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(14, 16);
            this.lblSoruNo.TabIndex = 4;
            this.lblSoruNo.Text = "0";
            // 
            // lblDogruNo
            // 
            this.lblDogruNo.AutoSize = true;
            this.lblDogruNo.Location = new System.Drawing.Point(605, 62);
            this.lblDogruNo.Name = "lblDogruNo";
            this.lblDogruNo.Size = new System.Drawing.Size(14, 16);
            this.lblDogruNo.TabIndex = 5;
            this.lblDogruNo.Text = "0";
            // 
            // lblYanlisNo
            // 
            this.lblYanlisNo.AutoSize = true;
            this.lblYanlisNo.Location = new System.Drawing.Point(605, 93);
            this.lblYanlisNo.Name = "lblYanlisNo";
            this.lblYanlisNo.Size = new System.Drawing.Size(14, 16);
            this.lblYanlisNo.TabIndex = 6;
            this.lblYanlisNo.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(450, 308);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(44, 16);
            this.lblCevap.TabIndex = 7;
            this.lblCevap.Text = "label7";
            this.lblCevap.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(12, 170);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(239, 34);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Location = new System.Drawing.Point(276, 170);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(239, 33);
            this.btnB.TabIndex = 10;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Location = new System.Drawing.Point(12, 210);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(239, 33);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Location = new System.Drawing.Point(276, 210);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(239, 33);
            this.btnD.TabIndex = 12;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(521, 126);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(138, 38);
            this.btnSonraki.TabIndex = 13;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 329);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblYanlisNo);
            this.Controls.Add(this.lblDogruNo);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label lblDogruNo;
        private System.Windows.Forms.Label lblYanlisNo;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

