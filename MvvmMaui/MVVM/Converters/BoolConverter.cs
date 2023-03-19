using System.Globalization;

namespace MvvmMaui.MVVM.Converters;

public class BoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var answer = value.ToString();
        return answer == "YES";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var boolean = (bool)value;
        return boolean ? "YES" : "NO";
    }
}