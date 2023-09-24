using MAUIToDoApplication.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.DataServices
{
    public class RestDataService : IRestDataService
    {
        private readonly HttpClient _httpClient;
        public RestDataService()
        {
            _httpClient = new HttpClient();
        }
        public Task AddToDoAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDo>> GetAllToDosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoAsync(ToDo todo)
        {
            throw new NotImplementedException();
        }
    }
}
