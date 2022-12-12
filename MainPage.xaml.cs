namespace PasswodManager;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = App.vm;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewEntryPage());
	}
}

