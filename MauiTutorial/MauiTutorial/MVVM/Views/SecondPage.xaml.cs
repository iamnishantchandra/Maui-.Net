namespace MauiTutorial.MVVM.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage(string name)
	{
		InitializeComponent();
        usertext.Text = name;

    }
    protected override bool OnBackButtonPressed()
    {
        return true;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ThirdPage());
    }
}