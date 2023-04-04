using Newtonsoft.Json;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.Services;

namespace Sahinbey.Siramatik
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private async void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtPasword.Text != "" && txtUser.Text != "")
            {
                var user = await IOCContainer.Resolve<IUserService>().GetByIdAsync(txtUser.Text,txtPasword.Text);
                ActiveUser.AdSoyad = user.AdSoyad;
                ActiveUser.No = user.No;
                ActiveUser.KioskPages = user.KioskPages;

                //biletleri ekrana yaz
                if (user.No == null && user.No <= 0)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
                else
                {
                    if (user.KioskPages == 1)//personel vatadaş çağırma yetkisi
                    {
                        FrmTables frmEmploye = new FrmTables();
                        frmEmploye.lblUserId.Text = user.No.ToString();
                        frmEmploye.Show();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yetkiniz Yok");
                    }
                }
            }
            else
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
        }
    }
}
