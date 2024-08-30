using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiTutorial.MVVM.Models;

namespace MauiTutorial.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person{ get; set; }
        public PersonViewModel()
        {
            Person = new Person()
            {
                Married = "Married"
            };
        }
    }
}
