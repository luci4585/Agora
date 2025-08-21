using Service.Interfaces;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly HttpClient _httpClient;
        protected readonly JsonSerializerOptions _options;
        private readonly string _endpoint;
        

        public GenericService()
        {
            _endpoint = Properties.Resources.urlApi+ApiEndpoints.GetEndpoint(typeof(T).Name);
            _httpClient = new HttpClient();
            _options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        }


        public async Task<List<T>?> GetAllAsync(string? filtro)
        {
            var response = await _httpClient.GetAsync(_endpoint);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al obtener los datos: {response.StatusCode}");
            }
            return JsonSerializer.Deserialize<List<T>>(content, _options);
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T?> AddAsync(T? entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RestoredAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
