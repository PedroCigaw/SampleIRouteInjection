namespace SampleIRouteInjection;

public partial class LoginView : ContentPage
{

    public LoginView(RandomItem item)
    {
        //this is constructor is invoked by code and RandomItem is not registered in DI

        InitializeComponent();
    }

	public LoginView()
	{
		InitializeComponent();
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Default");
    }
}