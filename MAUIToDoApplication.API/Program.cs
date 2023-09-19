using MAUIToDoApplication.API.Data;
using Microsoft.EntityFrameworkCore;

namespace MAUIToDoApplication.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(opt => 
                opt.UseNpgsql(builder.Configuration.GetConnectionString("NpgSqlConnection")));

            var app = builder.Build();
            //app.UseHttpsRedirection();
            app.Run();
        }
    }
}