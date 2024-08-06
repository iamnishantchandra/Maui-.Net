namespace MauiTutorial;

public partial class CommandDemo : ContentPage
{
	public CommandDemo()
	{
        InitializeComponent();
    }

    private void demoButton_Clicked_1(object sender, EventArgs e)
    {
		DisplayAlert("Demo Page", "Hello World", "Ok");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Option Selected", $"Selected:{e.Value}", "Ok");
    }

    private void Searching_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching Text", $"Your Search:{Searching.Text}", "Ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Swipe", "Your Swipe Text", "Ok");
    }
}