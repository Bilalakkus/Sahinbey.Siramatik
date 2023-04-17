using Newtonsoft.Json;
using Sahinbey.Siramatik.DTOs.TicketDTOs;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.Services;
using Sahinbey.Siramatik.Utilities;
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
    public partial class FrmEmploye : Form
    {
        public FrmEmploye()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timerListRefresh.Enabled = true;
            lblUserName.Text = ActiveUser.AdSoyad;
            lblKayan.Text = "        Hoş Geldiniz...                                                                   ";
            WaidTicketLoad();
        }
        private async void WaidTicketLoad()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
        }
        private async void timerListRefresh_Tick(object sender, EventArgs e)
        {
            var tickets = await IOCContainer.Resolve<ITicketService>().GetAllAsync(2);
            lblTBekleyen.Text = tickets.Count().ToString();
            listWaidTicket.DataSource = tickets;
            listWaidTicket.DisplayMember = "TicketNo";
            listWaidTicket.ValueMember = "TicketNo";

            //çağrılan bilet sayısı
            lblCagrilan.Text =""+ await IOCContainer.Resolve<IUserService>().UserTotalTransaction(ActiveUser.No);
        }
        private async void btnPersonCall_Click(object sender, EventArgs e)
        {
            CallTicketDto callTicketDto = new CallTicketDto
            {
                GroupId=ActiveMasa.GroupId,
                UserId=ActiveUser.No,
                TableId=ActiveMasa.MasaId
            };
            var tickets = await IOCContainer.Resolve<ITicketService>().CallTicket(callTicketDto);
            txtBiletNo.Text = AddNumaraFirstZero.SifirEkle(Convert.ToInt32(tickets.TicketNo),3);
            //txtGecenSure.Text = (DateTime.Now - tickets.Date).TotalHours + ":" + +(DateTime.Now - tickets.Date).TotalMinutes;// +":" + (DateTime.Now - tickets.Date).TotalSeconds;
            TimeSpan span = DateTime.Now.Subtract(tickets.Date);
            txtGecenSure.Text = AddNumaraFirstZero.SifirEkle(span.Hours) + ":"+ AddNumaraFirstZero.SifirEkle(span.Minutes) + ":" + AddNumaraFirstZero.SifirEkle(span.Seconds);
            txtAlinmaSaati.Text = tickets.Date.ToString();
            txtIslemNo.Text = tickets.GroupName;
        }
    }
}
