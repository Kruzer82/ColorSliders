using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ColorSliders.View.Converters
{
    public class ColorToSolidColorBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = (Color)value;
            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //ignored
            throw new NotImplementedException();
        }
    }
}
