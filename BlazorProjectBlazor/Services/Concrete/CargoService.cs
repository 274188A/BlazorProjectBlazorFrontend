using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class CargoService:ICargoService
    {
        HttpClient _httpClient;
        public ILocalStorageService _localStorageService { get; set; }
        public CargoService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
            _httpClient = httpClient;
            SetAuthorizationHeader();
        }
        public async Task<List<Cargo>> GetCargos()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("http://localhost:21021/api/services/app/cargoservice/getcargos");
            return JsonConvert.DeserializeObject<ListResultDto<Cargo>>(result.Result.ToString()).items.ToList();
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
