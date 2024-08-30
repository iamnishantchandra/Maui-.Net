namespace MauiTutorial;

public partial class INotifyChanged : ContentPage
{
	Models.Employee emp=new Models.Employee();
	public INotifyChanged()
	{
		InitializeComponent();
		emp = new Models.Employee()
		{
			Id = 1,
			Name="Nishant Text",
			Age=29
		};
		BindingContext = emp;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		emp.Id = 2;
		emp.Name = "Chandra Text";
		emp.Age = 30;
    }
}