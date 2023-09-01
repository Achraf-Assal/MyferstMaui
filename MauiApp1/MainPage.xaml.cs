namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
    }

	public void ChangeIcon(object sender, TappedEventArgs args)
	{
        var font = Icon.FontFamily;
        if (font == "FFR")
        {
            Icon.FontFamily = "FFS";
        }
        else
        {
            Icon.FontFamily = "FFR";
        }
    }


}

