using Newtonsoft.Json;
using Sahinbey.Siramatik.Constants;
using Sahinbey.Siramatik.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public class UserService : IUserService
    {
        HttpClient client = new HttpClient();
        public Task<IEnumerable<ResponseUserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseUserDto> GetByIdAsync(string userName,string pass)
        {
            string host = Constant.API_SERVICE;
            //string host = Constant.API_SERVICE;
            string path = "/api/v1/Users";
            HttpClient client = new HttpClient();
            QueryUserDto query = new QueryUserDto
            {
                UserName = userName,
                Password = pass
            };
            var json = JsonConvert.SerializeObject(query);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = host + path + "/Using";
            HttpResponseMessage response = await client.PostAsync(uri, data);
            var jsonResult = await response.Content.ReadAsStringAsync();
            ResponseUserDto user = JsonConvert.DeserializeObject<ResponseUserDto>(jsonResult);
            return user;
        }

        public async Task<int> UserTotalTransaction(int userId)
        {
            string url = Constant.API_SERVICE + "/api/v1/Users/GetUserTotalTransaction/" + userId;
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode == true)
            {
                string res = await response.Content.ReadAsStringAsync();
                int result = JsonConvert.DeserializeObject<int>(res);
                return result;
            }
            return 0;
        }
    }
}
