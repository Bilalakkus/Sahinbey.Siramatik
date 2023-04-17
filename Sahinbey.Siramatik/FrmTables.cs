using Newtonsoft.Json;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.DTOs.TableDTOs;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.Services;
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
        HttpClient client = new HttpClient();
        public FrmTables()
        {
            InitializeComponent();
        }
        private async void FrmTables_Load(object sender, EventArgs e)
        {
            int masaId = await IOCContainer.Resolve<ITableService>().IsItHaveTable(Convert.ToInt32(lblUserId.Text));
            if (masaId > 0)
            {
                if (await IOCContainer.Resolve<ITableService>().TablePasiveAsync(masaId))
                    if (await IOCContainer.Resolve<ITableService>().EmployeeExit(Convert.ToInt32(lblUserId.Text)))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı çıkış yapmamış. Oturum kapatılamadı!");
                        return;
                    }

            }

            ListGroup();
        }
        private async void ListGroup()
        {
            var response = await client.GetAsync(Constant.API_SERVICE + "/api/v1/Groups/GetAllGroup");
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
        private async void TableSelect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblUserId.Text == "")
                MessageBox.Show("HATA! Kullanıcı Bulunamadı");
            else if (btn.Text == "")
                MessageBox.Show("HATA! Kullanıcı Bulunamadı");
            var tableId = Convert.ToInt32(btn.Name);//Convert.ToInt32(IOCContainer.Resolve<ITableService>().TableWhereIdAsync(btn.Name));
            if (tableId > 0)
            {
                AddTableMomentsDto addTable = new AddTableMomentsDto
                {
                    TableId = tableId,
                    EmoployeId = Convert.ToInt32(lblUserId.Text)
                };
                if (!await IOCContainer.Resolve<ITableService>().TableActiveAsync(tableId))
                    MessageBox.Show("HATA! Masa Açılamadı!");
                else if (!await IOCContainer.Resolve<ITableService>().AddAsync(addTable))
                    MessageBox.Show("HATA! Masa açılırken işlem hareketi kaydedilemedi");

                FrmEmploye frmEmploye = new FrmEmploye();
                ActiveMasa.MasaId = tableId;
                ActiveMasa.GroupId = Convert.ToInt32(cmbGroup.SelectedValue);
                
                frmEmploye.lblMasaName.Text = btn.Text;
                frmEmploye.Show();
                this.Close();
            }
            else
                MessageBox.Show("HATA! Masa bulunamadı");
        }
        private async void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGroup.SelectedIndex > 0)
            {
                var tableList = await IOCContainer.Resolve<ITableService>().GetByGroupIdAsync(Convert.ToInt32(cmbGroup.SelectedValue));
                if (tableList != null)
                {
                    int i = 0;
                    foreach (var tbl in tableList)
                    {
                        if (i == 0)
                            NewMasaButton(200, 0, tbl, 135, 120);
                        else if (i < 10)
                            NewMasaButton(200, 115 * i, tbl, 135, 120);
                        else if (i < 20)
                            NewMasaButton(350, 115 * (i - 10), tbl, 135, 120);
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
}
