using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial.MVVM.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AvailQty { get; set; }
        public int Weight { get; set; }
        public bool IsPopuplar { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
