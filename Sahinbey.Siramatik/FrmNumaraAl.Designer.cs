namespace Sahinbey.Siramatik
{
    partial class FrmNumaraAl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNumaraAl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOncelikli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKayan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEmlak = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnOncelikli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnOncelikli
            // 
            this.btnOncelikli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOncelikli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOncelikli.BackgroundImage")));
            this.btnOncelikli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOncelikli.FlatAppearance.BorderSize = 0;
            this.btnOncelikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnOncelikli.ForeColor = System.Drawing.Color.White;
            this.btnOncelikli.Location = new System.Drawing.Point(5, 12);
            this.btnOncelikli.Name = "btnOncelikli";
            this.btnOncelikli.Size = new System.Drawing.Size(197, 192);
            this.btnOncelikli.TabIndex = 6;
            this.btnOncelikli.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOncelikli.UseVisualStyleBackColor = true;
            this.btnOncelikli.Click += new System.EventHandler(this.btnOncelikli_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(257, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lütfen işlem yapmak istediğiniz gruptan numara alınız.";
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(282, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "ŞAHİNBEY BELEDİYESİ";
            // 
            // lblKayan
            // 
            this.lblKayan.AutoSize = true;
            this.lblKayan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKayan.Location = new System.Drawing.Point(12, 15);
            this.lblKayan.Name = "lblKayan";
            this.lblKayan.Size = new System.Drawing.Size(0, 30);
            this.lblKayan.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblKayan);
            this.groupBox2.Location = new System.Drawing.Point(0, 1178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEmlak
            // 
            this.btnEmlak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmlak.BackgroundImage")));
            this.btnEmlak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmlak.FlatAppearance.BorderSize = 0;
            this.btnEmlak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnEmlak.ForeColor = System.Drawing.Color.White;
            this.btnEmlak.Location = new System.Drawing.Point(204, 293);
            this.btnEmlak.Name = "btnEmlak";
            this.btnEmlak.Size = new System.Drawing.Size(703, 176);
            this.btnEmlak.TabIndex = 4;
            this.btnEmlak.Text = "Emlak Beyan";
            this.btnEmlak.UseVisualStyleBackColor = true;
            this.btnEmlak.Click += new System.EventHandler(this.btnEmlak_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(204, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(703, 176);
            this.button4.TabIndex = 6;
            this.button4.Text = "Muhasebe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(204, 748);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(703, 176);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sosyal Yardım İşlemleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(204, 972);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(703, 176);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sosyal Market";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // FrmNumaraAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(941, 1232);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEmlak);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNumaraAl";
            this.Text = "Şahibey Belediyesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblKayan;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox2;
        private Button btnEmlak;
        private Button btnOncelikli;
        private Button button4;
        private Button button5;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}