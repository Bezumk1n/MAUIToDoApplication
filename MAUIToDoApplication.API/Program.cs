using MAUIToDoApplication.API.Data;
using MAUIToDoApplication.API.Extensions;
using MAUIToDoApplication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MAUIToDoApplication.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.RegisterServices();
            var app = builder.Build();
            app.RegisterEndPoints();
            app.Run();
        }
    }
}