namespace MauiTutorial.MVVM.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        _ = Navigation.PushAsync(new SecondPage(nametext.Text));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        _ = Navigation.PushModalAsync(new ThirdPage());
    }
}