using System.Globalization;

namespace Katsumi.Helpers.Converters
{
    public class ProductPricePerUnitOfMeasureMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var price = values.OfType<decimal>().SingleOrDefault();
            var unitOfMeasure = values.OfType<string>().SingleOrDefault();

            return $"Cena: {price.ToString(culture)} za {unitOfMeasure}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
