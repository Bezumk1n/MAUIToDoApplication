using MAUIToDoApplication.API.Data;
using Microsoft.EntityFrameworkCore;

namespace MAUIToDoApplication.API.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            var urls = builder.Configuration.GetSection("ApplicationUrls").GetChildren().Select(q => q.Value).ToArray();
            builder.WebHost.UseUrls(urls);
            
            builder.Services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(builder.Configuration.GetConnectionString("NpgSqlConnection")));
            
            return builder;
        }
    }
}
