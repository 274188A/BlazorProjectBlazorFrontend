using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class CargoService:ICargoService
    {
        HttpClient _httpClient;
        public CargoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Cargo>> GetCargos()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("http://localhost:21021/api/services/app/cargoservice/getcargos");
            return JsonConvert.DeserializeObject<ListResultDto<Cargo>>(result.Result.ToString()).items.ToList();
        }
    }
}
