namespace DNSChangerApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAc = new Button();
            btnKapa = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            açToolStripMenuItem = new ToolStripMenuItem();
            kapaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            lblDurum = new Label();
            chkBaslangic = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAc
            // 
            btnAc.BackColor = Color.FromArgb(0, 200, 151);
            btnAc.FlatAppearance.BorderSize = 0;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnAc.ForeColor = Color.White;
            btnAc.Location = new Point(12, 145);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(460, 90);
            btnAc.TabIndex = 0;
            btnAc.Text = "Aç";
            btnAc.UseVisualStyleBackColor = false;
            btnAc.Click += btnAc_Click;
            // 
            // btnKapa
            // 
            btnKapa.BackColor = Color.FromArgb(255, 92, 92);
            btnKapa.FlatAppearance.BorderSize = 0;
            btnKapa.FlatStyle = FlatStyle.Flat;
            btnKapa.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnKapa.ForeColor = Color.White;
            btnKapa.Location = new Point(12, 241);
            btnKapa.Name = "btnKapa";
            btnKapa.Size = new Size(460, 90);
            btnKapa.TabIndex = 1;
            btnKapa.Text = "Kapa";
            btnKapa.UseVisualStyleBackColor = false;
            btnKapa.Click += btnKapa_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "GoodbyeDPI Manager";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { açToolStripMenuItem, kapaToolStripMenuItem, toolStripMenuItem1, çıkışToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 76);
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(100, 22);
            açToolStripMenuItem.Text = "Aç";
            açToolStripMenuItem.Click += açToolStripMenuItem_Click;
            // 
            // kapaToolStripMenuItem
            // 
            kapaToolStripMenuItem.Name = "kapaToolStripMenuItem";
            kapaToolStripMenuItem.Size = new Size(100, 22);
            kapaToolStripMenuItem.Text = "Kapa";
            kapaToolStripMenuItem.Click += kapaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(97, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(100, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // lblDurum
            // 
            lblDurum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = Color.LightGray;
            lblDurum.Location = new Point(139, 55);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(224, 30);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "DURUM: Bekleniyor...";
            lblDurum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkBaslangic
            // 
            chkBaslangic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkBaslangic.AutoSize = true;
            chkBaslangic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkBaslangic.ForeColor = Color.LightGray;
            chkBaslangic.Location = new Point(139, 483);
            chkBaslangic.Name = "chkBaslangic";
            chkBaslangic.Size = new Size(233, 29);
            chkBaslangic.TabIndex = 3;
            chkBaslangic.Text = "Windows açılınca başlat";
            chkBaslangic.TextAlign = ContentAlignment.MiddleCenter;
            chkBaslangic.UseVisualStyleBackColor = true;
            chkBaslangic.CheckedChanged += chkBaslangic_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(484, 561);
            Controls.Add(chkBaslangic);
            Controls.Add(lblDurum);
            Controls.Add(btnKapa);
            Controls.Add(btnAc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DNSChanger";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAc;
        private Button btnKapa;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kapaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private Label lblDurum;
        private CheckBox chkBaslangic;
        private System.Windows.Forms.Timer timer1;
    }
}
