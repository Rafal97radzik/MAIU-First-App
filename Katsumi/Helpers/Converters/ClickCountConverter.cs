using System.Globalization;

namespace Katsumi.Helpers.Converters
{
    public class ClickCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not int count)
                return "Invalid value";

            return count switch
            {
                0 => "Click me",
                1 => $"Clicked {count} time",
                _ => $"Clicked {count} times"
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
