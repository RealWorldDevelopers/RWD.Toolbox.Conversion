using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RWD.Toolbox.Conversion.UnitTest
{
    [TestClass]
    public class MeasurementsTest
    {
        #region "Temperature Conversion"

        [TestMethod]
        public void ConvertCelciusToFahrenheit_freezing()
        {
            // set params
            var testValue = 0;

            // call method
            var result = Measurement.ConvertCelciusToFahrenheit(testValue);

            // assert
            var correctValue = 32;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelciusToFahrenheit_boiling()
        {
            // set params
            var testValue = 100;

            // call method
            var result = Measurement.ConvertCelciusToFahrenheit(testValue);

            // assert
            var correctValue = 212;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelciusToFahrenheit_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.ConvertCelciusToFahrenheit(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertCelciusToFahrenheit_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.ConvertCelciusToFahrenheit(testValue);

            // assert is handled by ExpectedException 
        }


        [TestMethod]
        public void ConvertFahrenheitToCelcius_freezing()
        {
            // set params
            var testValue = 32;

            // call method
            var result = Measurement.ConvertFahrenheitToCelcius(testValue);

            // assert
            var correctValue = 0;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelcius_boiling()
        {
            // set params
            var testValue = 212;

            // call method
            var result = Measurement.ConvertFahrenheitToCelcius(testValue);

            // assert
            var correctValue = 100;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelcius_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.ConvertFahrenheitToCelcius(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelcius_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.ConvertFahrenheitToCelcius(testValue);

            var correctValue = 9.98718408256842E+307;
            Assert.AreEqual(result, correctValue);
        }

        #endregion

        #region "Mass"

        [TestMethod]
        public void KiloGramsToMilliGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.KiloGramsToMilliGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void KiloGramsToMilliGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.KiloGramsToMilliGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToMilliGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.KiloGramsToMilliGrams(testValue);

            // assert
            var correctValue = 1000000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilligramsToKiloGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilligramsToKiloGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilligramsToKiloGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilligramsToKiloGrams(testValue);

            // assert
            var correctValue = 1.7976931348623154E+302;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilligramsToKiloGrams_validReturn()
        {
            // set params
            var testValue = 1000000;

            // call method
            var result = Measurement.MilligramsToKiloGrams(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KiloGramsToGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.KiloGramsToGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void KiloGramsToGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.KiloGramsToGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.KiloGramsToGrams(testValue);

            // assert
            var correctValue = 1000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToKiloGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GramsToKiloGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToKiloGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GramsToKiloGrams(testValue);

            // assert
            double? correctValue = 1.7976931348623156E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToKiloGrams_validReturn()
        {
            // set params
            var testValue = 1000;

            // call method
            var result = Measurement.GramsToKiloGrams(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToMilliGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GramsToMilliGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GramsToMilliGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GramsToMilliGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GramsToMilliGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GramsToMilliGrams(testValue);

            // assert
            var correctValue = 1000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliGramsToGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilliGramsToGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliGramsToGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilliGramsToGrams(testValue);

            // assert
            var correctValue = 1.7976931348623156E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliGramsToGrams_validReturn()
        {
            // set params
            var testValue = 1000;

            // call method
            var result = Measurement.MilliGramsToGrams(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPounds_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToPounds(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPounds_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToPounds(testValue);

            // assert
            var correctValue = 1.1235582092889473E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPounds_validReturn()
        {
            // set params
            var testValue = 16;

            // call method
            var result = Measurement.OuncesToPounds(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PoundsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void PoundsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PoundsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PoundsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.PoundsToOunces(testValue);

            // assert
            var correctValue = 16;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OuncesToGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.OuncesToGrams(testValue);

            // assert
            var correctValue = 28.3495231;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GramsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GramsToOunces(testValue);

            // assert
            var correctValue = 6.3411759147024876E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GramsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GramsToOunces(testValue);

            // assert
            var correctValue = 0.0352739619;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToKiloGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PoundsToKiloGrams(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToKiloGrams_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PoundsToKiloGrams(testValue);

            // assert
            var correctValue = 8.1541988957492744E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToKiloGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.PoundsToKiloGrams(testValue);

            // assert
            var correctValue = 0.45359237;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KiloGramsToPounds_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.KiloGramsToPounds(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void KiloGramsToPounds_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.KiloGramsToPounds(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToPounds_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.KiloGramsToPounds(testValue);

            // assert
            var correctValue = 2.20462262;
            Assert.AreEqual(result, correctValue);
        }

        #endregion

        #region "Volume"

        [TestMethod]
        public void GallonsToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GallonsToQuarts(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GallonsToQuarts_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GallonsToQuarts(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToQuarts_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GallonsToQuarts(testValue);

            // assert
            var correctValue = 4;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToGallons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.QuartsToGallons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToGallons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.QuartsToGallons(testValue);

            // assert
            var correctValue = 4.4942328371557893E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToGallons_validReturn()
        {
            // set params
            var testValue = 4;

            // call method
            var result = Measurement.QuartsToGallons(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GallonsToPints_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GallonsToPints(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GallonsToPints_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GallonsToPints(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToPints_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GallonsToPints(testValue);

            // assert
            var correctValue = 8;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToGallons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PintsToGallons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToGallons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PintsToGallons(testValue);

            var correctValue = 2.2471164185778946E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToGallons_validReturn()
        {
            // set params
            var testValue = 8;

            // call method
            var result = Measurement.PintsToGallons(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GallonsToCups_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GallonsToCups(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GallonsToCups_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GallonsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GallonsToCups(testValue);

            // assert
            var correctValue = 16;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToGallons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.CupsToGallons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToGallons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.CupsToGallons(testValue);

            // assert
            var correctValue = 1.1235582092889473E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToGallons_validReturn()
        {
            // set params
            var testValue = 16;

            // call method
            var result = Measurement.CupsToGallons(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GallonsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GallonsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GallonsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GallonsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GallonsToOunces(testValue);

            // assert
            var correctValue = 128;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToGallons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToGallons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToGallons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToGallons(testValue);

            // assert
            var correctValue = 1.4044477616111842E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToGallons_validReturn()
        {
            // set params
            var testValue = 128;

            // call method
            var result = Measurement.OuncesToGallons(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToPints_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.QuartsToPints(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void QuartsToPints_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.QuartsToPints(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToPints_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.QuartsToPints(testValue);

            // assert
            var correctValue = 2;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PintsToQuarts(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToQuarts_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PintsToQuarts(testValue);

            // assert
            var correctValue = 8.9884656743115785E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToQuarts_validReturn()
        {
            // set params
            var testValue = 2;

            // call method
            var result = Measurement.PintsToQuarts(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToCups_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.QuartsToCups(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void QuartsToCups_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.QuartsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.QuartsToCups(testValue);

            // assert
            var correctValue = 4;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.CupsToQuarts(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToQuarts_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.CupsToQuarts(testValue);

            // assert
            var correctValue = 4.4942328371557893E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToQuarts_validReturn()
        {
            // set params
            var testValue = 4;

            // call method
            var result = Measurement.CupsToQuarts(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.QuartsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void QuartsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.QuartsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.QuartsToOunces(testValue);

            // assert
            var correctValue = 32;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToQuarts(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToQuarts_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToQuarts(testValue);

            // assert
            var correctValue = 5.6177910464447366E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToQuarts_validReturn()
        {
            // set params
            var testValue = 32;

            // call method
            var result = Measurement.OuncesToQuarts(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToCups_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PintsToCups(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void PintsToCups_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PintsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PintsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.PintsToCups(testValue);

            // assert
            var correctValue = 2;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToPints_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.CupsToPints(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToPints_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.CupsToPints(testValue);

            // assert
            var correctValue = 8.9884656743115785E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToPints_validReturn()
        {
            // set params
            var testValue = 2;

            // call method
            var result = Measurement.CupsToPints(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.PintsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void PintsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.PintsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PintsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.PintsToOunces(testValue);

            // assert
            var correctValue = 16;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPints_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToPints(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPints_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToPints(testValue);

            // assert
            var correctValue = 1.1235582092889473E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToPints_validReturn()
        {
            // set params
            var testValue = 16;

            // call method
            var result = Measurement.OuncesToPints(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CupsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.CupsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void CupsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.CupsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void CupsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.CupsToOunces(testValue);

            // assert
            var correctValue = 8;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToCups_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToCups(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToCups_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToCups(testValue);

            // assert
            var correctValue = 2.2471164185778946E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToCups_validReturn()
        {
            // set params
            var testValue = 8;

            // call method
            var result = Measurement.OuncesToCups(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToTablespoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToTablespoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OuncesToTablespoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToTablespoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToTablespoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.OuncesToTablespoons(testValue);

            // assert
            var correctValue = 2;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TablespoonsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TablespoonsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TablespoonsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TablespoonsToOunces(testValue);

            // assert
            var correctValue = 8.9884656743115785E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TablespoonsToOunces_validReturn()
        {
            // set params
            var testValue = 2;

            // call method
            var result = Measurement.TablespoonsToOunces(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToTeaspoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToTeaspoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OuncesToTeaspoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToTeaspoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToTeaspoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.OuncesToTeaspoons(testValue);

            // assert
            var correctValue = 6;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TeaspoonsToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TeaspoonsToOunces(testValue);

            // assert
            var correctValue = 2.9961552307628363E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToOunces_validReturn()
        {
            // set params
            var testValue = 6;

            // call method
            var result = Measurement.TeaspoonsToOunces(testValue);

            // assert
            var correctValue = 1.000000002;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TablespoonsToTeaspoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TablespoonsToTeaspoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TablespoonsToTeaspoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TablespoonsToTeaspoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TablespoonsToTeaspoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.TablespoonsToTeaspoons(testValue);

            // assert
            var correctValue = 3;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToTablespoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TeaspoonsToTablespoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToTablespoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TeaspoonsToTablespoons(testValue);

            // assert
            var correctValue = 5.9923104495410527E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToTablespoons_validReturn()
        {
            // set params
            var testValue = 3;

            // call method
            var result = Measurement.TeaspoonsToTablespoons(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToMilliLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.LitersToMilliLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void LitersToMilliLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.LitersToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.LitersToMilliLiters(testValue);

            // assert
            var correctValue = 1000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilliLitersToLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilliLitersToLiters(testValue);

            // assert
            var correctValue = 1.7976931348623156E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToLiters_validReturn()
        {
            // set params
            var testValue = 1000;

            // call method
            var result = Measurement.MilliLitersToLiters(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToGallons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.LitersToGallons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToGallons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.LitersToGallons(testValue);

            // assert
            double? correctValue = 4.7490028430289061E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToGallons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.LitersToGallons(testValue);

            // assert
            var correctValue = 0.264172052;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void GallonsToLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.GallonsToLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GallonsToLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.GallonsToLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.GallonsToLiters(testValue);

            // assert
            var correctValue = 3.78541178;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.LitersToQuarts(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void LitersToQuarts_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.LitersToQuarts(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToQuarts_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.LitersToQuarts(testValue);

            // assert
            var correctValue = 1.05668821;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.QuartsToLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.QuartsToLiters(testValue);

            // assert
            var correctValue =  1.7012521941809277E+308;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.QuartsToLiters(testValue);

            // assert
            var correctValue = 0.946352946;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void LitersToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.LitersToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void LitersToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.LitersToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.LitersToOunces(testValue);

            // assert
            var correctValue = 33.8140227;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToLiters(testValue);

            // assert
            var correctValue = 5.3164131135567483E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.OuncesToLiters(testValue);

            // assert
            var correctValue = 0.0295735296;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToOunces_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilliLitersToOunces(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToOunces_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilliLitersToOunces(testValue);

            // assert
            var correctValue = 6.07872364698685E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.MilliLitersToOunces(testValue);

            // assert
            var correctValue = 0.0338140227;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void OuncesToMilliLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.OuncesToMilliLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OuncesToMilliLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.OuncesToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.OuncesToMilliLiters(testValue);

            // assert
            var correctValue = 29.5735296;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTablespoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilliLitersToTablespoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTablespoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilliLitersToTablespoons(testValue);

            // assert
            double? correctValue = 1.21574472939737E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTablespoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.MilliLitersToTablespoons(testValue);

            // assert
            var correctValue = 0.0676280454;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TablespoonsToMilliLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TablespoonsToMilliLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TablespoonsToMilliLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TablespoonsToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TablespoonsToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.TablespoonsToMilliLiters(testValue);

            // assert
            var correctValue = 14.7867648;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTeaspoons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.MilliLitersToTeaspoons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTeaspoons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.MilliLitersToTeaspoons(testValue);

            // assert
            var correctValue = 3.6472341845967238E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilliLitersToTeaspoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.MilliLitersToTeaspoons(testValue);

            // assert
            var correctValue = 0.202884136;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TeaspoonsToMilliLiters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Measurement.TeaspoonsToMilliLiters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TeaspoonsToMilliLiters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Measurement.TeaspoonsToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TeaspoonsToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Measurement.TeaspoonsToMilliLiters(testValue);

            // assert
            var correctValue = 4.92892159;
            Assert.AreEqual(result, correctValue);
        }

        #endregion

    }
}
