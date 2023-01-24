namespace Sahinbey.Siramatik
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sayfalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numaraAlmaEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çağrıEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sayfalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numaraEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çağrıEkranıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfalarToolStripMenuItem,
            this.numaraAlmaEkranıToolStripMenuItem,
            this.masaEkranıToolStripMenuItem,
            this.çağrıEkranıToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 92);
            this.contextMenuStrip1.Text = "Sayfalar";
            // 
            // sayfalarToolStripMenuItem
            // 
            this.sayfalarToolStripMenuItem.Name = "sayfalarToolStripMenuItem";
            this.sayfalarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sayfalarToolStripMenuItem.Text = "Sayfalar";
            // 
            // numaraAlmaEkranıToolStripMenuItem
            // 
            this.numaraAlmaEkranıToolStripMenuItem.Name = "numaraAlmaEkranıToolStripMenuItem";
            this.numaraAlmaEkranıToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.numaraAlmaEkranıToolStripMenuItem.Text = "Numara Alma Ekranı";
            // 
            // masaEkranıToolStripMenuItem
            // 
            this.masaEkranıToolStripMenuItem.Name = "masaEkranıToolStripMenuItem";
            this.masaEkranıToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.masaEkranıToolStripMenuItem.Text = "Masa Ekranı";
            // 
            // çağrıEkranıToolStripMenuItem
            // 
            this.çağrıEkranıToolStripMenuItem.Name = "çağrıEkranıToolStripMenuItem";
            this.çağrıEkranıToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.çağrıEkranıToolStripMenuItem.Text = "Çağrı Ekranı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfalarToolStripMenuItem1,
            this.raporToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.numaraEkranıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numaraEkranıToolStripMenuItem.Text = "Numara Ekranı";
            this.numaraEkranıToolStripMenuItem.Click += new System.EventHandler(this.numaraEkranıToolStripMenuItem_Click);
            // 
            // employeeEkranıToolStripMenuItem
            // 
            this.employeeEkranıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeEkranıToolStripMenuItem.Image")));
            this.employeeEkranıToolStripMenuItem.Name = "employeeEkranıToolStripMenuItem";
            this.employeeEkranıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeEkranıToolStripMenuItem.Text = "Masa Ekranı";
            this.employeeEkranıToolStripMenuItem.Click += new System.EventHandler(this.employeeEkranıToolStripMenuItem_Click);
            // 
            // çağrıEkranıToolStripMenuItem1
            // 
            this.çağrıEkranıToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("çağrıEkranıToolStripMenuItem1.Image")));
            this.çağrıEkranıToolStripMenuItem1.Name = "çağrıEkranıToolStripMenuItem1";
            this.çağrıEkranıToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.kullanıcıRaporuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıRaporuToolStripMenuItem.Text = "Kullanıcı Raporu";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardToolStripMenuItem.Image")));
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.Text = "Şahinbey Belediyesi";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sayfalarToolStripMenuItem;
        private ToolStripMenuItem numaraAlmaEkranıToolStripMenuItem;
        private ToolStripMenuItem masaEkranıToolStripMenuItem;
        private ToolStripMenuItem çağrıEkranıToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sayfalarToolStripMenuItem1;
        private ToolStripMenuItem numaraEkranıToolStripMenuItem;
        private ToolStripMenuItem employeeEkranıToolStripMenuItem;
        private ToolStripMenuItem çağrıEkranıToolStripMenuItem1;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem kullanıcıRaporuToolStripMenuItem;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}