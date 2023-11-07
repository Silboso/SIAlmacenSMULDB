using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Configuration;
using SIAlmacenSMULDB.Context;
using SIAlmacenSMULDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.LifecycleEvents;

namespace SIAlmacenSMULDB;

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
            });

        //Cadena de conexion SQLSERVER
        string CadenaSQL = "Data Source=Localhost;Initial Catalog=SQLSMulAlmacen;user id=sa;password=123;TrustServerCertificate=True";
        //Cadena de conexion PostGreSQL
        string CadenaPostGreSQL = "Host=localhost;Port=5432;Database=PostGreSQLSMulAlmacen;Username=postgres;Password=123";

        builder.Services.AddDbContext<AlmacenSQLContext>(options =>
        {
            options.UseSqlServer(CadenaSQL);

        });

        builder.Services.AddDbContext<EmpleadosPGSQLContext>(options =>
        {
        	options.UseNpgsql(CadenaPostGreSQL);

        });


        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddBlazorBootstrap();
        
        
        //Pantalla completa 

#if WINDOWS
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddWindows(wndLifeCycleBuilder =>
            {
                wndLifeCycleBuilder.OnWindowCreated(window =>
                {
                    IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                    Microsoft.UI.WindowId win32WindowsId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                    Microsoft.UI.Windowing.AppWindow winuiAppWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(win32WindowsId);
                    if (winuiAppWindow.Presenter is Microsoft.UI.Windowing.OverlappedPresenter p)
                    {
                        p.Maximize();
                        //p.IsResizable = false;
                        //p.IsMaximizable = false;
                        //p.IsMinimizable = false;
                    }
                });
            });
        });
#endif
        //Fin pantalla completa

        return builder.Build();
    }
}
