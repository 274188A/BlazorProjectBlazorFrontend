using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Northwİnd.Blazor.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Blazor.Extensions.Storage;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class AuthService : IAuthService
    {
        HttpClient _httpClient;
        public ILocalStorageService _localStorageService { get; set; }
        public bool IsLoogedIn { get; set; }
        public AuthService( HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public async Task<UserModel> Login(LoginModel loginModel)
        {
            var responseApi = await _httpClient.PostJsonAsync<ResultModel>("http://localhost:21021/api/TokenAuth/Authenticate", loginModel);
            var response = JsonConvert.DeserializeObject<TokenModel>(responseApi.Result.ToString());
            if (!string.IsNullOrEmpty(response.AccessToken))
            {
                await _localStorageService.SetItemAsync("token", response.AccessToken);  
                await SetAuthorizationHeader();

                var responseApiUser = await _httpClient.GetJsonAsync<ResultModel>("http://localhost:21021/api/services/app/User/Get?Id="+ response.UserId);
                var loginUser = JsonConvert.DeserializeObject<UserModel>(responseApiUser.Result.ToString());
                await _localStorageService.SetItemAsync("loginUser", loginUser);

                IsLoogedIn = true;
                return loginUser;
            }
            return new UserModel { };
        }

        public async Task Logout()
        {
            await _localStorageService.RemoveItemAsync("token");
            IsLoogedIn = false;

        }

        private async Task SetAuthorizationHeader()
        {
            if (!_httpClient.DefaultRequestHeaders.Contains(name: "Authorization"))
            {
                var token = await _localStorageService.GetItemAsync<string>(key: "token");                
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "Bearer", parameter: token);
            }
        }

    }
}
