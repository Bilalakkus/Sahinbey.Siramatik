using Sahinbey.Siramatik.DTOs.TicketDTOs;
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
    }
}
