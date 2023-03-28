﻿using Newtonsoft.Json;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahinbey.Siramatik
{
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer3.Enabled = true;
            lblKayan.Text = "        ŞAHİNBEY BELEDİYESİNE HOŞ GELDİNİZ...                                                                   ";
        }
        //private static List<DataScreen> _liste = new List<DataScreen>();
        private async void FrmScreen_Load(object sender, EventArgs e)
        {

        }
        private async void ListLoad()
        {
            string host = "https://numaratorapi.sahinbey.bel.tr";
            //string host = "https://localhost:7117";
            string path = "/api/v1/Tickets";
            HttpClient client = new HttpClient();
            CreateTicket query = new CreateTicket
            {
                GroupId = 2
            };
            var json = JsonConvert.SerializeObject(query);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/GetAllGroup";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var jsonResult = await response.Content.ReadAsStringAsync();
            List<DataScreen> tickets = JsonConvert.DeserializeObject<List<DataScreen>>(jsonResult);
            //biletleri ekrana yaz
            AddList(tickets);
        }
        private async void CallListLoad()
        {
            string host = "https://numaratorapi.sahinbey.bel.tr";
            //string host = "https://localhost:7117";
            string path = "/api/v1/Tickets";
            HttpClient client = new HttpClient();
            CreateTicket query = new CreateTicket
            {
                GroupId = 2
            };
            var json = JsonConvert.SerializeObject(query);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/GetAllCallGroup";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var jsonResult = await response.Content.ReadAsStringAsync();
            List<DataScreen> tickets = JsonConvert.DeserializeObject<List<DataScreen>>(jsonResult);
            //biletleri ekrana yaz
            AddCallList(tickets);
        }
        private void AddCallList(List<DataScreen> list)
        {
            ClearCallList();
            foreach (var item in list)
            {
                int i = list.ToList().IndexOf(item);
                if (Convert.ToInt32(item.ticketNo.ToString()) < 1000)
                {
                    if (i == 0)
                    {
                        lblCallFirt.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTableFirst.Text = item.MasaId.ToString();
                        pnlCallFirst.Visible = true;
                    }
                    else if (i == 1)
                    {
                        lblCall2.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTable2.Text = item.MasaId.ToString();
                        pnlCall2.Visible = true;
                    }
                    else if (i == 2)
                    {
                        lblCall3.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTable3.Text = item.MasaId.ToString();
                        pnlCall3.Visible = true;
                    }
                    else if (i == 3)
                    {
                        lblCall4.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTable4.Text = item.MasaId.ToString();
                        pnlCall4.Visible = true;
                    }
                    else if (i == 4)
                    {
                        lblCall5.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTable5.Text = item.MasaId.ToString();
                        pnlCall5.Visible = true;
                    }
                    else if (i == 5)
                    {
                        lblList6.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        lblCallTable6.Text = item.MasaId.ToString();
                        pnlCall6.Visible = true;
                    }
                }

            };

        }
        private void ClearCallList()
        {
            lblCallFirt.Text = "";
            lblCall2.Text = "";
            lblCall3.Text = "";
            lblCall4.Text = "";
            lblCall5.Text = "";
            lblCall6.Text = "";

            lblCallTableFirst.Text = "";
            lblCallTable2.Text = "";
            lblCallTable3.Text = "";
            lblCallTable4.Text = "";
            lblCallTable5.Text = "";
            lblCallTable6.Text = "";

            pnlCallFirst.Visible = false;
            pnlCall2.Visible = false;
            pnlCall3.Visible = false;
            pnlCall4.Visible = false;
            pnlCall5.Visible = false;
            pnlCall6.Visible = false;
        }

        private void AddList(List<DataScreen> list)
        {
            ListClear();
            foreach (var item in list)
            {
                int i = list.ToList().IndexOf(item);
                if (Convert.ToInt32(item.ticketNo.ToString()) < 1000)
                {
                    if (i == 0)
                    {
                        lblList1.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList1.Visible = true;
                    }
                    else if (i == 1)
                    {
                        lblList2.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList2.Visible = true;
                    }
                    else if (i == 2)
                    {
                        lblList3.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList3.Visible = true;
                    }
                    else if (i == 3)
                    {
                        lblList4.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList4.Visible = true;
                    }
                    else if (i == 4)
                    {
                        lblList5.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList5.Visible = true;
                    }
                    else if (i == 5)
                    {
                        lblList6.Text = SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 3);
                        pnlList6.Visible = true;
                    }
                }

            };

        }
        private void ListClear()
        {
            lblList1.Text = "";
            lblList2.Text = "";
            lblList3.Text = "";
            lblList4.Text = "";
            lblList5.Text = "";
            lblList6.Text = "";
            pnlList1.Visible = false;
            pnlList2.Visible = false;
            pnlList3.Visible = false;
            pnlList4.Visible = false;
            pnlList5.Visible = false;
            pnlList6.Visible = false;
        }
        private static void LoadList()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
            lblSaat.Text = SifirEkle(DateTime.Now.TimeOfDay.Hours) + ":" + SifirEkle(DateTime.Now.TimeOfDay.Minutes) + ":" + SifirEkle(DateTime.Now.TimeOfDay.Seconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NewButton(int sutun, int i, string name, int btnHeint, int btnwinth)
        {
            Button dynamicButton = new Button();
            dynamicButton.Height = btnHeint;
            dynamicButton.Width = btnwinth;
            dynamicButton.BackColor = Color.Blue;
            dynamicButton.ForeColor = Color.White;
            dynamicButton.Location = new Point(btnwinth + 500, (i * sutun) + 1000);
            dynamicButton.Text = name;
            dynamicButton.Name = name;
            dynamicButton.Font = new Font("Georgia", 16);
            //dynamicButton.BackgroundImage = Properties.Resources.dashborad1;
            dynamicButton.TextAlign = ContentAlignment.MiddleCenter;
            //dynamicButton.Click += new EventHandler(TableDetail_Click);
            Controls.Add(dynamicButton);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pnlCallFirst.BackColor = pnlCallFirst.BackColor == Color.Red ? Color.White : Color.Red;
            ListLoad();
            CallListLoad();
        }
        private string SifirEkle(int sayi, int rakam = 2)
        {
            if (rakam == 2)
            {
                if (sayi < 10)
                {
                    string newNumber = "0" + sayi;
                    return newNumber;
                }
                else
                    return sayi.ToString();
            }
            if (rakam == 3)
            {
                if (sayi < 10)
                {
                    string newNumber = "00" + sayi;
                    return newNumber;
                }
                else if (sayi < 100)
                {
                    string newNumber = "0" + sayi;
                    return newNumber;
                }
                else
                    return sayi.ToString();
            }
            else
                return sayi + "";
        }
    }
}
