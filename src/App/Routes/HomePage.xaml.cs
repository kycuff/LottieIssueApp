using App.Resources.Styles;

namespace App.Routes;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	async void Button_Clicked_1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AnimationPage());
	}

	void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		Application.Current!.Resources = themeSwitch.IsToggled ? new DarkTheme() : new LightTheme();
	}
}