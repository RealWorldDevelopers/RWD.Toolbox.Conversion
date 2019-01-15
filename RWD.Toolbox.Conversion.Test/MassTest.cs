using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RWD.Toolbox.Conversion.Test
{
  
    [TestClass]
    public class MassTest
    {
        [TestInitialize]
        public void Setup() { } 

        [TestMethod]
        public void KiloGramsToMilliGrams_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Mass.KiloGramsToMilliGrams(testValue);

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
            var result = Mass.KiloGramsToMilliGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToMilliGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.KiloGramsToMilliGrams(testValue);

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
            var result = Mass.MilligramsToKiloGrams(testValue);

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
            var result = Mass.MilligramsToKiloGrams(testValue);

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
            var result = Mass.MilligramsToKiloGrams(testValue);

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
            var result = Mass.KiloGramsToGrams(testValue);

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
            var result = Mass.KiloGramsToGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.KiloGramsToGrams(testValue);

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
            var result = Mass.GramsToKiloGrams(testValue);

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
            var result = Mass.GramsToKiloGrams(testValue);

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
            var result = Mass.GramsToKiloGrams(testValue);

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
            var result = Mass.GramsToMilliGrams(testValue);

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
            var result = Mass.GramsToMilliGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GramsToMilliGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.GramsToMilliGrams(testValue);

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
            var result = Mass.MilliGramsToGrams(testValue);

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
            var result = Mass.MilliGramsToGrams(testValue);

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
            var result = Mass.MilliGramsToGrams(testValue);

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
            var result = Mass.OuncesToPounds(testValue);

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
            var result = Mass.OuncesToPounds(testValue);

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
            var result = Mass.OuncesToPounds(testValue);

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
            var result = Mass.PoundsToOunces(testValue);

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
            var result = Mass.PoundsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PoundsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.PoundsToOunces(testValue);

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
            var result = Mass.OuncesToGrams(testValue);

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
            var result = Mass.OuncesToGrams(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToGrams_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.OuncesToGrams(testValue);

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
            var result = Mass.GramsToOunces(testValue);

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
            var result = Mass.GramsToOunces(testValue);

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
            var result = Mass.GramsToOunces(testValue);

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
            var result = Mass.PoundsToKiloGrams(testValue);

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
            var result = Mass.PoundsToKiloGrams(testValue);

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
            var result = Mass.PoundsToKiloGrams(testValue);

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
            var result = Mass.KiloGramsToPounds(testValue);

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
            var result = Mass.KiloGramsToPounds(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void KiloGramsToPounds_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.KiloGramsToPounds(testValue);

            // assert
            var correctValue = 2.20462262;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void TonToPounds_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Mass.TonsToPounds(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TonToPounds_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Mass.TonsToPounds(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TonToPounds_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.TonsToPounds(testValue);

            // assert
            var correctValue = 2000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToTons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Mass.PoundsToTons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToTons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Mass.PoundsToTons(testValue);

            // assert
            double? correctValue = 8.9884656743115778E+304;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PoundsToTons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.PoundsToTons(testValue);

            // assert
            var correctValue = .0005;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KiloGramsToMetricTons_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Mass.KilogramsToMetricTons(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KiloGramsToMetricTons_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Mass.KilogramsToMetricTons(testValue);

            // assert
            double? correctValue = 1.7976931348623156E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KiloGramsToMetricTons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.KilogramsToMetricTons(testValue);

            // assert
            var correctValue = .001;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetricTonsToKilograms_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Mass.MetricTonsToKilograms(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MetricTonsToKilograms_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Mass.MetricTonsToKilograms(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void MetricTonsToKilograms_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Mass.MetricTonsToKilograms(testValue);

            // assert
            var correctValue = 1000;
            Assert.AreEqual(result, correctValue);
        }


        [TestCleanup]
        public void Cleanup()
        {
            // if any dispose or resets are needed
        }

    }

  

}
