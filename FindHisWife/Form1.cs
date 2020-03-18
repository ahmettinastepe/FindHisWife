using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FindHisWife
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<SimpleButton> secimler = new List<SimpleButton>();
        public Form1()
        {
            InitializeComponent();
        }
        private int toplamSure = 0;
        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtYatay.Text) * Convert.ToInt32(txtDikey.Text)) % 2 != 0)
            {
                MessageBox.Show("Bazı sayıların çifti oluşturulamadı. Lütfen başka sayılar deneyin.");
            }
            else
            {
                List<int> sayilar = new List<int>();
                Random rastgeleSayi = new Random();

                for (int i = 1; i <= (Convert.ToInt32(txtYatay.Text) * Convert.ToInt32(txtDikey.Text)) / 2; i++)
                {
                    sayilar.Add(i);
                    sayilar.Add(i);
                }

                for (int i = 0; i < Convert.ToInt32(txtYatay.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(txtDikey.Text); j++)
                    {
                        int gelenSayi = rastgeleSayi.Next(0, sayilar.Count);

                        SimpleButton button = new SimpleButton
                        {
                            Name = sayilar[gelenSayi].ToString(),
                            Text = null,
                            Tag = sayilar[gelenSayi].ToString(),
                            Height = 40,
                            Width = 40,
                            Top = (j) * 40 + 30,
                            Left = (i) * 40 + 20,
                            Font = new Font("Revue BT", 13, FontStyle.Bold)
                        };
                        button.Click += Buton_Click;
                        grpOyunAlani.Controls.Add(button);
                        var secilen = sayilar[gelenSayi];
                        sayilar.Remove(secilen);
                    }
                }

                if (MessageBox.Show("Oyun alanı hazırlandı. Peki sen hazır mısın?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtSure.Time = DateTime.Parse("00:00:00");
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }



        }


        private void Buton_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            if (String.IsNullOrEmpty(buton.Text))
            {
                buton.Text = buton.Name;
                buton.Refresh();
                secimler.Add(buton);
            }

            if (secimler.Count == 2)
            {
                System.Threading.Thread.Sleep(700);
                if (secimler[0].Text == secimler[1].Text)
                {
                    secimler[0].Dispose();
                    secimler[1].Dispose();
                    if (grpOyunAlani.Controls.Count == 0)
                    {
                        MessageBox.Show("Oyun Bitti");
                        timer1.Enabled = false;
                        timer1.Stop();
                    }
                }
                else
                {
                    secimler[0].Text = null;
                    secimler[1].Text = null;
                    txtHataSayisi.Value += 1;
                }
                secimler.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSure.Time = txtSure.Time.AddSeconds(1);
            toplamSure++;
        }

        private void chkCokKolay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCokKolay.Checked)
            {
                txtYatay.Text = "4";
                txtDikey.Text = "3";
            }
        }

        private void chkKolay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKolay.Checked)
            {
                txtYatay.Text = "5";
                txtDikey.Text = "6";
            }
        }

        private void chkOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrta.Checked)
            {
                txtYatay.Text = "7";
                txtDikey.Text = "6";
            }
        }

        private void chkZor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkZor.Checked)
            {
                txtYatay.Text = "8";
                txtDikey.Text = "9";
            }
        }

        private void chkCokZor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCokZor.Checked)
            {
                txtYatay.Text = "10";
                txtDikey.Text = "10";
            }
        }

        private void chkBenBelirleyecegim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBenBelirleyecegim.Checked)
            {
                txtYatay.Enabled = true;
                txtDikey.Enabled = true;
            }
            else
            {
                txtYatay.Enabled = false;
                txtDikey.Enabled = false;
            }
        }

        private void btnOyunuBitir_Click(object sender, EventArgs e)
        {
            if (grpOyunAlani.Controls.Count != 0)
            {
                if (MessageBox.Show("Başlamış bir oyunu iptal edeceksin. Emin misin?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                    txtSure.Time = DateTime.Parse("00:00:00");
                    grpOyunAlani.Controls.Clear();
                    txtYatay.Text = null;
                    txtDikey.Text = null;
                    txtHataSayisi.Text = Convert.ToString(0);
                }
            }
        }
    }
}
