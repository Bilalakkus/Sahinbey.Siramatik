using Sahinbey.Siramatik.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public interface IUserService
    {
        Task<IEnumerable<ResponseUserDto>> GetAllAsync();
        Task<ResponseUserDto> GetByIdAsync(string userName, string pass);
        Task<int> UserTotalTransaction(int userId);
    }
}
