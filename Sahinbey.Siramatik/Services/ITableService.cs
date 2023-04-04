using Sahinbey.Siramatik.DTOs.TableDTOs;
using Sahinbey.Siramatik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public interface ITableService
    {
        Task<IEnumerable<Table>> GetByGroupIdAsync(int id);
        Task<ResponseTableDto> GetByIdAsync(int id);

        Task<IEnumerable<Table>> GetAllAsync();
        Task<bool> AddAsync(AddTableMomentsDto dto);
        Task<bool> TableActiveAsync(int Id);
        Task<bool> TablePasiveAsync(int Id);
        Task<int> TableWhereIdAsync(string TabloName);
        Task<int> IsItHaveTable(int UserId);
    }
}
