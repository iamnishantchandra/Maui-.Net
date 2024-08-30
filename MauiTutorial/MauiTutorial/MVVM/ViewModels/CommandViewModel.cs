using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiTutorial.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CommandViewModel
    {
        public string searchCommand { get; set; }
        public int First { get; set; }
        public int Second { get; set; }
        public int Result { get; set; }
        public ICommand CommandClick => new Command(ExecuteAlert);
        public ICommand CommandSearch => new Command(CommandParameter);
        public ICommand ResultCommand => new Command(ResultCommandMethod);

        private void ResultCommandMethod(object obj)
        {
            Result = First + Second;
        }
        private void CommandParameter(object obj)
        {
            //App.Current.MainPage.DisplayAlert("Hi", $"{searchCommand}", "Ok");
            App.Current.MainPage.DisplayAlert("Hi", $"{obj}", "Ok");
        }

        private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi", "Nishant", "Ok");
        }
    }
}
