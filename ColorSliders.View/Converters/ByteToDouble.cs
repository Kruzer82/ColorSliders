using System;
using System.Globalization;
using System.Windows.Data;

namespace ColorSliders.View.Converters
{

    public class ByteToDouble : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)(byte)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (byte)(double)value;
        }
    }
}
