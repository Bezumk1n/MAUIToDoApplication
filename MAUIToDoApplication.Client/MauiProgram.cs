﻿using Microsoft.Extensions.Logging;

namespace MAUIToDoApplication.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //services.AddHttpClient<ICommonApiClient, CommonApiClent>();
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}