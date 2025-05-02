

using System.Globalization;

namespace LotSizeCalculator.Converters;
public class EnumToBoolConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null)
            return false;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string parameterString = parameter.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        if (Enum.IsDefined(value.GetType(), value))
        {
            object paramValue = Enum.Parse(value.GetType(), parameterString);
            return paramValue.Equals(value);
        }

        return false;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
#pragma warning disable CS8605 // Unboxing a possibly null value.
        if ((bool)value && parameter != null)
        {
            return Enum.Parse(targetType, parameter.ToString());
        }
#pragma warning restore CS8605 // Unboxing a possibly null value.

        return Binding.DoNothing;
    }
}