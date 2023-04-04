using Newtonsoft.Json;
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
            lblUserName.Text = ActiveUser.AdSoyad;
            lblKayan.Text = "        Hoş Geldiniz...                                                                   ";
            WaidTicketLoad();
        }
        private  async void WaidTicketLoad()
        {
            var tickets = await IOCContainer.Resolve<ITicketService>().GetAllAsync(2);
            listWaidTicket.DataSource = tickets;
            listWaidTicket.DisplayMember = "TicketNo";
            listWaidTicket.ValueMember = "TicketNo";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
        }
    }
}
