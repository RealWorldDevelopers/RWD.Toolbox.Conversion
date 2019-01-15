using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RWD.Toolbox.Conversion.Test
{
    [TestClass]
    public class VolumeTest
    {
        [TestInitialize]
        public void Setup() { }

      
        [TestMethod]
        public void GallonsToQuarts_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Volume.GallonsToQuarts(testValue);

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
            var result = Volume.GallonsToQuarts(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToQuarts_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.GallonsToQuarts(testValue);

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
            var result = Volume.QuartsToGallons(testValue);

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
            var result = Volume.QuartsToGallons(testValue);

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
            var result = Volume.QuartsToGallons(testValue);

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
            var result = Volume.GallonsToPints(testValue);

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
            var result = Volume.GallonsToPints(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToPints_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.GallonsToPints(testValue);

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
            var result = Volume.PintsToGallons(testValue);

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
            var result = Volume.PintsToGallons(testValue);

            var correctValue = 2.2471164185778946E+307;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void PintsToGallons_validReturn()
        {
            // set params
            var testValue = 8;

            // call method
            var result = Volume.PintsToGallons(testValue);

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
            var result = Volume.GallonsToCups(testValue);

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
            var result = Volume.GallonsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.GallonsToCups(testValue);

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
            var result = Volume.CupsToGallons(testValue);

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
            var result = Volume.CupsToGallons(testValue);

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
            var result = Volume.CupsToGallons(testValue);

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
            var result = Volume.GallonsToOunces(testValue);

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
            var result = Volume.GallonsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.GallonsToOunces(testValue);

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
            var result = Volume.OuncesToGallons(testValue);

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
            var result = Volume.OuncesToGallons(testValue);

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
            var result = Volume.OuncesToGallons(testValue);

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
            var result = Volume.QuartsToPints(testValue);

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
            var result = Volume.QuartsToPints(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToPints_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.QuartsToPints(testValue);

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
            var result = Volume.PintsToQuarts(testValue);

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
            var result = Volume.PintsToQuarts(testValue);

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
            var result = Volume.PintsToQuarts(testValue);

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
            var result = Volume.QuartsToCups(testValue);

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
            var result = Volume.QuartsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.QuartsToCups(testValue);

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
            var result = Volume.CupsToQuarts(testValue);

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
            var result = Volume.CupsToQuarts(testValue);

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
            var result = Volume.CupsToQuarts(testValue);

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
            var result = Volume.QuartsToOunces(testValue);

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
            var result = Volume.QuartsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void QuartsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.QuartsToOunces(testValue);

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
            var result = Volume.OuncesToQuarts(testValue);

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
            var result = Volume.OuncesToQuarts(testValue);

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
            var result = Volume.OuncesToQuarts(testValue);

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
            var result = Volume.PintsToCups(testValue);

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
            var result = Volume.PintsToCups(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PintsToCups_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.PintsToCups(testValue);

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
            var result = Volume.CupsToPints(testValue);

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
            var result = Volume.CupsToPints(testValue);

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
            var result = Volume.CupsToPints(testValue);

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
            var result = Volume.PintsToOunces(testValue);

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
            var result = Volume.PintsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void PintsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.PintsToOunces(testValue);

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
            var result = Volume.OuncesToPints(testValue);

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
            var result = Volume.OuncesToPints(testValue);

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
            var result = Volume.OuncesToPints(testValue);

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
            var result = Volume.CupsToOunces(testValue);

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
            var result = Volume.CupsToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void CupsToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.CupsToOunces(testValue);

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
            var result = Volume.OuncesToCups(testValue);

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
            var result = Volume.OuncesToCups(testValue);

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
            var result = Volume.OuncesToCups(testValue);

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
            var result = Volume.OuncesToTablespoons(testValue);

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
            var result = Volume.OuncesToTablespoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToTablespoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.OuncesToTablespoons(testValue);

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
            var result = Volume.TablespoonsToOunces(testValue);

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
            var result = Volume.TablespoonsToOunces(testValue);

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
            var result = Volume.TablespoonsToOunces(testValue);

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
            var result = Volume.OuncesToTeaspoons(testValue);

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
            var result = Volume.OuncesToTeaspoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToTeaspoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.OuncesToTeaspoons(testValue);

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
            var result = Volume.TeaspoonsToOunces(testValue);

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
            var result = Volume.TeaspoonsToOunces(testValue);

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
            var result = Volume.TeaspoonsToOunces(testValue);

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
            var result = Volume.TablespoonsToTeaspoons(testValue);

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
            var result = Volume.TablespoonsToTeaspoons(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TablespoonsToTeaspoons_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.TablespoonsToTeaspoons(testValue);

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
            var result = Volume.TeaspoonsToTablespoons(testValue);

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
            var result = Volume.TeaspoonsToTablespoons(testValue);

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
            var result = Volume.TeaspoonsToTablespoons(testValue);

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
            var result = Volume.LitersToMilliLiters(testValue);

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
            var result = Volume.LitersToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.LitersToMilliLiters(testValue);

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
            var result = Volume.MilliLitersToLiters(testValue);

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
            var result = Volume.MilliLitersToLiters(testValue);

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
            var result = Volume.MilliLitersToLiters(testValue);

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
            var result = Volume.LitersToGallons(testValue);

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
            var result = Volume.LitersToGallons(testValue);

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
            var result = Volume.LitersToGallons(testValue);

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
            var result = Volume.GallonsToLiters(testValue);

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
            var result = Volume.GallonsToLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void GallonsToLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.GallonsToLiters(testValue);

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
            var result = Volume.LitersToQuarts(testValue);

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
            var result = Volume.LitersToQuarts(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToQuarts_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.LitersToQuarts(testValue);

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
            var result = Volume.QuartsToLiters(testValue);

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
            var result = Volume.QuartsToLiters(testValue);

            // assert
            var correctValue = 1.7012521941809277E+308;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void QuartsToLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.QuartsToLiters(testValue);

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
            var result = Volume.LitersToOunces(testValue);

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
            var result = Volume.LitersToOunces(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void LitersToOunces_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.LitersToOunces(testValue);

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
            var result = Volume.OuncesToLiters(testValue);

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
            var result = Volume.OuncesToLiters(testValue);

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
            var result = Volume.OuncesToLiters(testValue);

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
            var result = Volume.MilliLitersToOunces(testValue);

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
            var result = Volume.MilliLitersToOunces(testValue);

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
            var result = Volume.MilliLitersToOunces(testValue);

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
            var result = Volume.OuncesToMilliLiters(testValue);

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
            var result = Volume.OuncesToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void OuncesToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.OuncesToMilliLiters(testValue);

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
            var result = Volume.MilliLitersToTablespoons(testValue);

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
            var result = Volume.MilliLitersToTablespoons(testValue);

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
            var result = Volume.MilliLitersToTablespoons(testValue);

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
            var result = Volume.TablespoonsToMilliLiters(testValue);

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
            var result = Volume.TablespoonsToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TablespoonsToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.TablespoonsToMilliLiters(testValue);

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
            var result = Volume.MilliLitersToTeaspoons(testValue);

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
            var result = Volume.MilliLitersToTeaspoons(testValue);

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
            var result = Volume.MilliLitersToTeaspoons(testValue);

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
            var result = Volume.TeaspoonsToMilliLiters(testValue);

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
            var result = Volume.TeaspoonsToMilliLiters(testValue);

            // assert is handled by ExpectedException 
        }

        [TestMethod]
        public void TeaspoonsToMilliLiters_validReturn()
        {
            // set params
            var testValue = 1;

            // call method
            var result = Volume.TeaspoonsToMilliLiters(testValue);

            // assert
            var correctValue = 4.92892159;
            Assert.AreEqual(result, correctValue);
        }

   
        [TestCleanup]
        public void Cleanup()
        {
            // if any dispose or resets are needed
        }
    }
}
