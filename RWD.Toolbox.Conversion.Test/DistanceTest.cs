using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace RWD.Toolbox.Conversion.Test
{
    [TestClass]
    public class DistanceTest
    {
        [TestInitialize]
        public void Setup() { }


        [TestMethod]
        public void InchesToMillimeters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.InchesToMillimeters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InchesToMillimeters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.InchesToMillimeters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void InchesToMillimeters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.InchesToMillimeters(testValue);

            // assert
            var correctValue = 25.4000508001016;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void InchesToCentimeters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.InchesToCentimeters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InchesToCentimeters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.InchesToCentimeters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void InchesToCentimeters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.InchesToCentimeters(testValue);

            // assert
            var correctValue = 2.54000508001016;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void InchesToFeet_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.InchesToFeet(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void InchesToFeet_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.InchesToFeet(testValue);

            // assert
            var correctValue = 1.4980716200748135E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void InchesToFeet_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.InchesToFeet(testValue);

            // assert
            var correctValue = 0.083333;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToInches_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.FeetToInches(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void FeetToInches_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.FeetToInches(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void FeetToInches_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.FeetToInches(testValue);

            // assert
            var correctValue = 12;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMeters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.FeetToMeters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMeters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.FeetToMeters(testValue);

            // assert
            var correctValue = 5.4794353049936465E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMeters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.FeetToMeters(testValue);

            // assert
            var correctValue = 0.30480370641307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMeters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.YardsToMeters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMeters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.YardsToMeters(testValue);

            // assert
            var correctValue = 1.6438305914980942E+308;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMeters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.YardsToMeters(testValue);

            // assert
            var correctValue = 0.91441111923921;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilesToKilometers_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MilesToKilometers(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MilesToKilometers_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MilesToKilometers(testValue);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void MilesToKilometers_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MilesToKilometers(testValue);

            // assert
            var correctValue = 1.6093470878864444;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilesToYards_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MilesToYards(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MilesToYards_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MilesToYards(testValue);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void MilesToYards_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MilesToYards(testValue);

            // assert
            var correctValue = 1760;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMiles_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.YardsToMiles(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMiles_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.YardsToMiles(testValue);

            // assert
            var correctValue = 1.0214132853660706E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void YardsToMiles_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.YardsToMiles(testValue);

            // assert
            var correctValue = 0.00056818;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MilesToFeet_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MilesToFeet(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MilesToFeet_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MilesToFeet(testValue);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void MilesToFeet_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MilesToFeet(testValue);

            // assert
            var correctValue = 5280;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMiles_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.FeetToMiles(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMiles_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.FeetToMiles(testValue);

            // assert
            var correctValue = 3.4046510281157396E+304;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void FeetToMiles_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.FeetToMiles(testValue);

            // assert
            var correctValue = 0.00018939;
            Assert.AreEqual(result, correctValue);
        }





        [TestMethod]
        public void MillimetersToInches_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MillimetersToInches(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MillimetersToInches_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MillimetersToInches(testValue);

            // assert
            var correctValue = 7.0775178719529369E+306;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MillimetersToInches_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MillimetersToInches(testValue);

            // assert
            var correctValue = 0.03937;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CentimetersToInchesToInches_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.CentimetersToInches(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CentimetersToInchesToInches_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.CentimetersToInches(testValue);

            // assert
            var correctValue = 7.0775178719529366E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void CentimetersToInchesToInches_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.CentimetersToInches(testValue);

            // assert
            var correctValue = 0.3937;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetersToFeet_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MetersToFeet(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MetersToFeet_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MetersToFeet(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void MetersToFeet_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MetersToFeet(testValue);

            // assert
            var correctValue = 3.2808;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetersToYards_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MetersToYards(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void MetersToYards_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MetersToYards(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void MetersToYards_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.MetersToYards(testValue);

            // assert
            var correctValue = 1.0936;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KilometersToMiles_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.KilometersToMiles(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KilometersToMiles_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.KilometersToMiles(testValue);

            // assert
            var correctValue = 1.117032583209397E+308;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KilometersToMiles_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.KilometersToMiles(testValue);

            // assert
            var correctValue = 0.62137;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void KilometersToMeters_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.KilometersToMeters(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void KilometersToMeters_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.KilometersToMeters(testValue);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void KilometersToMeters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Distance.KilometersToMeters(testValue);

            // assert
            var correctValue = 1000;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetersToKilometers_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Distance.MetersToKilometers(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetersToKilometers_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Distance.MetersToKilometers(testValue);

            // assert
            var correctValue = 1.7976931348623156E+305;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void MetersToKilometers_validReturn()
        {
            // set params
            var testValue = 1000;

            // call method
            var result = Distance.MetersToKilometers(testValue);

            // assert
            var correctValue = 1;
            Assert.AreEqual(result, correctValue);
        }



        [TestCleanup]
        public void Cleanup()
        {
            // if any dispose or resets are needed
        }

    }
}
