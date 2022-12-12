namespace PasswodManager;

public partial class LoginPage : ContentPage
{
    String email = "";
    String pass = "";
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var pmService = new ApiService();
        var uid = await pmService.loginUser(email, pass);
        if (uid != null)
        {
            await SecureStorage.SetAsync("uid", uid);
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Alert", "Login Error, Please try again", "OK");
        }
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var x = (Entry)sender;
        email = x.Text;
    }

    private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
    {
        var x = (Entry)sender;
        pass = x.Text;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }
}