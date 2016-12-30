using System;

namespace RWD.Toolbox.Conversion
{
    /// <summary>
    /// Converts Temperature between US and Metric.
    /// </summary>
    public static class Temperature
    {

        // TODO Add Calvin
        // uodate unit test


        /// <summary>
        /// Convert Celcius To Fahrenheit
        /// </summary>
        /// <param name="celcius">Celcius as <see cref="Nullable{Double}"/></param>
        /// <returns>Fahrenheit as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Fahrenheit = 1.8 (or 9/5) * Celcius + 32</remarks>
        public static double? ConvertCelciusToFahrenheit(double? celcius)
        {
            double? fahrenheit = null;
            if (celcius != null)
            {
                fahrenheit = 9.0 / 5.0 * celcius + 32;

                if (double.IsInfinity(fahrenheit.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return fahrenheit;
        }

        /// <summary>
        /// Convert Fahrenheit To Celcius
        /// </summary>
        /// <param name="fahrenheit">Fahrenheit as <see cref="Nullable{Double}"/></param>
        /// <returns>Celcius as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Celcius = (Fahrenheit - 32) * .5556 (or 5/9)</remarks>
        public static double? ConvertFahrenheitToCelcius(double? fahrenheit)
        {
            double? celcius = null;
            if (fahrenheit != null)
            {
                celcius = (fahrenheit - 32) * 5.0 / 9.0;

                if (double.IsInfinity(celcius.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return celcius;
        }

    }
}
