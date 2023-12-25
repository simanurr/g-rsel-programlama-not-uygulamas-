using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int AA_Siniri = 90, BA_Siniri = 85, BB_Siniri = 75, CB_Siniri = 70, CC_Siniri = 60, DC_Siniri = 55, DD_Siniri = 50, FD_Siniri=40;
        double vizeGetirisi=0, finalGetirisi=0, butunlemeGetirisi=0, finalHedefi=0, ButunlemeHedefi=0, ortalama=0, gecmeNotu=0;

        private void txtDevamsizlik_TextChanged(object sender, EventArgs e)
        {
            devamsizlikSayisi = Convert.ToInt16(txtDevamsizlik.Text);
        }

        private void lbGecmeNotu_Click(object sender, EventArgs e)
        {

        }

        string harfNotu;
        private void lbGecmeNotu_TextChanged(object sender, EventArgs e)
        {
            if (devamsizlikSayisi<6) {
                if (secim == "Yonetmelik")
                {
                    if (gecmeNotu >= 90) { harfNotu = "AA"; }
                    else if (gecmeNotu >= 85) { harfNotu = "BA"; }
                    else if (gecmeNotu >= 75) { harfNotu = "BB"; }
                    else if (gecmeNotu >= 70) { harfNotu = "CB"; }
                    else if (gecmeNotu >= 60) { harfNotu = "CC"; }
                    else if (gecmeNotu >= 55) { harfNotu = "DC"; }
                    else if (gecmeNotu >= 50) { harfNotu = "DD"; }
                    else if (gecmeNotu >= 40) { harfNotu = "FD"; }
                    else { harfNotu = "FF"; }
                }
                lbHarfNotu.Text = harfNotu;
            }
            else{
                harfNotu = "F";
                lbHarfNotu.Text = harfNotu;
            }

        }

        private void txtButunleme_TextChanged(object sender, EventArgs e)
        {
            if (txtButunleme.Text == "")
            {
                butunlemeNotu = 0; butunlemeGetirisi = 0;
            }
            else
            {
                butunlemeNotu = Convert.ToInt16(txtButunleme.Text);
                butunlemeGetirisi = butunlemeNotu * 0.6;

            }
            lbButunlemeGetirisi.Text = butunlemeGetirisi.ToString();

            gecmeNotu = vizeGetirisi + butunlemeGetirisi;
            lbGecmeNotu.Text = gecmeNotu.ToString();
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {
            if (txtFinal.Text == "")
            {
                finalNotu = 0; finalGetirisi = 0;
            }
            else
            {
                finalNotu = Convert.ToInt16(txtFinal.Text);
                finalGetirisi = finalNotu * 0.6;

            }
            lbFinalGetirisi.Text = finalGetirisi.ToString();

            ortalama = vizeGetirisi + finalGetirisi;
            lbOrtalama.Text = ortalama.ToString();
            gecmeNotu = ortalama;
            lbGecmeNotu.Text = ortalama.ToString();

            if (ortalama > 59)
            {
                lbUyari.Visible = false;
                txtButunleme.Enabled = false;
                //lbUyari.Text = "Bütünlemeye GİRMEYECEK!";
            }
            else
            {
                lbUyari.Visible = true;
                txtButunleme.Enabled = true;
                //lbUyari.Text = "Bütünlemeye GİRECEK!";
            }
        }

        int vizeNotu, finalNotu,  butunlemeNotu, devamsizlikSayisi=0;
        private void txtVize_TextChanged(object sender, EventArgs e)
        {
            if (txtVize.Text == "")
            {
                vizeNotu = 0;vizeGetirisi = 0;
            }
            else
            {
                vizeNotu = Convert.ToInt16(txtVize.Text);
                vizeGetirisi = vizeNotu * 0.4;
                
            }
            lbVizeGetirisi.Text = vizeGetirisi.ToString();

            finalHedefi = (60 - vizeGetirisi) / 0.6;
            lbFinalHedefi.Text = finalHedefi.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            secim = "Belirlenen";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            btnSinirlariBelirle.Text = "-" + numericUpDown1.Value.ToString();
            degisim = (int)numericUpDown1.Value;
        }

        int AA_SiniriB = 90, BA_SiniriB = 85, BB_SiniriB = 75, CB_SiniriB = 70, CC_SiniriB = 60, DC_SiniriB = 55, DD_SiniriB = 50, FD_SiniriB = 40;
        int degisim = 10;
        string secim = "Yonetmelik";
        private void button1_Click(object sender, EventArgs e)
        {
            AA_SiniriB = AA_Siniri - degisim;
            BA_SiniriB = BA_Siniri - degisim;
            BB_SiniriB = BB_Siniri - degisim;
            CB_SiniriB = CB_Siniri - degisim;
            CC_SiniriB = CC_Siniri - degisim;
            DC_SiniriB = DC_Siniri - degisim;
            DD_SiniriB = DD_Siniri - degisim;
            FD_SiniriB = FD_Siniri - degisim;
            txtAA.Text = AA_SiniriB.ToString();
            txtBA.Text = BA_SiniriB.ToString();
            txtBB.Text = BB_SiniriB.ToString();
            txtCB.Text = CB_SiniriB.ToString();
            txtCC.Text = CC_SiniriB.ToString();
            txtDC.Text = DC_SiniriB.ToString();
            txtDD.Text = DD_SiniriB.ToString();
            txtFD.Text = FD_SiniriB.ToString();
        }
    }
}
