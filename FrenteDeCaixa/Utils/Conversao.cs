using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Utils
{
    internal static class Conversao
    {
        public static int ConverterIntStr(this string value, int defaultValue = 0)
        {
            int temp;
            if(!int.TryParse(value, out temp))
            {
                return defaultValue;
            }
            return temp;
        }

        public static decimal ConverterDecimalStr(this string value, decimal defaultValue = 0.00m)
        {
            decimal temp;
            if (!decimal.TryParse(value, out temp))
            {
                return defaultValue;
            }
            return temp;
        }
    }
}
