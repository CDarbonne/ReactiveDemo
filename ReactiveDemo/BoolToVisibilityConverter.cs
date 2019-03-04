using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ReactiveDemo
{
    // If we would like to do value conversion using Binding markup extension,
    // we need to implement the IValueConverter interface.
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // We need to convert True value to Visibility.Visible and False value to
            // Visibility.Collapsed. Then we need to declare the converter as a static resource.
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Our app doesn't need to be able to convert values back, so we won't implement this.
            return Binding.DoNothing;
        }
    }
}
