
using System;

namespace RWD.Toolbox.Conversion
{
    /// <summary>
    /// Converts Temperature between US and Metric.
    /// </summary>
    public static class Temperature
    {

        // TODO Add Calvin
        // update unit test


        /// <summary>
        /// Convert Celsius To Fahrenheit
        /// </summary>
        /// <param name="celsius">Celsius as <see cref="Nullable{Double}"/></param>
        /// <returns>Fahrenheit as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Fahrenheit = 1.8 (or 9/5) * Celsius + 32</remarks>
        public static double? ConvertCelsiusToFahrenheit(double? celsius)
        {
            double? fahrenheit = null;
            if (celsius != null)
            {
                fahrenheit = 9.0 / 5.0 * celsius + 32;

                if (double.IsInfinity(fahrenheit.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return fahrenheit;
        }

        /// <summary>
        /// Convert Fahrenheit To Celsius
        /// </summary>
        /// <param name="fahrenheit">Fahrenheit as <see cref="Nullable{Double}"/></param>
        /// <returns>Celsius as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Celsius = (Fahrenheit - 32) * .5556 (or 5/9)</remarks>
        public static double? ConvertFahrenheitToCelsius(double? fahrenheit)
        {
            double? celsius = null;
            if (fahrenheit != null)
            {
                celsius = (fahrenheit - 32) * 5.0 / 9.0;

                if (double.IsInfinity(celsius.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return celsius;
        }

        public static double? ConvertFahrenheitToKelvin(double? fahrenheit)
        {
            double? kelvin = null;
            if (fahrenheit != null)
            {
                kelvin = ConvertFahrenheitToCelsius(fahrenheit) + 273.15;

                if (double.IsInfinity(kelvin.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return kelvin;
        }

        public static double? ConvertCelsiusToKelvin(double? celsius)
        {
            double? kelvin = null;
            if (celsius != null)
            {
                kelvin = celsius + 273.15;

                if (double.IsInfinity(kelvin.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return kelvin;
        }

        public static double? ConvertKelvinToFahrenheit(double? kelvin)
        {
            double? fahrenheit = null;
            if (kelvin != null)
            {
                var celsius = kelvin - 273.15;
                fahrenheit = ConvertCelsiusToFahrenheit(celsius);

                if (double.IsInfinity(kelvin.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return fahrenheit;
        }

        public static double? ConvertKelvinToCelsius(double? kelvin)
        {
            double? celsius = null;
            if (kelvin != null)
            {
                celsius = kelvin - 273.15;

                if (double.IsInfinity(kelvin.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return celsius;
        }

    }
}
