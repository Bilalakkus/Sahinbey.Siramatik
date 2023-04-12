using Sahinbey.Siramatik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahinbey.Siramatik
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void employeeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTables frmEmploye = new FrmTables();
            frmEmploye.lblUserId.Text = ActiveUser.No.ToString();
            frmEmploye.Show();
           
        }

        private void numaraEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNumaraAl frmNumaraAl = new FrmNumaraAl();
            frmNumaraAl.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void çağrıEkranıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmScreen frmScreen = new FrmScreen();
            frmScreen.Show();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            

        }
    }
}
