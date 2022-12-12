namespace PasswodManager;

public partial class RegisterPage : ContentPage
{
    String email = "";
    String pass = "";
    public RegisterPage()
    {
        InitializeComponent();
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
