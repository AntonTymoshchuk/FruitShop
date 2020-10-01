using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace FruitShop.Helpers
{
    public class QuantityConverter : IValueConverter, IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int quantity = System.Convert.ToInt32(values[0]);
            int maxQuantity = System.Convert.ToInt32(values[1]);

            SolidColorBrush greenSolidColorBrush = new SolidColorBrush(Colors.Green);
            SolidColorBrush orangeSolidColorBrush = new SolidColorBrush(Colors.Orange);
            SolidColorBrush redSolidColorBrush = new SolidColorBrush(Colors.Red);

            if (quantity <= maxQuantity && quantity >= maxQuantity / 2)
                return greenSolidColorBrush;
            else if (quantity >= 100 && quantity <= maxQuantity / 2)
                return orangeSolidColorBrush;
            else
                return redSolidColorBrush;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
