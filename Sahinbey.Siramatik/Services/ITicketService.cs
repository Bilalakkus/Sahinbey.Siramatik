using Sahinbey.Siramatik.DTOs.TicketDTOs;
using Sahinbey.Siramatik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public interface ITicketService
    {
        Task<IEnumerable<ResponseTicketDto>> GetAllAsync(int GroupId);
        Task<ResponseTicketDto> CallTicket(CallTicketDto dto);
        Task<IEnumerable<DataScreen>> CallListLoad();
    }
}
