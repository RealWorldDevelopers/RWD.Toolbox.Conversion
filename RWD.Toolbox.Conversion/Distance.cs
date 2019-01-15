
using System;

namespace RWD.Toolbox.Conversion
{
    /// <summary>
    /// Converts Distance between US and Metric.
    /// </summary>
    public static class Distance
    {
        /// <summary>
        /// Inches To Millimeters
        /// </summary>
        /// <param name="inches">Inches as <see cref="Nullable{Double}"/></param>
        /// <returns>Millimeters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US inch = 25.40 millimeters</remarks>
        public static double? InchesToMillimeters(double? inches)
        {
            double? millimeters = null;
            if (inches != null)
            {
                millimeters = inches / 0.039370;
                if (double.IsInfinity(millimeters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return millimeters;
        }

        /// <summary>
        /// Inches To Centimeters
        /// </summary>
        /// <param name="inches">Inches as <see cref="Nullable{Double}"/></param>
        /// <returns>Centimeters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US inch = 2.540 centimeters</remarks>
        public static double? InchesToCentimeters(double? inches)
        {
            double? centimeters = null;
            if (inches != null)
            {
                centimeters = inches / 0.39370;
                if (double.IsInfinity(centimeters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return centimeters;
        }

        /// <summary>
        /// Inches To Feet
        /// </summary>
        /// <param name="inches">Inches as <see cref="Nullable{Double}"/></param>
        /// <returns>Feet as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US inch = .08 feet</remarks>
        public static double? InchesToFeet(double? inches)
        {
            double? feet = null;
            if (inches != null)
            {
                feet = inches * 0.083333;
                if (double.IsInfinity(feet.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return feet;
        }

        /// <summary>
        /// Feet To Inches
        /// </summary>
        /// <param name="feet">Feet as <see cref="Nullable{Double}"/></param>
        /// <returns>Inches as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US foot = 12 inches</remarks>
        public static double? FeetToInches(double? feet)
        {
            double? inches = null;
            if (feet != null)
            {
                inches = feet * 12.0;
                if (double.IsInfinity(inches.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return inches;
        }

        /// <summary>
        /// Feet To Meters
        /// </summary>
        /// <param name="feet">Feet as <see cref="Nullable{Double}"/></param>
        /// <returns>Meters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US foot = 0.30 meters</remarks>
        public static double? FeetToMeters(double? feet)
        {
            double? meters = null;
            if (feet != null)
            {
                meters = feet / 3.2808;
                if (double.IsInfinity(meters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return meters;
        }

        /// <summary>
        /// Yards To Meters
        /// </summary>
        /// <param name="yards">Yards as <see cref="Nullable{Double}"/></param>
        /// <returns>Meters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US yard = 0.91 meters</remarks>
        public static double? YardsToMeters(double? yards)
        {
            double? meters = null;
            if (yards != null)
            {
                meters = yards / 1.0936;
                if (double.IsInfinity(meters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return meters;
        }

        /// <summary>
        /// Miles To Kilometers
        /// </summary>
        /// <param name="mile">Mile as <see cref="Nullable{Double}"/></param>
        /// <returns>Meters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US mile = 1.61 kilometers</remarks>
        public static double? MilesToKilometers(double? miles)
        {
            double? meters = null;
            if (miles != null)
            {
                meters = miles / 0.62137;
                if (double.IsInfinity(meters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return meters;
        }
        
        /// <summary>
        /// Miles To Yards
        /// </summary>
        /// <param name="miles">Miles as <see cref="Nullable{Double}"/></param>
        /// <returns>Yards as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US mile = 1760 yards</remarks>
        public static double? MilesToYards(double? miles)
        {
            double? yards = null;
            if (miles != null)
            {
                yards = miles * 1760;
                if (double.IsInfinity(yards.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return yards;
        }

        /// <summary>
        /// Yards To Miles
        /// </summary>
        /// <param name="yards">Yards as <see cref="Nullable{Double}"/></param>
        /// <returns>Miles as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US mile = 1760 yards</remarks>
        public static double? YardsToMiles(double? yards)
        {
            double? miles = null;
            if (yards != null)
            {
                miles = yards * 0.00056818;
                if (double.IsInfinity(miles.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return miles;
        }

        /// <summary>
        /// Miles To Feet
        /// </summary>
        /// <param name="miles">Miles as <see cref="Nullable{Double}"/></param>
        /// <returns>Feet as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US mile = 5280 feet</remarks>
        public static double? MilesToFeet(double? miles)
        {
            double? feet = null;
            if (miles != null)
            {
                feet = miles * 5280;
                if (double.IsInfinity(feet.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return feet;
        }

        /// <summary>
        /// Feet To Miles
        /// </summary>
        /// <param name="feet">Feet as <see cref="Nullable{Double}"/></param>
        /// <returns>Miles as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US mile = 5280 feet</remarks>
        public static double? FeetToMiles(double? feet)
        {
            double? miles = null;
            if (feet != null)
            {
                miles = feet * 0.00018939;
                if (double.IsInfinity(miles.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return miles;
        }


        /// <summary>
        /// Millimeters To Inches
        /// </summary>
        /// <param name="millimeters">Millimeters  as <see cref="Nullable{Double}"/></param>
        /// <returns>Inches  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 millimeter = 0.04 US inches</remarks>
        public static double? MillimetersToInches(double? millimeters)
        {
            double? inches = null;
            if (millimeters != null)
            {
                inches = millimeters * 0.039370;
                if (double.IsInfinity(inches.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return inches;
        }

        /// <summary>
        /// Centimeters To Inches
        /// </summary>
        /// <param name="centimeters">Centimeters  as <see cref="Nullable{Double}"/></param>
        /// <returns>Inches  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 centimeter = 0.39 US inches</remarks>
        public static double? CentimetersToInches(double? centimeters)
        {
            double? inches = null;
            if (centimeters != null)
            {
                inches = centimeters * 0.39370;
                if (double.IsInfinity(inches.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return inches;
        }

        /// <summary>
        /// Meters To Feet
        /// </summary>
        /// <param name="meters">Meters  as <see cref="Nullable{Double}"/></param>
        /// <returns>Feet  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 meter = 3.28 US feet</remarks>
        public static double? MetersToFeet(double? meters)
        {
            double? feet = null;
            if (meters != null)
            {
                feet = meters * 3.2808;
                if (double.IsInfinity(feet.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return feet;
        }

        /// <summary>
        /// Meters To Yards
        /// </summary>
        /// <param name="meters">Meters  as <see cref="Nullable{Double}"/></param>
        /// <returns>Yards  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 meter = 1.09 US yards</remarks>
        public static double? MetersToYards(double? meters)
        {
            double? yards = null;
            if (meters != null)
            {
                yards = meters * 1.0936;
                if (double.IsInfinity(yards.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return yards;
        }

        /// <summary>
        /// Kilometers To Miles
        /// </summary>
        /// <param name="kilometers">Kilometers  as <see cref="Nullable{Double}"/></param>
        /// <returns>Miles  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 kilometer = 0.62 US miles</remarks>
        public static double? KilometersToMiles(double? kilometers)
        {
            double? miles = null;
            if (kilometers != null)
            {
                miles = kilometers * 0.62137;
                if (double.IsInfinity(miles.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return miles;
        }

        /// <summary>
        /// Kilometers To Meters
        /// </summary>
        /// <param name="kilometers">Kilometers  as <see cref="Nullable{Double}"/></param>
        /// <returns>Meters  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 kilometer = 1000 meters</remarks>
        public static double? KilometersToMeters(double? kilometers)
        {
            double? meters = null;
            if (kilometers != null)
            {
                meters = kilometers * 1000;
                if (double.IsInfinity(meters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return meters;
        }

        /// <summary>
        /// Meters To Kilometers
        /// </summary>
        /// <param name="meters">Meters  as <see cref="Nullable{Double}"/></param>
        /// <returns>Kilometers  as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 meter = 0.001 kilometers</remarks>
        public static double? MetersToKilometers(double? meters)
        {
            double? kilometers = null;
            if (meters != null)
            {
                kilometers = meters / 1000;
                if (double.IsInfinity(kilometers.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return kilometers;
        }

    }

}
