

using System.Globalization;

namespace LotSizeCalculator.Converters;
public class EnumToBoolConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null)
            return false;

        string parameterString = parameter.ToString();
        if (Enum.IsDefined(value.GetType(), value))
        {
            object paramValue = Enum.Parse(value.GetType(), parameterString);
            return paramValue.Equals(value);
        }

        return false;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if ((bool)value && parameter != null)
        {
            return Enum.Parse(targetType, parameter.ToString());
        }

        return Binding.DoNothing;
    }
}