using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;



            label5.Text = btnb.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btnc.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btnd.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;



            label5.Text= btna.Text;
            if(label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text= dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            btna.Enabled=true;
            btnb.Enabled=true;
            btnc.Enabled=true;
            btnd.Enabled=true;
            btns.Enabled=false;
            pictureBox2.Visible=false;
            pictureBox1.Visible=false;




            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği renk nedir?";
                btna.Text = "yeşil";
                btnb.Text = "kırmızı";
                btnc.Text = "sarı";
                btnd.Text = "siyah";
               label4.Text = "yeşil";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği meyve nedir?";
                btna.Text = "kiraz";
                btnb.Text = "karpuz";
                btnc.Text = "muz";
                btnd.Text = "elma";
                label4.Text = "muz";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği takı nedir?";
                btna.Text = "kolye";
                btnb.Text = "küpe";
                btnc.Text = "yüzük";
                btnd.Text = "bileklik";
                label4.Text = "küpe";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği fastfood restorant neresidir?";
                btna.Text = "burger king";
                btnb.Text = "KFC";
                btnc.Text = "popoyes";
                btnd.Text = "dominos";
                label4.Text = "popoyes";
            }
            if(soruno == 5)
            {
                richTextBox1.Text = "Aysu'nun en çok yapmak istediği spor nedir?";
                btna.Text = "tenis";
                btnb.Text = "voleybol";
                btnc.Text = "basketbol";
                btnd.Text = "futbol";
                label4.Text = "tenis";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği rapçi kimdir?";
                btna.Text = "çakal";
                btnb.Text = "ceza";
                btnc.Text = "uzi";
                btnd.Text = "ezhel";
                label4.Text = "uzi";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği türk dizisi nedir?";
                btna.Text = "Adını Feriha Koydum";
                btnb.Text = "Yaprak Dökümü";
                btnc.Text = "Avrupa Yakası";
                btnd.Text = "Ezel";
                label4.Text = "Adını Feriha Koydum";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği içki nedir?";
                btna.Text = "viski";
                btnb.Text = "bira";
                btnc.Text = "vodka";
                btnd.Text = "şarap";
                label4.Text = "bira";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği ders nedir?";
                btna.Text = "türkçe";
                btnb.Text = "matematik";
                btnc.Text = "biyoloji";
                btnd.Text = "kimya";
                label4.Text = "matematik";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Aysu'nun en sevdiği evcil hayvan nedir?";
                btna.Text = "köpek";
                btnb.Text = "kuş";
                btnc.Text = "balık";
                btnd.Text = "kedi";
                label4.Text = "kedi";
                btns.Text = "SONUÇLAR";

            }
            if (soruno == 11)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;  
                btns.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "  Yanlış:" + yanlis);
            }
        }
    }
}
