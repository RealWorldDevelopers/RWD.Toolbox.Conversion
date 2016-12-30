using System;

namespace RWD.Toolbox.Conversion
{
    /// <summary>
    /// Converts Volume between US and Metric.
    /// </summary>
    public static class Volume
    {
        /// <summary>
        /// Gallons To Quarts
        /// </summary>
        /// <param name="gal">Gallons as <see cref="Nullable{Double}"/></param>
        /// <returns>Quarts as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US gallon = 4 US quarts</remarks>
        public static double? GallonsToQuarts(double? gal)
        {
            double? quarts = null;
            if (gal != null)
            {
                quarts = gal * 4;
                if (double.IsInfinity(quarts.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return quarts;
        }

        /// <summary>
        /// Quarts To Gallons
        /// </summary>
        /// <param name="qrt">Quarts as <see cref="Nullable{Double}"/></param>
        /// <returns>Gallons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US quart =null.25 US gallons</remarks>
        public static double? QuartsToGallons(double? qrt)
        {
            double? gallons = null;
            if (qrt != null)
                gallons = qrt * 0.25;
            return gallons;
        }

        /// <summary>
        /// Gallons To Pints
        /// </summary>
        /// <param name="gal">Gallons as <see cref="Nullable{Double}"/></param>
        /// <returns>Pints as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US gallon = 8 US pints</remarks>
        public static double? GallonsToPints(double? gal)
        {
            double? pints = null;
            if (gal != null)
            {
                pints = gal * 8;
                if (double.IsInfinity(pints.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return pints;
        }

        /// <summary>
        /// Pints To Gallons
        /// </summary>
        /// <param name="pint">Pints as <see cref="Nullable{Double}"/></param>
        /// <returns>Gallons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US pint =null.125 US gallons</remarks>
        public static double? PintsToGallons(double? pint)
        {
            double? gallons = null;
            if (pint != null)
                gallons = pint * 0.125;
            return gallons;
        }

        /// <summary>
        /// Gallons To Cups
        /// </summary>
        /// <param name="gal">Gallons as <see cref="Nullable{Double}"/></param>
        /// <returns>Cups as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US gallon = 16 US cups</remarks>
        public static double? GallonsToCups(double? gal)
        {
            double? cups = null;
            if (gal != null)
            {
                cups = gal * 16;
                if (double.IsInfinity(cups.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return cups;
        }

        /// <summary>
        /// Cups To Gallons
        /// </summary>
        /// <param name="cup">Cups as <see cref="Nullable{Double}"/></param>
        /// <returns>Gallons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US cup =null.0625 US gallons</remarks>
        public static double? CupsToGallons(double? cup)
        {
            double? gallons = null;
            if (cup != null)
                gallons = cup * 0.0625;
            return gallons;
        }

        /// <summary>
        /// Gallons To Ounces
        /// </summary>
        /// <param name="gal">Gallons as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US gallon = 128 US fluid ounces</remarks>
        public static double? GallonsToOunces(double? gal)
        {
            double? ounces = null;
            if (gal != null)
            {
                ounces = gal * 128;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Gallons
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Gallons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce =null.0078125 US gallons</remarks>
        public static double? OuncesToGallons(double? oz)
        {
            double? gallons = null;
            if (oz != null)
                gallons = oz * 0.0078125;
            return gallons;
        }

        /// <summary>
        /// Quarts To Pints
        /// </summary>
        /// <param name="qrt">Quarts as <see cref="Nullable{Double}"/></param>
        /// <returns>Pints as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US quart = 2 US pints</remarks>
        public static double? QuartsToPints(double? qrt)
        {
            double? pints = null;
            if (qrt != null)
            {
                pints = qrt * 2;
                if (double.IsInfinity(pints.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return pints;
        }

        /// <summary>
        /// Pints To Quarts
        /// </summary>
        /// <param name="pint">Pints as <see cref="Nullable{Double}"/></param>
        /// <returns>Quarts as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US pint =null.5 US quarts</remarks>
        public static double? PintsToQuarts(double? pint)
        {
            double? quarts = null;
            if (pint != null)
                quarts = pint * 0.5;
            return quarts;
        }

        /// <summary>
        /// Quarts To Cups
        /// </summary>
        /// <param name="qrt">Quarts as <see cref="Nullable{Double}"/></param>
        /// <returns>Cups as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US quart = 4 US cups</remarks>
        public static double? QuartsToCups(double? qrt)
        {
            double? cups = null;
            if (qrt != null)
            {
                cups = qrt * 4;
                if (double.IsInfinity(cups.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return cups;
        }

        /// <summary>
        /// Cups To Quarts
        /// </summary>
        /// <param name="cup">Cups as <see cref="Nullable{Double}"/></param>
        /// <returns>Quarts as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US cup =null.25 US quarts</remarks>
        public static double? CupsToQuarts(double? cup)
        {
            double? quarts = null;
            if (cup != null)
                quarts = cup * 0.25;
            return quarts;
        }

        /// <summary>
        /// Quarts To Ounces
        /// </summary>
        /// <param name="qrt">Quarts as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US quart = 32 US fluid ounces</remarks>
        public static double? QuartsToOunces(double? qrt)
        {
            double? ounces = null;
            if (qrt != null)
            {
                ounces = qrt * 32;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Quarts
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Quarts as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce =null.03125 US quarts</remarks>
        public static double? OuncesToQuarts(double? oz)
        {
            double? quarts = null;
            if (oz != null)
                quarts = oz * 0.03125;
            return quarts;
        }

        /// <summary>
        /// Pints To Cups
        /// </summary>
        /// <param name="pint">Pints as <see cref="Nullable{Double}"/></param>
        /// <returns>Cups as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US pint = 2 US cups</remarks>
        public static double? PintsToCups(double? pint)
        {
            double? cups = null;
            if (pint != null)
            {
                cups = pint * 2;
                if (double.IsInfinity(cups.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return cups;
        }

        /// <summary>
        /// Cups To Pints
        /// </summary>
        /// <param name="cup">Cups as <see cref="Nullable{Double}"/></param>
        /// <returns>Pints as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US cup =null.5 US pints</remarks>
        public static double? CupsToPints(double? cup)
        {
            double? pints = null;
            if (cup != null)
                pints = cup * 0.5;
            return pints;
        }

        /// <summary>
        /// Pints To Ounces
        /// </summary>
        /// <param name="pint">Pints as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US pint = 16 US fluid ounces</remarks>
        public static double? PintsToOunces(double? pint)
        {
            double? ounces = null;
            if (pint != null)
            {
                ounces = pint * 16;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Pints
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Pints as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce =null.0625 US pints</remarks>
        public static double? OuncesToPints(double? oz)
        {
            double? pints = null;
            if (oz != null)
                pints = oz * 0.0625;
            return pints;
        }

        /// <summary>
        /// Cups To Ounces
        /// </summary>
        /// <param name="cup">Cups as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US cup = 8 US fluid ounces</remarks>
        public static double? CupsToOunces(double? cup)
        {
            double? ounces = null;
            if (cup != null)
            {
                ounces = cup * 8;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Cups
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Cups as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce =null.125 US cups</remarks>
        public static double? OuncesToCups(double? oz)
        {
            double? cups = null;
            if (oz != null)
                cups = oz * 0.125;
            return cups;
        }

        /// <summary>
        /// Ounces To Tablespoons
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Tablespoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce = 2 US tablespoons</remarks>
        public static double? OuncesToTablespoons(double? oz)
        {
            double? tablespoons = null;
            if (oz != null)
            {
                tablespoons = oz * 2;
                if (double.IsInfinity(tablespoons.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return tablespoons;
        }

        /// <summary>
        /// Tablespoons To Ounces
        /// </summary>
        /// <param name="tbsp">Tablespoons as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US tablespoon =null.5 US fluid ounces</remarks>
        public static double? TablespoonsToOunces(double? tbsp)
        {
            double? ounces = null;
            if (tbsp != null)
                ounces = tbsp * 0.5;
            return ounces;
        }

        /// <summary>
        /// Ounces To Teaspoons
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Teaspoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce = 6 US teaspoons</remarks>
        public static double? OuncesToTeaspoons(double? oz)
        {
            double? teaspoons = null;
            if (oz != null)
            {
                teaspoons = oz * 6;
                if (double.IsInfinity(teaspoons.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return teaspoons;
        }

        /// <summary>
        /// Teaspoons To Ounces
        /// </summary>
        /// <param name="tsp">Teaspoons as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US teaspoon =null.166666667 US fluid ounces</remarks>
        public static double? TeaspoonsToOunces(double? tsp)
        {
            double? ounces = null;
            if (tsp != null)
                ounces = tsp * 0.166666667;
            return ounces;
        }

        /// <summary>
        /// Tablespoons To Teaspoons
        /// </summary>
        /// <param name="tbsp">Tablespoons as <see cref="Nullable{Double}"/></param>
        /// <returns>Teaspoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US teaspoon =null.333333333 US tablespoons</remarks>
        public static double? TablespoonsToTeaspoons(double? tbsp)
        {
            double? teaspoons = null;
            if (tbsp != null)
            {
                teaspoons = tbsp * 3;
                if (double.IsInfinity(teaspoons.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return teaspoons;
        }

        /// <summary>
        /// Teaspoons To Tablespoons
        /// </summary>
        /// <param name="tsp">Teaspoons as <see cref="Nullable{Double}"/></param>
        /// <returns>Tablespoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US tablespoon = 3 US teaspoons</remarks>
        public static double? TeaspoonsToTablespoons(double? tsp)
        {
            double? tablespoons = null;
            if (tsp != null)
            {
                tablespoons = tsp / 3;
                if (double.IsInfinity(tablespoons.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return tablespoons;
        }

        /// <summary>
        /// Liters To MilliLiters
        /// </summary>
        /// <param name="liter">Liters as <see cref="Nullable{Double}"/></param>
        /// <returns>MilliLiters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 liter = 1000 milliliter</remarks>
        public static double? LitersToMilliLiters(double? liter)
        {
            double? milliLiters = null;
            if (liter != null)
            {
                milliLiters = liter * 1000;
                if (double.IsInfinity(milliLiters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return milliLiters;
        }

        /// <summary>
        /// MilliLiters To Liters
        /// </summary>
        /// <param name="ml">MilliLiters as <see cref="Nullable{Double}"/></param>
        /// <returns>Liters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 milliliters =null.001 liters</remarks>
        public static double? MilliLitersToLiters(double? ml)
        {
            double? liters = null;
            if (ml != null)
                liters = ml * 0.001;
            return liters;
        }

        /// <summary>
        /// Liters To Gallons
        /// </summary>
        /// <param name="liter">Liters as <see cref="Nullable{Double}"/></param>
        /// <returns>Gallons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 liter =null.264172052 US gallons</remarks>
        public static double? LitersToGallons(double? liter)
        {
            double? gallons = null;
            if (liter != null)
                gallons = liter * 0.264172052;
            return gallons;
        }

        /// <summary>
        /// Gallons To Liters
        /// </summary>
        /// <param name="gal">Gallons as <see cref="Nullable{Double}"/></param>
        /// <returns>Liters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US gallon = 3.78541178 liter</remarks>
        public static double? GallonsToLiters(double? gal)
        {
            double? liters = null;
            if (gal != null)
            {
                liters = gal * 3.78541178;
                if (double.IsInfinity(liters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return liters;
        }

        /// <summary>
        /// Liters To Quarts
        /// </summary>
        /// <param name="liter">Liters as <see cref="Nullable{Double}"/></param>
        /// <returns>Quarts as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 liter = 1.05668821 US quarts</remarks>
        public static double? LitersToQuarts(double? liter)
        {
            double? quarts = null;
            if (liter != null)
            {
                quarts = liter * 1.05668821;
                if (double.IsInfinity(quarts.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return quarts;
        }

        /// <summary>
        /// Quarts To Liters
        /// </summary>
        /// <param name="qrt">Quarts as <see cref="Nullable{Double}"/></param>
        /// <returns>Liters asd Dobule</returns>
        /// <remarks>1 US quart =null.946352946 liter</remarks>
        public static double? QuartsToLiters(double? qrt)
        {
            double? liters = null;
            if (qrt != null)
                liters = qrt * 0.946352946;
            return liters;
        }

        /// <summary>
        /// Liters To Ounces
        /// </summary>
        /// <param name="liter">Liters as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 liter = 33.8140227 US fluid ounces</remarks>
        public static double? LitersToOunces(double? liter)
        {
            double? ounces = null;
            if (liter != null)
            {
                ounces = liter * 33.8140227;
                if (double.IsInfinity(ounces.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return ounces;
        }

        /// <summary>
        /// Ounces To Liters
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>Liters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce =null.0295735296 liters</remarks>
        public static double? OuncesToLiters(double? oz)
        {
            double? liters = null;
            if (oz != null)
                liters = oz * 0.0295735296;
            return liters;
        }

        /// <summary>
        /// MilliLiters To Ounces
        /// </summary>
        /// <param name="ml">MilliLiters as <see cref="Nullable{Double}"/></param>
        /// <returns>Ounces as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 milliliter =null.0338140227 US fluid ounces</remarks>
        public static double? MilliLitersToOunces(double? ml)
        {
            double? ounces = null;
            if (ml != null)
                ounces = ml * 0.0338140227;
            return ounces;
        }

        /// <summary>
        /// Ounces To MilliLiters
        /// </summary>
        /// <param name="oz">Ounces as <see cref="Nullable{Double}"/></param>
        /// <returns>MilliLiters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US fluid ounce = 29.5735296 milliliters</remarks>
        public static double? OuncesToMilliLiters(double? oz)
        {
            double? milliLiter = null;
            if (oz != null)
            {
                milliLiter = oz * 29.5735296;
                if (double.IsInfinity(milliLiter.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return milliLiter;
        }

        /// <summary>
        /// MilliLiters To Tablespoons
        /// </summary>
        /// <param name="ml">MilliLiters as <see cref="Nullable{Double}"/></param>
        /// <returns>Tablespoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks></remarks>
        public static double? MilliLitersToTablespoons(double? ml)
        {
            double? tablespoons = null;
            if (ml != null)
                tablespoons = ml * 0.0676280454;
            return tablespoons;
        }

        /// <summary>
        /// Tablespoons To MilliLiters
        /// </summary>
        /// <param name="tbsp">Tablespoons as <see cref="Nullable{Double}"/></param>
        /// <returns>MilliLiters as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 US tablespoon = 14.7867648 milliliters</remarks>
        public static double? TablespoonsToMilliLiters(double? tbsp)
        {
            double? milliLiters = null;
            if (tbsp != null)
            {
                milliLiters = tbsp * 14.7867648;
                if (double.IsInfinity(milliLiters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return milliLiters;
        }

        /// <summary>
        /// MilliLiters To Teaspoons
        /// </summary>
        /// <param name="ml">MilliLiters as <see cref="Nullable{Double}"/></param>
        /// <returns>Teaspoons as <see cref="Nullable{Double}"/></returns>
        /// <remarks>1 milliliter =null.202884136 US teaspoons</remarks>
        public static double? MilliLitersToTeaspoons(double? ml)
        {
            double? teaspoons = null;
            if (ml != null)
                teaspoons = ml * 0.202884136;
            return teaspoons;
        }

        /// <summary>
        /// Teaspoons To MilliLiters
        /// </summary>
        /// <param name="tsp">Teaspoons as <see cref="Nullable{Double}"/></param>
        /// <returns>MilliLiters as <see cref="Nullable{Double}"/></returns>
        public static double? TeaspoonsToMilliLiters(double? tsp)
        {
            double? milliLiters = null;
            if (tsp != null)
            {
                milliLiters = tsp * 4.92892159;
                if (double.IsInfinity(milliLiters.Value))
                    throw new OverflowException("Calculated Value Results in an Overflow");
            }
            return milliLiters;
        }

    }
}
