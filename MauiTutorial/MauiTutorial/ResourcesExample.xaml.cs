using System.Text.Json;

namespace MauiTutorial;

public partial class ResourcesExample : ContentPage
{
	public ResourcesExample()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }
    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("Employee.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();

        Employee e = System.Text.Json.JsonSerializer.Deserialize<Employee>(contents);
    }
}
public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}