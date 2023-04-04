using Newtonsoft.Json;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.DTOs.TableDTOs;
using Sahinbey.Siramatik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public class TableService : ITableService
    {
        HttpClient client = new HttpClient();
        public async Task<bool> AddAsync(AddTableMomentsDto dto)
        {
            try
            {
                //string host = Constant.API_SERVICE + "/;
                string host = Constant.API_SERVICE;
                string path = "/api/v1/EmployeeTableMoments";
                AddTableMomentsDto query = new AddTableMomentsDto
                {
                    TableId = dto.TableId,
                    EmoployeId = dto.EmoployeId
                };
                var json = JsonConvert.SerializeObject(query);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                string uri = host + path + "/Create";
                HttpResponseMessage response = await client.PostAsync(uri, data);
                var result = await response.Content.ReadAsStringAsync();
                bool process = JsonConvert.DeserializeObject<bool>(result);
                return process;
            }
            catch
            {
                return false;
            }
        }
        public Task<IEnumerable<Table>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Table>> GetByGroupIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseTableDto> GetByIdAsync(int id)
        {
            string url = Constant.API_SERVICE + "/api/v1/Tables/GetById/" + id;
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                ResponseTableDto table = JsonConvert.DeserializeObject<ResponseTableDto>(res);
                return table;
            }
            else
                throw new ArgumentException("Kayıt bulunamadı");
        }
        public async Task<int> IsItHaveTable(int UserId)
        {
            string url = Constant.API_SERVICE + "/api/v1/EmployeeTableMoments/GetIsItHaveTable/" + UserId;
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                string masaId = JsonConvert.DeserializeObject<string>(res);

                return Convert.ToInt32(masaId);
            }
            else
                return 0;
        }
        public async Task<bool> TableActiveAsync(int Id)
        {
            string url = Constant.API_SERVICE + "/api/v1/Tables/GetIsActive/" + Id;
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(res);
                if (result)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public async Task<bool> TablePasiveAsync(int Id)
        {
            string url = Constant.API_SERVICE + "/api/v1/Tables/GetIspasive/" + Id;
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(res);
                if (result)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public async Task<int> TableWhereIdAsync(string TabloName)
        {
            string url = Constant.API_SERVICE + "/api/v1/Tables/GetWhereId/" + TabloName;
            var response = await client.GetAsync(url); 

            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                string masaId = JsonConvert.DeserializeObject<string>(res);

                return Convert.ToInt32(masaId);
            }
            else
                return 0;
        }
    }
}