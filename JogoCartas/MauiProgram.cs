using JogoCartas.Services;
using Microsoft.Extensions.Logging;

namespace JogoCartas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
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

            builder.Services.AddHttpClient<IBaralhoService, BaralhoService>(cliente =>
            {
                cliente.BaseAddress = new Uri("https://deckofcardsapi.com/api/deck/");
            });
#endif

            return builder.Build();
        }
    }
}
