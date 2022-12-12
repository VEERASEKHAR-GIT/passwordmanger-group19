namespace PasswodManager;

public partial class RegisterPage : ContentPage
{
    String email = "";
    String pass = "";
    public RegisterPage()
    {
        InitializeComponent();
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        var apiService = new ApiService();
        var isDone = await apiService.createUser(email, pass);
        if (isDone)
        {
            await DisplayAlert("Alert", "Register Success, Please login", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
        else
        {
            await DisplayAlert("Alert", "Register Error, Please try again", "OK");
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
