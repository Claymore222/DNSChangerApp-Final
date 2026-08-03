namespace DNSChangerApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstSiteler = new ListBox();
            txtYeniSite = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            lblBaslik = new Label();
            lblBilgi = new Label();
            lblOrnek = new Label();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(12, 12);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(460, 30);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "📝 Site Listesi Düzenleyici";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBilgi
            // 
            lblBilgi.Font = new Font("Segoe UI", 9F);
            lblBilgi.ForeColor = Color.FromArgb(180, 180, 180);
            lblBilgi.Location = new Point(12, 48);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(460, 45);
            lblBilgi.TabIndex = 1;
            lblBilgi.Text = "ℹ️ Erişmek istediğiniz sitenin adresini yazın.\r\nÖrnek: discord.com, reddit.com, twitter.com\r\n⚠️ Sadece alan adı yazın, https:// veya www. eklemeyin!";
            // 
            // lstSiteler
            // 
            lstSiteler.BackColor = Color.FromArgb(45, 45, 60);
            lstSiteler.BorderStyle = BorderStyle.None;
            lstSiteler.Font = new Font("Consolas", 11.25F);
            lstSiteler.ForeColor = Color.FromArgb(200, 220, 255);
            lstSiteler.FormattingEnabled = true;
            lstSiteler.ItemHeight = 18;
            lstSiteler.Location = new Point(12, 100);
            lstSiteler.Name = "lstSiteler";
            lstSiteler.Size = new Size(460, 198);
            lstSiteler.TabIndex = 2;
            // 
            // lblOrnek
            // 
            lblOrnek.Font = new Font("Segoe UI", 8.25F);
            lblOrnek.ForeColor = Color.FromArgb(120, 120, 140);
            lblOrnek.Location = new Point(12, 302);
            lblOrnek.Name = "lblOrnek";
            lblOrnek.Size = new Size(460, 18);
            lblOrnek.TabIndex = 3;
            lblOrnek.Text = "Doğru ✅: discord.com   |   Yanlış ❌: https://www.discord.com";
            lblOrnek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYeniSite
            // 
            txtYeniSite.BackColor = Color.FromArgb(45, 45, 60);
            txtYeniSite.BorderStyle = BorderStyle.FixedSingle;
            txtYeniSite.Font = new Font("Segoe UI", 12F);
            txtYeniSite.ForeColor = Color.Gray;
            txtYeniSite.Location = new Point(12, 330);
            txtYeniSite.Name = "txtYeniSite";
            txtYeniSite.Size = new Size(340, 29);
            txtYeniSite.TabIndex = 4;
            txtYeniSite.Text = "örn: discord.com";
            txtYeniSite.Enter += txtYeniSite_Enter;
            txtYeniSite.Leave += txtYeniSite_Leave;
            txtYeniSite.KeyDown += txtYeniSite_KeyDown;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(0, 200, 151);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(358, 328);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(114, 33);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "➕ Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 92, 92);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(12, 380);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(460, 40);
            btnSil.TabIndex = 6;
            btnSil.Text = "🗑️ Seçili Siteyi Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(88, 101, 242);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(12, 435);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(460, 50);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "💾 Kaydet && Uygula";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(484, 500);
            Controls.Add(btnKaydet);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtYeniSite);
            Controls.Add(lblOrnek);
            Controls.Add(lstSiteler);
            Controls.Add(lblBilgi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Site Listesi Düzenleyici";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSiteler;
        private TextBox txtYeniSite;
        private Button btnEkle;
        private Button btnSil;
        private Button btnKaydet;
        private Label lblBaslik;
        private Label lblBilgi;
        private Label lblOrnek;
    }
}
