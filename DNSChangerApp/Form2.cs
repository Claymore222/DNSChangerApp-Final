using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DNSChangerApp
{
    public partial class Form2 : Form
    {
        private string blacklistYolu;
        private string placeholderText = "örn: discord.com";

        public Form2(string blacklistDosyaYolu)
        {
            InitializeComponent();
            blacklistYolu = blacklistDosyaYolu;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListeyiYukle();
        }

        private void ListeyiYukle()
        {
            lstSiteler.Items.Clear();

            if (File.Exists(blacklistYolu))
            {
                string[] satirlar = File.ReadAllLines(blacklistYolu);
                foreach (string satir in satirlar)
                {
                    string temiz = satir.Trim();
                    if (!string.IsNullOrEmpty(temiz))
                    {
                        lstSiteler.Items.Add(temiz);
                    }
                }
            }
        }

        private string SiteAdiTemizle(string girdi)
        {
            string temiz = girdi.Trim().ToLower();

            temiz = temiz.Replace("https://", "")
                         .Replace("http://", "")
                         .Replace("www.", "");

            temiz = temiz.TrimEnd('/');

            int slashIndex = temiz.IndexOf('/');
            if (slashIndex > 0)
                temiz = temiz.Substring(0, slashIndex);

            return temiz;
        }

        private void SiteEkle()
        {
            string site = txtYeniSite.Text.Trim();

            if (string.IsNullOrEmpty(site) || site == placeholderText) return;

            site = SiteAdiTemizle(site);

            if (string.IsNullOrEmpty(site)) return;

            if (!site.Contains('.'))
            {
                MessageBox.Show("Geçersiz site adresi!\nÖrnek: discord.com", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (object item in lstSiteler.Items)
            {
                if (item.ToString().Equals(site, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bu site zaten listede!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            lstSiteler.Items.Add(site);

            txtYeniSite.Text = placeholderText;
            txtYeniSite.ForeColor = Color.Gray;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SiteEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSiteler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz siteyi listeden seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string seciliSite = lstSiteler.SelectedItem.ToString();
            DialogResult sonuc = MessageBox.Show($"'{seciliSite}' adresini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                lstSiteler.Items.RemoveAt(lstSiteler.SelectedIndex);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] siteler = new string[lstSiteler.Items.Count];
                for (int i = 0; i < lstSiteler.Items.Count; i++)
                {
                    siteler[i] = lstSiteler.Items[i].ToString();
                }

                File.WriteAllLines(blacklistYolu, siteler);

                Process[] processes = Process.GetProcessesByName("goodbyedpi");
                if (processes.Length > 0)
                {
                    DialogResult sonuc = MessageBox.Show(
                        "Liste kaydedildi!\n\nDeğişikliklerin geçerli olması için servisin yeniden başlatılması gerekiyor.\nŞimdi yeniden başlatılsın mı?",
                        "Başarılı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        ServisYenidenBaslat();
                    }
                }
                else
                {
                    MessageBox.Show("Liste kaydedildi!\n\nServisi açtığınızda yeni liste geçerli olacak.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServisYenidenBaslat()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c sc stop \"GoodbyeDPI\" && sc delete \"GoodbyeDPI\"");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process p = Process.Start(psi);
                p.WaitForExit();

                psi = new ProcessStartInfo("cmd.exe", "/c sc stop \"WinDivert\" && sc delete \"WinDivert\"");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                p = Process.Start(psi);
                p.WaitForExit();

                if (Owner is Form1 anaForm)
                {
                    anaForm.ServisBaslat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis yeniden başlatılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtYeniSite_Enter(object sender, EventArgs e)
        {
            if (txtYeniSite.Text == placeholderText)
            {
                txtYeniSite.Text = "";
                txtYeniSite.ForeColor = Color.White;
            }
        }

        private void txtYeniSite_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniSite.Text))
            {
                txtYeniSite.Text = placeholderText;
                txtYeniSite.ForeColor = Color.Gray;
            }
        }

        private void txtYeniSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SiteEkle();
            }
        }
    }
}
