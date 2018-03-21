using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SwitchConverter
{
    public class SwitchToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((bool)(value)) == true)
            {
                return 100;
            }
            else
            {
                return 1;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

           
                if (((double)(value)) == 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
    }
}
