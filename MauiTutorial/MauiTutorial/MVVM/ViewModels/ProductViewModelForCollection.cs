using MauiTutorial.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial.MVVM.ViewModels
{
    public class ProductViewModelForCollection
    {
        //public List<string> ProductView { get; set; }
        public List<Product> ProductView { get; set; }
        public ProductViewModelForCollection() {

            //ProductView = new List<string>(){"Samsung","Lg","Windows","Mac"};

            ProductView= new List<Product>();
            ProductView.Add(new Product(){ Title="1st Item", Description="This is des", AvailQty=5, Weight=20,CreatedDate= new DateTime(2024,08,30)});
            ProductView.Add(new Product(){ Title="2nd Item", Description = "This is des", AvailQty =6, Weight=25, CreatedDate= new DateTime(2024,08,29)});
            ProductView.Add(new Product(){ Title="3rd Item", Description = "This is des", AvailQty =7, Weight=10, CreatedDate= new DateTime(2022,08,30)});
            ProductView.Add(new Product(){ Title="4th Item", Description = "This is des", AvailQty =10, Weight=30, CreatedDate= new DateTime(2023,08,30)});
        }
    }
}
