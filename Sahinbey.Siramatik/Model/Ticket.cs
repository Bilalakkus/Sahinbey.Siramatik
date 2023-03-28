using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Model
{
    public class Ticket
    {
        public string TicketNo { get; set; }
        public string GroupName { get; set; }
        public string Header { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int PersonWaiting { get; set; }
    }
}
