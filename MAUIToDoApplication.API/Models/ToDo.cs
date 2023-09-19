using System.ComponentModel.DataAnnotations;

namespace MAUIToDoApplication.API.Models
{
    public class ToDo
    {
        [Key]
        public Guid Id { get; set; }
        public string? ToDoName { get; set; }
    }
}
