using MauiTutorial.MVVM.ViewModels;

namespace MauiTutorial.MVVM.Views;

public partial class ClothPage : ContentPage
{
	public ClothPage()
	{
		InitializeComponent();
		BindingContext = new ClothViewModel();
        

    }
}