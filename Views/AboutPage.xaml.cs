namespace Notes.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }



    private async void github(object sender, EventArgs e)
    {
        // URL que deseas abrir
        string url = "https://github.com/Jonalex1804";

        // Verifica si el URL puede ser abierto y luego lo abre
        if (await Launcher.CanOpenAsync(url))
        {
            await Launcher.OpenAsync(url);
        }
    }

    private async void nick(object sender, EventArgs e)
    {
        string url = "https://fortnitetracker.com/";
        if (await Launcher.CanOpenAsync(url))
        {
            await Launcher.OpenAsync(url);
        }
    }

    private async void fn(object sender, EventArgs e)
    {
        string url = "https://fortnitetracker.com/profile/search?q=Jonalex+%E3%83%A1/";
        if (await Launcher.CanOpenAsync(url))
        {
            await Launcher.OpenAsync(url);
        }
    }
}