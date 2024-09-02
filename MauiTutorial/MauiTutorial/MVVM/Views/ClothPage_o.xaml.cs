using MauiTutorial.MVVM.ViewModels;

namespace MauiTutorial.MVVM.Views;

public partial class ClothPage_o : ContentPage
{
	public ClothPage_o()
	{
		InitializeComponent();
        BindingContext = new ClothViewModel();
    }
}