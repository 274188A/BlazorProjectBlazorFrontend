using BlazorProjectBlazor.Models.AccountUpdate;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class UserService : IUserService
    {
        HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var resultApi = await _httpClient.PostJsonAsync<ResultModel>("http://localhost:21021/api/services/app/user/changepassword",changePasswordDto);
            var isSuccess = JsonConvert.DeserializeObject<bool>(resultApi.Result.ToString());
            return isSuccess;
        }

        public Task<UserModel> Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
