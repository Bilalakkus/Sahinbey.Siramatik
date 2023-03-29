using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahinbey.Siramatik
{
    public partial class FrmEmploye : Form
    {
        public FrmEmploye()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblKayan.Text = "        Hoş Geldiniz...                                                                   ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
        }

        private void FrmEmploye_Load(object sender, EventArgs e)
        {
            ListGroup();
        }

        private async void ListGroup()
        {
            //string host = "https://numaratorapi.sahinbey.bel.tr";
            ////string host = "https://localhost:7117";
            //string path = "/api/v1/Groups";
            //HttpClient client = new HttpClient();
            ////CreateTicket query = new CreateTicket
            ////{
            ////    GroupId = 2
            ////};
            ////var json = JsonConvert.SerializeObject("");
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //string uri = host + path + "/GetAll";
            //HttpResponseMessage response = await client.PostAsync(uri, data);
            //var jsonResult = await response.Content.ReadAsStringAsync();
            //List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResult);
            //cmbGroup.DataSource = groupList;
            //cmbGroup.DisplayMember = "Name";
            //cmbGroup.ValueMember = "CustomerId";

        }

        
    }
}
