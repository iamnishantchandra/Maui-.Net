using MauiTutorial.MVVM.ViewModels;

namespace MauiTutorial.MVVM.Views;

public partial class CommandExample : ContentPage
{
	public CommandExample()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}