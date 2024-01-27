using Microsoft.Extensions.Logging;
using RandomUsersApp.Services;
using RandomUsersApp.ViewModels;
using RandomUsersApp.Views;

namespace RandomUsersApp
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

            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddTransient<UserListViewModel>();
            builder.Services.AddTransient<UserListView>();

            builder.Services.AddTransient<UserDetailsViewModel>();
            builder.Services.AddTransient<UserDetailsView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
