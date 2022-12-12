namespace PasswodManager;

public partial class NewEntryPage : ContentPage
{
	string appname = "";
	string password = "";
	public NewEntryPage()
	{
		InitializeComponent();
	}
	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		appname = e.NewTextValue;
	}

	private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
	{
		password = e.NewTextValue;
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await App.vm.addNewPassword(appname, password);
		await DisplayAlert("Hurray", "New Application password saved", "View all");
		await Navigation.PopAsync();
	}

}
