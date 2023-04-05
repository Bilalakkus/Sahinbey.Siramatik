using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.DTOs.TicketDTOs
{
    public class ResponseTicketDto
    {
        public string TicketNo { get; set; }
        public string GroupName { get; set; }
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int PersonWaiting { get; set; }
    }
}
