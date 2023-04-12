using Newtonsoft.Json;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.DTOs.TicketDTOs;
using Sahinbey.Siramatik.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public class TicketService : ITicketService
    {
        public async Task<ResponseTicketDto> CallTicket(CallTicketDto dto)
        {
            string host = Constant.API_SERVICE;
            //string host = Constant.API_SERVICE;
            string path = "/api/v1/Tickets";
            HttpClient client = new HttpClient();
            
            var json = JsonConvert.SerializeObject(dto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/CallTicket";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var jsonResult = await response.Content.ReadAsStringAsync();
            ResponseTicketDto tickets = JsonConvert.DeserializeObject<ResponseTicketDto>(jsonResult);
            //biletleri ekrana yaz
            return tickets;
        }

        public async Task<IEnumerable<ResponseTicketDto>> GetAllAsync(int GroupId)
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
            string uri = host + path + "/GetAllGroup";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var jsonResult = await response.Content.ReadAsStringAsync();
            List<ResponseTicketDto> tickets = JsonConvert.DeserializeObject<List<ResponseTicketDto>>(jsonResult);
            //biletleri ekrana yaz
            return tickets;
        }
    }
}
