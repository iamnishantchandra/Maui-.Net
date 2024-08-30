using MauiTutorial.MVVM.ViewModels;

namespace MauiTutorial.MVVM.Views;

public partial class BindCollectionView : ContentPage
{
	public BindCollectionView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModelForCollection();
	}
}