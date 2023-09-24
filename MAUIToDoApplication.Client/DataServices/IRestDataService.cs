using MAUIToDoApplication.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllToDosAsync();
        Task AddToDoAsync(ToDo todo);
        Task UpdateToDoAsync(ToDo todo);
        Task DeleteToDoAsync(Guid id);
    }
}
