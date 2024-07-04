using Microsoft.Extensions.Logging;

namespace MathewBPTres
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
#endif

            string dbPath = FileAccessHelper.GetLocalFilePath("CT.BD");
            builder.Services.AddSingleton<CountriesRepo>(s => ActivatorUtilities.CreateInstance<ChuckNorrisRespositorio>(s, dbPath));

            return builder.Build();
        }
    }
}
