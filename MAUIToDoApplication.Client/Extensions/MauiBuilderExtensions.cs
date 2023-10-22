using MAUIToDoApplication.Client.DataServices;
using MAUIToDoApplication.Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.Extensions
{
    public static class MauiBuilderExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IRestDataService, RestDataService>();

            builder.Services.AddSingleton<MainPageVM>();
            builder.Services.AddSingleton<MainPage>();

            return builder;
        }
    }
}
