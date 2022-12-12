namespace PasswodManager;

public partial class App : Application
{
	public static PmViewModel vm;
	public App()
	{
		InitializeComponent();
		vm = new PmViewModel();
		MainPage = new NavigationPage(new LoginPage());
	}
}
