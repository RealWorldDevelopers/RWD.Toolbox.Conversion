
// Copyright(C) 2016  Real World Developers (www.realworlddevelopers.com)  

using System;

namespace RWD.Toolbox.Conversion
{
    /// <summary>
    /// Converts Mass between US and Metric.
    /// </summary>
    public static class Mass
    {
        /// <summary>
        /// KiloGrams To MilliGrams
        /// </summary>
        /// <param name="kg">KiloGrams as <see cref="Nullable{Double}"/></param>
        /// <returns>MiiliGrams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Same as GramsToMilliGrams(KiloGramsToGrams(Kg))</remarks>
        public static double? KiloGramsToMilliGrams(double? kg)
        {
            double? milliGrams = null;
            milliGrams = GramsToMilliGrams(KiloGramsToGrams(kg));
            return milliGrams;
        }

        /// <summary>
        /// Milligrams To KiloGrams
        /// </summary>
        /// <param name="mg">MillioGrams as <see cref="Nullable{Double}"/></param>
        /// <returns>KiloGrams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>Same as GramsToKiloGrams(MilligramsToGrams(mg))</remarks>
        public static double? MilligramsToKiloGrams(double? mg)
        {
            var kiloGrams = GramsToKiloGrams(MilliGramsToGrams(mg));
            return kiloGrams;
        }

        /// <summary>
        /// KiloGrams To Grams
        /// </summary>
        /// <param name="kg">KiloGrams as <see cref="Nullable{Double}"/></param>
        /// <returns>Grams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 kilogram = 1000 grams</remarks>
        public static double? KiloGramsToGrams(double? kg)
        {
            double? grams = null;
            if (kg != null)
            {
                grams = kg * 1000;
                if (double.IsInfinity(grams.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return grams;
        }

        /// <summary>
        /// Grams To KiloGrams
        /// </summary>
        /// <param name="g">Grams as <see cref="Nullable{Double}"/></param>
        /// <returns>KiloGrams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 gram =null.001 kilograms</remarks>
        public static double? GramsToKiloGrams(double? g)
        {
            double? kiloGrams = null;
            if (g != null)
                kiloGrams = g * 0.001;
            return kiloGrams;
        }

        /// <summary>
        /// Grams To MilliGrams
        /// </summary>
        /// <param name="g">Grams as <see cref="Nullable{Double}"/></param>
        /// <returns>MilliGrams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 gram = 1000 milligrams</remarks>
        public static double? GramsToMilliGrams(double? g)
        {
            double? milliGrams = null;
            if (g != null)
            {
                milliGrams = g * 1000;
                if (double.IsInfinity(milliGrams.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }

            return milliGrams;
        }

        /// <summary>
        /// MilliGrams To Grams
        /// </summary>
        /// <param name="mg">MilliGrams as <see cref="Nullable{Double}"/></param>
        /// <returns>Grams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 milligram =null.001 grams</remarks>
        public static double? MilliGramsToGrams(double? mg)
        {
            double? grams = null;
            if (mg != null)
                grams = mg * 0.001;
            return grams;
        }

        /// <summary>
        /// Ounces To Pounds
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Pounds as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 ounce =null.0625 pounds</remarks>
        public static double? OuncesToPounds(double? oz)
        {
            double? pounds = null;
            if (oz != null)
                pounds = oz * 0.0625;
            return pounds;
        }

        /// <summary>
        /// Pounds To Ounces
        /// </summary>
        /// <param name="lbs">Pounds as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 pound = 16 ounces</remarks>
        public static double? PoundsToOunces(double? lbs)
        {
            double? ounces = null;
            if (lbs != null)
            {
                ounces = lbs * 16;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Grams
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Grams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 ounce = 28.3495231 grams</remarks>
        public static double? OuncesToGrams(double? oz)
        {
            double? grams = null;
            if (oz != null)
            {
                grams = oz * 28.3495231;
                if (double.IsInfinity(grams.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return grams;
        }

        /// <summary>
        /// Grams To Ounces
        /// </summary>
        /// <param name="g">Grams as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 gram =null.0352739619 ounces</remarks>
        public static double? GramsToOunces(double? g)
        {
            double? ounces = null;
            if (g != null)
                ounces = g * 0.0352739619;
            return ounces;
        }

        /// <summary>
        /// Pounds To KiloGrams
        /// </summary>
        /// <param name="lbs">Pounds as <see cref="Nullable{Double}"/></param>
        /// <returns>KiloGrams as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 pound = 0.45359237 kilograms</remarks>
        public static double? PoundsToKiloGrams(double? lbs)
        {
            double? kiloGrams = null;
            if (lbs != null)
                kiloGrams = lbs * 0.45359237;
            return kiloGrams;
        }

        /// <summary>
        /// KiloGrams To Pounds
        /// </summary>
        /// <param name="kg">KiloGrams as <see cref="Nullable{Double}"/></param>
        /// <returns>Pounds as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 kilogram = 2.20462262 pounds</remarks>
        public static double? KiloGramsToPounds(double? kg)
        {
            double? pounds = null;
            if (kg != null)
            {
                pounds = kg * 2.20462262;
                if (double.IsInfinity(pounds.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return pounds;
        }

        /// <summary>
        /// Pounds to US Tons
        /// </summary>
        /// <param name="lbs">Pounds as <see cref="Nullable{Double}"/></param>
        /// <returns>US Tons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 Pound = .0005 US Ton</remarks>
        public static double? PoundsToTons(double? lbs)
        {
            double? tons = null;
            if (lbs != null)
                tons = lbs * .0005;
            return tons;
        }

        /// <summary>
        /// US Tons to Pounds
        /// </summary>
        /// <param name="ton">Tons as <see cref="Nullable{Double}"/></param>
        /// <returns>Pounds as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 Ton = 2000 Pounds</remarks>
        public static double? TonsToPounds(double? ton)
        {
            double? lbs = null;
            if (ton != null)
            {
                lbs = ton * 2000;
                if (double.IsInfinity(lbs.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return lbs;
        }

        /// <summary>
        /// Kilograms to Metric Tons
        /// </summary>
        /// <param name="kg">Kilograms as <see cref="Nullable{Double}"/></param>
        /// <returns>Metric Tons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 Kilogram = 0.001 Metric Ton</remarks>
        public static double? KilogramsToMetricTons(double? kg)
        {
            double? tons = null;
            if (kg != null)
                tons = kg * .001;
            return tons;
        }

        /// <summary>
        /// Metric Tons to Kilograms
        /// </summary>
        /// <param name="ton">Tons as <see cref="Nullable{Double}"/></param>
        /// <returns>Kilogram as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 Ton = 1000 Kilograms</remarks>
        public static double? MetricTonsToKilograms(double? ton)
        {
            double? kg = null;
            if (ton != null)
            {
                kg = ton * 1000;
                if (double.IsInfinity(kg.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return kg;
        }

    }
}
