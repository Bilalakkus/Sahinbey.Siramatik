using Newtonsoft.Json;
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
    public partial class FrmTables : Form
    {
        public FrmTables()
        {
            InitializeComponent();
        }

        private void FrmTables_Load(object sender, EventArgs e)
        {
            ListGroup();
        }
        private async void ListGroup()
        {
            ////string host = "https://numaratorapi.sahinbey.bel.tr";
            //string host = "https://localhost:7117";
            //string path = "/api/v1/Groups";
            //HttpClient client = new HttpClient();
            ////CreateTicket query = new CreateTicket
            ////{
            ////    GroupId = 2
            ////};
            //var json = JsonConvert.SerializeObject("");
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //string uri = host + path + "/GetAllGroup";
            //HttpResponseMessage response = await client.PostAsync(uri, data);
            //var jsonResult = await response.Content.ReadAsStringAsync();
            //List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResult);
            //cmbGroup.DataSource = groupList;
            //cmbGroup.DisplayMember = "Name";
            //cmbGroup.ValueMember = "CustomerId";



            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7117/api/v1/Groups/GetAllGroup"); // http://192.168.0.1:915/api/Controller/Object

            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(res);
                groupList.Insert(0, new Group { Id = 1, GroupName = "Şeçiniz" });
                cmbGroup.DataSource = groupList;
                cmbGroup.DisplayMember = "groupName";
                cmbGroup.ValueMember = "Id";
            }
            else
            {
                //await JSRuntime.Current.InvokeAsync<string>("alert", "Warning, the credentials you have entered are incorrect.");
                //return false;
            }
        }
        private void NewMasaButton(int sutun, int i, Table tbl, int btnHeint, int btnwinth)
        {
            Button dynamicButton = new Button();
            dynamicButton.Height = btnHeint;
            dynamicButton.Width = btnwinth;
            
            
            dynamicButton.Location = new Point(i, sutun);
            dynamicButton.Text = tbl.TableName;
            dynamicButton.Name = tbl.Id.ToString();
            dynamicButton.Font = new Font("Georgia", 16);
            dynamicButton.BackgroundImage = Properties.Resources.MasaIcon;
            dynamicButton.BackgroundImageLayout = ImageLayout.Center;
            dynamicButton.TextAlign = ContentAlignment.MiddleCenter;
            dynamicButton.Click += new EventHandler(TableSelect_Click);
            dynamicButton.TextAlign = ContentAlignment.TopCenter;
            dynamicButton.Visible = true;
            if (tbl.IsItActive)
            { 
                dynamicButton.Enabled = false;
                dynamicButton.BackColor = Color.LightCyan;
                dynamicButton.ForeColor = Color.White;
            }
            else
            {
                dynamicButton.Enabled = true;
                dynamicButton.BackColor = Color.Cyan;
                dynamicButton.ForeColor = Color.Black;
            }
            Controls.Add(dynamicButton);
        }
        private void TableSelect_Click(object sender, EventArgs e)

        {

        }

        private async void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:7117/api/v1/Tables/GetById/" + cmbGroup.SelectedValue;
            var response = await client.GetAsync(url); // http://192.168.0.1:915/api/Controller/Object

            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                List<Table> tableList = JsonConvert.DeserializeObject<List<Table>>(res);
                int i = 0;
                
                foreach (var tbl in tableList)
                {
                    
                    if(i==0)
                        NewMasaButton(200, 0, tbl, 135, 120);
                    else if(i<10)
                        NewMasaButton(200, 115 * i, tbl, 135, 120);
                    else if(i<20)
                        NewMasaButton(350, 115 * (i-10), tbl, 135, 120);
                    else if (i < 30)
                        NewMasaButton(500, 115 * (i - 20), tbl, 135, 120);
                    else
                    NewMasaButton(400, 400, tbl, 135, 120);

                    i++;
                }
            }
            else
            {
                //await JSRuntime.Current.InvokeAsync<string>("alert", "Warning, the credentials you have entered are incorrect.");
                //return false;
            }
        }
    }
}
