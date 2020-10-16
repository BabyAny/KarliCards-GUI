﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KarliCards_GUI
{

    [ValueConversion(typeof(bool),typeof(bool))]
    public class ReversedBoolConverter:IValueConverter
    {
        public object Convert(object value,Type targetType,object paramter,
            System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value,Type targetType,object parameter,
            System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
