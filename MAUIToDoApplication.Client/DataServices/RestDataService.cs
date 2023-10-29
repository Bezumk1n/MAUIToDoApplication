﻿using MAUIToDoApplication.Client.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.DataServices
{
    public class RestDataService : IRestDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializeOptions;

        public RestDataService()
        {
            _httpClient = new HttpClient();
            _baseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5100" : "http://localhost:5100";
            _url = $"{_baseAddress}/api";

            _jsonSerializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        }
        public Task AddToDoAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ToDo>> GetAllToDosAsync()
        {
            List<ToDo> toDos = new List<ToDo>();
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                Debug.WriteLine("---> No internet access...");
                return toDos;
            }
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_url}/todo");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    toDos = JsonSerializer.Deserialize<List<ToDo>>(content, _jsonSerializeOptions);
                }
                else 
                {
                    Debug.WriteLine("---> Non http 2xx response...");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"---> Exception: {ex.Message}");
            }
            return toDos;
        }
        public Task UpdateToDoAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }
        public Task DeleteToDoAsync(Guid id)
        {
            throw new NotImplementedException();
        }


    }
}
