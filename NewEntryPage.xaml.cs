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



}
