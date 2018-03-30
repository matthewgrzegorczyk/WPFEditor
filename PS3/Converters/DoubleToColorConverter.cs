using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PS3.Converters
{
    public class DoubleToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromScRgb(1.0f, (float)(double)values[0], (float)(double)values[1], (float)(double)values[2]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color color = (Color)value;
            return new object[] { (double)color.ScA, (double)color.ScR, (double)color.ScG, (double)color.ScB };
        }
    }
}
