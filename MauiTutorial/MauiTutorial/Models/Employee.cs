using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial.Models
{
    class Employee: INotifyPropertyChanged
    {
        private int id;// { get; set; }
        public int Id { get=>id; set
            {
                id = value;
                OnPropertyChanged();//nameof(Id)
            } }
        public string name { get; set; }
        public string Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged();//nameof(Id)
            }
        }
        public int Salary { get; set; }
        public int age { get; set; }
        public int Age
        {
            get => age; set
            {
                age = value;
                OnPropertyChanged();//nameof(Id)
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
