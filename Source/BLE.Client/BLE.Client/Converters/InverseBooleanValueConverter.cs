using System;
using System.Globalization;
using MvvmCross.Converters;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace BLE.Client.Converters
{
    public class InverseBooleanValueConverter : MvxValueConverter<bool, bool>, IValueConverter
    {
        protected override bool Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return !value;
        }

        protected override bool ConvertBack(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return !value;
        }
    }
}