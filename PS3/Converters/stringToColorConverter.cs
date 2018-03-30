using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PS3.Converters
{
    public class StringToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] colorValues = new byte[3] { 255, 255, 255 };
            Byte.TryParse(values[0] as string, out colorValues[0]);
            Byte.TryParse(values[1] as string, out colorValues[1]);
            Byte.TryParse(values[2] as string, out colorValues[2]);
            return Color.FromArgb(255, colorValues[0], colorValues[1], colorValues[2]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color color = (Color)value;
            return new object[] { (double)color.ScA, (double)color.ScR, (double)color.ScG, (double)color.ScB };
        }
    }
}
