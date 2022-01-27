namespace SampleIRouteInjection;

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



        //I have to now register the view with factory method to create for the default constructor to be resolved.
        //builder.Services.AddTransient<LoginView>(sp => new LoginView());

		return builder.Build();
	}
}
