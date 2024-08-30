
using MauiTutorial.MVVM.ViewModels;
namespace MauiTutorial.MVVM.Views;
public partial class ConverterExample : ContentPage
{
	public ConverterExample()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();

    }
}