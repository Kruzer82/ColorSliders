using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ColorSliders.View.Converters
{/// <summary>
/// Not implemented in project.
/// </summary>
    public class RgbValuesToSolidColorBrush : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte red = (byte)values[0];
            byte green = (byte)values[1];
            byte blue = (byte)values[2];

            return new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = value as SolidColorBrush;
            if(brush!=null)
            {
                Color color = brush.Color;

                return new object[3] { color.R, color.G, color.B };
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
