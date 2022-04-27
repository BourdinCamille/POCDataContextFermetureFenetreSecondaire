using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace POCDataContextFermetureFenetreSecondaire.Converters
{
    public class BoolToStringMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string resultat = "Votre sélection est : ";
            if ((bool) values[0] == true && (bool) values[1] == true)
            {
                return resultat + "correcte";
            }
            else 
            {
                return resultat + "fausse";
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
