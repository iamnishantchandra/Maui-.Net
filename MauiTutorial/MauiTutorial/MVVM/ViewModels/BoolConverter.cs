using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial.MVVM.ViewModels
{
    public class BoolConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string married = value.ToString();

            if (married != null && married == "Married") { return true; }
            return false;

        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var boolean=(bool)value;
            if (boolean)
            {
                return "Married";
            }
            return "NotMarried";
        }
    }
}
