namespace Sahinbey.Siramatik
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sayfalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numaraEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çağrıEkranıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 451);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(906, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfalarToolStripMenuItem1,
            this.raporToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sayfalarToolStripMenuItem1
            // 
            this.sayfalarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numaraEkranıToolStripMenuItem,
            this.employeeEkranıToolStripMenuItem,
            this.çağrıEkranıToolStripMenuItem1});
            this.sayfalarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sayfalarToolStripMenuItem1.Image")));
            this.sayfalarToolStripMenuItem1.Name = "sayfalarToolStripMenuItem1";
            this.sayfalarToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.sayfalarToolStripMenuItem1.Text = "Sayfalar";
            // 
            // numaraEkranıToolStripMenuItem
            // 
            this.numaraEkranıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("numaraEkranıToolStripMenuItem.Image")));
            this.numaraEkranıToolStripMenuItem.Name = "numaraEkranıToolStripMenuItem";
            this.numaraEkranıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.numaraEkranıToolStripMenuItem.Text = "Numara Ekranı";
            this.numaraEkranıToolStripMenuItem.Click += new System.EventHandler(this.numaraEkranıToolStripMenuItem_Click);
            // 
            // employeeEkranıToolStripMenuItem
            // 
            this.employeeEkranıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeEkranıToolStripMenuItem.Image")));
            this.employeeEkranıToolStripMenuItem.Name = "employeeEkranıToolStripMenuItem";
            this.employeeEkranıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeeEkranıToolStripMenuItem.Text = "Masa Ekranı";
            this.employeeEkranıToolStripMenuItem.Click += new System.EventHandler(this.employeeEkranıToolStripMenuItem_Click);
            // 
            // çağrıEkranıToolStripMenuItem1
            // 
            this.çağrıEkranıToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("çağrıEkranıToolStripMenuItem1.Image")));
            this.çağrıEkranıToolStripMenuItem1.Name = "çağrıEkranıToolStripMenuItem1";
            this.çağrıEkranıToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.çağrıEkranıToolStripMenuItem1.Text = "Çağrı Ekranı";
            this.çağrıEkranıToolStripMenuItem1.Click += new System.EventHandler(this.çağrıEkranıToolStripMenuItem1_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıRaporuToolStripMenuItem,
            this.dashBoardToolStripMenuItem});
            this.raporToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporToolStripMenuItem.Image")));
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // kullanıcıRaporuToolStripMenuItem
            // 
            this.kullanıcıRaporuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıRaporuToolStripMenuItem.Image")));
            this.kullanıcıRaporuToolStripMenuItem.Name = "kullanıcıRaporuToolStripMenuItem";
            this.kullanıcıRaporuToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kullanıcıRaporuToolStripMenuItem.Text = "Kullanıcı Raporu";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardToolStripMenuItem.Image")));
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dashBoardToolStripMenuItem.Text = "Dash Board";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 421);
            this.panel1.TabIndex = 6;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Master";
            this.Text = "Şahinbey Belediyesi";
            this.Load += new System.EventHandler(this.Master_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sayfalarToolStripMenuItem1;
        private ToolStripMenuItem numaraEkranıToolStripMenuItem;
        private ToolStripMenuItem employeeEkranıToolStripMenuItem;
        private ToolStripMenuItem çağrıEkranıToolStripMenuItem1;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem kullanıcıRaporuToolStripMenuItem;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private Panel panel1;
    }
}



