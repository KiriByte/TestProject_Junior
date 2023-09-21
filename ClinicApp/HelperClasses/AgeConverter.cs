using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicApp.HelperClasses
{
    internal class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateOfBirth)
            {
                int age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now < dateOfBirth.AddYears(age))
                {
                    age--;
                }
                return age;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
