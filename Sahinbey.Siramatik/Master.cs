using Sahinbey.Siramatik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahinbey.Siramatik
{
    public partial class Master : Form
    {
        private int childFormNumber = 0;
        public Master()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form FrmNumaraAl = new Form();
            FrmNumaraAl.ShowDialog();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void numaraEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNumaraAl frmNumaraAl = new FrmNumaraAl();
            frmNumaraAl.Show();
        }

        private void employeeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTables frmTables = new FrmTables();
            frmTables.lblUserId.Text = ActiveUser.No.ToString();
            frmTables.Show();
        }

        private void çağrıEkranıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmScreen frmScreen = new FrmScreen();
            frmScreen.Show();
        }

        private void Master_Load(object sender, EventArgs e)
        {

            
            //if (ActiveUser.AdSoyad == null)
            //{
            //    FrmLogin login = new FrmLogin();
            //    login.ShowDialog();

            //}
            string bilgisayarAdi = Dns.GetHostName();
            //label1.Text = "Bilgisayar Adı: " + bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            
            if (ipAdresi != "192.168.3.240")
            {
                FrmScreen frmScreen = new FrmScreen();
                frmScreen.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else if (ipAdresi != "10.10.10.27")
            {
                FrmScreenIsMovie frmScreen = new FrmScreenIsMovie();
                frmScreen.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                FrmNumaraAl frmNumara = new FrmNumaraAl();
                frmNumara.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            //label2.Text = "IP Adresi " + ipAdresi;
            

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Dikkat ! Programı Kapatmak Üzeresiniz..\n Kapatmayı Onaylıyor musunuz ?",
            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
