using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label8.Text = btnB.Text;
            if (label8.Text == lblCevap.Text)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Tebrikler Dogru Cevap Verdiniz!");
                dogru++;
                lblDogruNo.Text = dogru.ToString();
                
            }
            else
            {
                pictureBox2.Visible = true;
                MessageBox.Show("Maalesef Yanlis Cevap Verdiniz!");
                yanlis++;
                lblYanlisNo.Text = yanlis.ToString();
                
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label8.Text = btnC.Text;
            if (label8.Text == lblCevap.Text)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Tebrikler Dogru Cevap Verdiniz!");
                dogru++;
                lblDogruNo.Text = dogru.ToString();
                
            }
            else
            {
                pictureBox2.Visible = true;
                MessageBox.Show("Maalesef Yanlis Cevap Verdiniz!");
                yanlis++;
                lblYanlisNo.Text = yanlis.ToString();
                
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label8.Text = btnD.Text;
            if (label8.Text == lblCevap.Text)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Tebrikler Dogru Cevap Verdiniz!");
                dogru++;
                lblDogruNo.Text = dogru.ToString();
                
            }
            else
            {
                pictureBox2.Visible = true;
                MessageBox.Show("Maalesef Yanlis Cevap Verdiniz!");
                yanlis++;
                lblYanlisNo.Text = yanlis.ToString();
                
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label8.Text=btnA.Text;
            if(label8.Text == lblCevap.Text)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Tebrikler Dogru Cevap Verdiniz!");
                dogru++;
                lblDogruNo.Text = dogru.ToString();
                
            }
            else
            {
                pictureBox2.Visible = true;
                MessageBox.Show("Maalesef Yanlis Cevap Verdiniz!");
                yanlis++;
                lblYanlisNo.Text = yanlis.ToString();
                
            }

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled=false;
            soruNo++;
            

            if (soruNo == 1)
            {
                lblSoruNo.Text = soruNo.ToString();
                richTextBox1.Text = "Cumhuriyet Hangi Yılda İlan Edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblCevap.Text = "1923";
            }
            else if (soruNo == 2)
            {
                lblSoruNo.Text = soruNo.ToString();
                richTextBox1.Text = "Hangi İlimiz İç Anadolu Bölgemizdedir?";
                btnA.Text = "Bolu";
                btnB.Text = "Zonguldak";
                btnC.Text = "Kayseri";
                btnD.Text = "Mersin";
                lblCevap.Text = "Kayseri";
            }
            else if (soruNo == 3)
            {
                lblSoruNo.Text = soruNo.ToString();
                richTextBox1.Text = "1984 Adlı Kitabın Yazarı Kimdir?";
                btnA.Text = "George Orwell";
                btnB.Text = "Theo Walcott";
                btnC.Text = "Tolstoy";
                btnD.Text = "Dostoyevski";
                lblCevap.Text = "George Orwell";
                btnSonraki.Text = "Sonuçlar";
            }
            else
            {
                
                MessageBox.Show("Dogru Sayisi:" + dogru + "\nYanlis Sayisi:" + yanlis);
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }

        }
    }
}
