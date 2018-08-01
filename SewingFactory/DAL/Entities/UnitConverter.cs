using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    class UnitConverter
    {
        public static string[] LengthUnits = new string[] { "м", "см", "мм" };

        public static double ConvertLength(double sourceValue, string sourceUnit, string destUnit)
        {
            double multiplierSource = Multiplier(sourceUnit);
            double multiplierDest = Multiplier(destUnit);
            return sourceValue * multiplierSource / multiplierDest;
        }

        public static double ToMeters(double sourceValue, string sourceUnit)
        {
            return ConvertLength(sourceValue, sourceUnit, "м");
        }

        public static double Area(double Width, string WidthUnit, double Length, string LengthUnit, string DestUnit)
        {
            return ConvertLength(Width, WidthUnit, DestUnit) * ConvertLength(Length, LengthUnit, DestUnit);
        }

        private static double Multiplier(string unit)
        {
            double multiplier = -1;
            if (unit.ToLower() == "м")
            {
                multiplier = 1;
            }
            else if (unit.ToLower() == "дм")
            {
                multiplier = 0.1;
            }
            else if (unit.ToLower() == "см")
            {
                multiplier = 0.01;
            }
            else if (unit.ToLower() == "мм")
            {
                multiplier = 0.001;
            }
            else
            {
                throw new Exception("wrong unit name " + unit);
            }
            return multiplier;
        }
    }
}
