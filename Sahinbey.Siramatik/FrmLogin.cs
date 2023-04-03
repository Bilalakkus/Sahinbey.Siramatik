using Newtonsoft.Json;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.UserDTOs;
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
                string host = "https://numaratorapi.sahinbey.bel.tr";
                //string host = "https://localhost:7117";
                string path = "/api/v1/Users";
                HttpClient client = new HttpClient();
                QueryUserDto query = new QueryUserDto
                {
                    UserName = txtUser.Text,
                    Password = txtPasword.Text
                };
                var json = JsonConvert.SerializeObject(query);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                string uri = host + path + "/Using";
                HttpResponseMessage response = await client.PostAsync(uri, data);
                var jsonResult = await response.Content.ReadAsStringAsync();
                Users user = JsonConvert.DeserializeObject<Users>(jsonResult);
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
                        frmEmploye.Show();
                        frmEmploye.lblUserId.Text = user.No.ToString();
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
