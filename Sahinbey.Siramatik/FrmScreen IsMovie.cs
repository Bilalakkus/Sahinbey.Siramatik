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
using System.Media;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.Services;
using Sahinbey.Siramatik.DTOs.TicketDTOs;
using System.IO;
using System.Windows.Media;

namespace Sahinbey.Siramatik
{
    public partial class FrmScreenIsMovie : Form
    {
        public FrmScreenIsMovie()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer3.Enabled = true;
            timerPlayer.Enabled = true;
            lblKayan.Text = "        ŞAHİNBEY BELEDİYESİNE HOŞ GELDİNİZ...                                                                   ";
        }
        //private static List<DataScreen> _liste = new List<DataScreen>();
        private async void FrmScreen_Load(object sender, EventArgs e)
        {
            //Play();
            InitializeComponent();
            var player = new MediaPlayer();
            player.Open(new Uri(@"D:\basin-video\Genel Tanıtım - Ocak 2023_1.mp4"));
            player.Play();
        }
        private void Play()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                SoundPlayer player = new SoundPlayer();
                //D:\Dosyalar\KurumYazılımKodları\Kiosk\Sahinbey.Siramatik\Sahinbey.Siramatik\wav\ding.wav
                player.SoundLocation = Path.GetDirectoryName(path) + @"\wav\ding.wav";
                player.Play();
                txtRedCount.Text = "1";
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async void ListLoad()
        {
            try
            {
                var tickets = await IOCContainer.Resolve<ITicketService>().GetAllAsync(2);
                AddList(tickets);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async void CallListLoad()
        {
            var list = await IOCContainer.Resolve<ITicketService>().CallListLoad();
            string beforeTicketName = lblCallFirt.Text;
            ClearCallList();
            foreach (var item in list)
            {
                int i = list.ToList().IndexOf(item);
                if (item.MasaId > 0)
                {
                    var masa = await IOCContainer.Resolve<ITableService>().GetByIdAsync(item.MasaId);
                    if (i == 0)
                    {
                        string newTicketName = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallFirt.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTableFirst.Text = masa.TableName;
                        pnlCallFirst.Visible = true;
                        if (beforeTicketName != newTicketName)
                            Play();
                    }
                    else if (i == 1)
                    {
                        lblCall2.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTable2.Text = masa.TableName;
                        pnlCall2.Visible = true;
                    }
                    else if (i == 2)
                    {
                        lblCall3.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTable3.Text = masa.TableName;
                        pnlCall3.Visible = true;
                    }
                    else if (i == 3)
                    {
                        lblCall4.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTable4.Text = masa.TableName;
                        pnlCall4.Visible = true;
                    }
                    else if (i == 4)
                    {
                        lblCall5.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTable5.Text = masa.TableName;
                        pnlCall5.Visible = true;
                    }
                    else if (i == 5)
                    {
                        lblCall6.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.ticketNo.ToString()), 4);
                        lblCallTable6.Text = masa.TableName;
                        pnlCall6.Visible = true;
                    }
                }
            }
        }
        private void ClearCallList()
        {
            //lblCallFirt.Text = "";
            //lblCall2.Text = "";
            //lblCall3.Text = "";
            //lblCall4.Text = "";
            //lblCall5.Text = "";
            //lblCall6.Text = "";

            //lblCallTableFirst.Text = "";
            //lblCallTable2.Text = "";
            //lblCallTable3.Text = "";
            //lblCallTable4.Text = "";
            //lblCallTable5.Text = "";
            //lblCallTable6.Text = "";

            //pnlCallFirst.Visible = false;
            //pnlCall2.Visible = false;
            //pnlCall3.Visible = false;
            //pnlCall4.Visible = false;
            //pnlCall5.Visible = false;
            //pnlCall6.Visible = false;
        }
        private void AddList(IEnumerable<ResponseTicketDto> list)
        {
            ListClear(list.Count());
            int i = 0;
            foreach (var item in list)
            {
                i = list.ToList().IndexOf(item);
                if (Convert.ToInt32(item.TicketNo.ToString()) < 1000)
                {
                    if (i > 10)
                        return;
                    if (i == 0)
                    {
                        lblList1.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList1.Visible = true;
                    }
                    else if (i == 1)
                    {
                        lblList2.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList2.Visible = true;
                    }
                    else if (i == 2)
                    {
                        lblList3.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList3.Visible = true;
                    }
                    else if (i == 3)
                    {
                        lblList4.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList4.Visible = true;
                    }
                    else if (i == 4)
                    {
                        lblList5.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList5.Visible = true;
                    }
                    else if (i == 5)
                    {
                        lblList6.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList6.Visible = true;
                    }
                    else if (i == 6)
                    {
                        lblList7.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList7.Visible = true;
                    }
                    else if (i == 7)
                    {
                        lblList8.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList8.Visible = true;
                    }
                    else if (i == 8)
                    {
                        lblList9.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList9.Visible = true;
                    }
                    else if (i == 9)
                    {
                        lblList10.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(item.TicketNo.ToString()), 4);
                        pnlList10.Visible = true;
                    }
                }

            };

        }
        private void ListClear(int count)
        {
            if (count == 0)
            {
                pnlList1.Visible = false;
                pnlList2.Visible = false;
                pnlList3.Visible = false;
                pnlList4.Visible = false;
                pnlList5.Visible = false;
                pnlList6.Visible = false;
                pnlList7.Visible = false;
                pnlList8.Visible = false;
                pnlList9.Visible = false;
                pnlList10.Visible = false;
            }
            for (int i = 0; i < count; i++)
            {
                switch (count)
                {
                    case 1:
                        pnlList2.Visible = false;
                        pnlList3.Visible = false;
                        pnlList4.Visible = false;
                        pnlList5.Visible = false;
                        pnlList6.Visible = false;
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 2:
                        pnlList3.Visible = false;
                        pnlList4.Visible = false;
                        pnlList5.Visible = false;
                        pnlList6.Visible = false;
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 3:
                        pnlList4.Visible = false;
                        pnlList5.Visible = false;
                        pnlList6.Visible = false;
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 4:
                        pnlList5.Visible = false;
                        pnlList6.Visible = false;
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 5:
                        pnlList6.Visible = false;
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 6:
                        pnlList7.Visible = false;
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 7:
                        pnlList8.Visible = false;
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 8:
                        pnlList9.Visible = false;
                        pnlList10.Visible = false;
                        break;
                    case 9:
                        pnlList10.Visible = false;
                        break;
                    default:
                        break;
                }
            }
            //lblList1.Text = "";
            //lblList2.Text = "";
            //lblList3.Text = "";
            //lblList4.Text = "";
            //lblList5.Text = "";
            //lblList6.Text = "";
            //lblList7.Text = "";
            //lblList8.Text = "";
            //lblList9.Text = "";
            //lblList10.Text = "";
            //pnlList1.Visible = false;
            //pnlList2.Visible = false;
            //pnlList3.Visible = false;
            //pnlList4.Visible = false;
            //pnlList5.Visible = false;
            //pnlList6.Visible = false;
            //pnlList7.Visible = false;
            //pnlList8.Visible = false;
            //pnlList9.Visible = false;
            //pnlList10.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
            lblSaat.Text = AddNumaraFirstZero.SifirEkle(DateTime.Now.TimeOfDay.Hours) + ":" + AddNumaraFirstZero.SifirEkle(DateTime.Now.TimeOfDay.Minutes) + ":" + AddNumaraFirstZero.SifirEkle(DateTime.Now.TimeOfDay.Seconds);
            lblTarih.Text = DateTime.Now.ToString("D");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (Convert.ToInt16(txtRedCount.Text) > 0 && Convert.ToInt16(txtRedCount.Text) < 10)
            {
                //pnlCallFirst.BackColor = pnlCallFirst.BackColor == Color.Red ? Color.White : Color.Red;
                //txtRedCount.Text = (Convert.ToInt16(txtRedCount.Text) + 1).ToString();
            }
            //else
                //pnlCallFirst.BackColor = Color.White;
        }
        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            ListLoad();
            CallListLoad();

        }


    }
}