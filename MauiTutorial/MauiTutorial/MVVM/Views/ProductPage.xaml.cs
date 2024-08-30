
using MauiTutorial.MVVM.ViewModels;
namespace MauiTutorial.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();

		//Product product = new Product()
		//{
		//	Title = "Samsung" ,
        //    Description = "Samsung A4"
		//};

		BindingContext = new ProductViewModel();

	}
}