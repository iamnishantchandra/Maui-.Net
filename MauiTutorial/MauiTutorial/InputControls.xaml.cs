using Microsoft.Maui.Controls;

namespace MauiTutorial;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		resultSlider1.Text=Slider1.Value.ToString();
    }

    private void Steper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (Steper1!=null)
        {
            resultSlider1.Text = Steper1.Value.ToString();
        }
    }
}