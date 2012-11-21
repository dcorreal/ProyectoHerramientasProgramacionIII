using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace ActividadesProgramadas.Movil
{
    public class Convertidor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Reunion":
                    return "/images/imagen.png";
                case "Deporte":
                    return "/images/deporte.jpg";
                default:
                    return "";
            }
    
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {


            throw new NotImplementedException();
        }
    }
}
