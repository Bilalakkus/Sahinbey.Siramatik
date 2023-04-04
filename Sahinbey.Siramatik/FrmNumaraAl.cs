using Newtonsoft.Json;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.Model;
using Sahinbey.Siramatik.Utilities;
using System.Drawing.Printing;
using System.Text;

namespace Sahinbey.Siramatik
{
    public partial class FrmNumaraAl : Form
    {
        Ticket _ticket = new Ticket();
        public FrmNumaraAl()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblKayan.Text = "        Þahinbey Belediyesine Hoþ Geldiniz...                                                                   ";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void OnPrintDocument(object sender, PrintPageEventArgs e)
        {
            string dateTime = _ticket.Date + " " + _ticket.Time;
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            Pen blackPen = new Pen(Color.Black, 1);
            PointF point1 = new PointF(0, 0);
            PointF point2 = new PointF(0, 0);
            //e.Graphics.DrawRectangle(Pens.Black, 20, 20, 200, 200);
            e.Graphics.DrawString(_ticket.Header, new Font("Verdana", 12), Brushes.Black, 0, 1 + 24);
            e.Graphics.DrawString("HOÞ GELDÝNÝZ", new Font("Verdana", 12), Brushes.Black, 39, 1 + 48);
            e.Graphics.DrawString(_ticket.GroupName, new Font("Verdana", 12), Brushes.Black, 39, 1 + 72);
            //e.Graphics.DrawLine(blackPen, point1,point2);
            e.Graphics.DrawString(_ticket.TicketNo, new Font("Verdana", 48), Brushes.Black, 28, 1 + 124);
            e.Graphics.DrawString(dateTime, new Font("Verdana", 9), Brushes.Black, 0, 1 + 234);
            e.Graphics.DrawString("Bekleyen Kiþi Sayýsý :"+_ticket.PersonWaiting, new Font("Verdana", 9), Brushes.Black, 0, 1 + 244);
            //e.Graphics.DrawString("Hoþ Geldiniz!", new Font("Verdana", 9), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 72);
        }

        private async void btnEmlak_Click(object sender, EventArgs e)
        {
            string host = Constant.API_SERVICE;
            //string host = Constant.API_SERVICE;
            string path = "/api/v1/Tickets";
            HttpClient client = new HttpClient();
            CreateTicket query = new CreateTicket
            {
                GroupId = 2
            };
            var json = JsonConvert.SerializeObject(query);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/Create";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var result = await response.Content.ReadAsStringAsync();
            var ticket = JsonConvert.DeserializeObject<Ticket>(result);
            _ticket.TicketNo = ticket.TicketNo;
            _ticket.Date = ticket.Date;
            _ticket.Time = ticket.Time;
            _ticket.Header = ticket.Header;
            _ticket.PersonWaiting = ticket.PersonWaiting;
            _ticket.GroupName = ticket.GroupName;
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(OnPrintDocument);
            try
            {
                PD.Print();
            }
            catch
            {
                Console.WriteLine("Yazýcý çýktýsý alýnamýyor...");
            }
            finally
            {
                PD.Dispose();
            }
        }

        private async void btnOncelikli_Click(object sender, EventArgs e)
        {
            string host = Constant.API_SERVICE;
            //string host = Constant.API_SERVICE;
            string path = "/api/v1/Tickets";
            HttpClient client = new HttpClient();
            CreateTicket query = new CreateTicket
            {
                GroupId = 3
            };
            var json = JsonConvert.SerializeObject(query);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/Create";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var result = await response.Content.ReadAsStringAsync();
            var ticket = JsonConvert.DeserializeObject<Ticket>(result);
            _ticket.TicketNo = ticket.TicketNo;
            _ticket.Date = ticket.Date;
            _ticket.Time = ticket.Time;
            _ticket.Header = ticket.Header;
            _ticket.PersonWaiting = ticket.PersonWaiting;
            _ticket.GroupName = ticket.GroupName;
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(OnPrintDocument);
            try
            {
                PD.Print();
            }
            catch
            {
                Console.WriteLine("Yazýcý çýktýsý alýnamýyor...");
            }
            finally
            {
                PD.Dispose();
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
