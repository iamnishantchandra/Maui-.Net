using MauiTutorial.Models;

namespace MauiTutorial;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MauiTutorial.Models.Employee emp = new MauiTutorial.Models.Employee()
		{
			Age = 28,
			Name = "Nishant",
			Salary = 50000,
			Id = 1
		};
		//Binding empBinding = new Binding();
		//empBinding.Source = emp;
		//empBinding.Path = "Name";
		//EmployeeLbl.SetBinding(Label.TextProperty, empBinding);

		//BindingContext=emp;

		EmployeeLbl.BindingContext = emp;
		EmployeeLbl.SetBinding(Label.TextProperty, "Name");

    }
}