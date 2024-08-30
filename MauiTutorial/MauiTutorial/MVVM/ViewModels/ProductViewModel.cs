using MauiTutorial.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial.MVVM.ViewModels
{
    
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ProductViewModel()
        {
            Product = new Product()
            {
                Title = "Title",
                Description = "Description",
                AvailQty = 5,
                Weight = 100,
                IsPopuplar = true,
                CreatedDate = new DateTime(2024,08,30)
            };

        }
    }
}
