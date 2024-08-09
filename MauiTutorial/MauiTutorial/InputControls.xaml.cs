using Microsoft.Maui.Controls;
using System.Diagnostics;

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

    private void Switch_HandlerChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Switch_HandlerChanged Text", $"Your Switch { e.Value}", "Ok");
        

    }

    private void UserTextName_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(UserTextName.Text);
        //DisplayAlert("UserTextName Text", $"Your Switch {UserTextName.Text}", "Ok");
    }

    private void UserTextName_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(UserTextName.Text);
        DisplayAlert("UserTextName Text", $"Your Switch {UserTextName.Text}", "Ok");
    }
    private void UserTextEditor_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine("UserTextName.Text" + UserTextEditor.Text);
        DisplayAlert("UserTextName Text", $"Your Switch {UserTextName.Text} and {UserTextEditor.Text}", "Ok");
    }

    private void UserDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        Debug.WriteLine(UserDatePicker);
        DisplayAlert("UserDatePicker Text", $"Your Date {e.OldDate} Changed To {e.NewDate}", "Ok");
    }
}