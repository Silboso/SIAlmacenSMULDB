using Microsoft.AspNetCore.Components.WebView.Maui;
using SIAlmacenSMULDB.Data;

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
		string CadenaSQL= "Data Source=Localhost;Initial Catalog=SQLSMulAlmacen;user id=sa;password=123;TrustServerCertificate=True";
        //Cadena de conexion PostGreSQL
		string CadenaPostGreSQL= "Host=localhost;Port=5432;Database=PostGreSQLSMulAlmacen;Username=postgres;Password=123";

	

        builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
