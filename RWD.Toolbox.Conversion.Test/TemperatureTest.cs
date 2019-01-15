using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace RWD.Toolbox.Conversion.Test
{
    [TestClass]
    public class TemperatureTest
    {

        [TestInitialize]
        public void Setup() { }

        [TestMethod]
        public void ConvertCelsiusToFahrenheit_freezing()
        {
            // set params
            var testValue = 0;

            // call method
            var result = Temperature.ConvertCelsiusToFahrenheit(testValue);

            // assert
            var correctValue = 32;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelsiusToFahrenheit_boiling()
        {
            // set params
            var testValue = 100;

            // call method
            var result = Temperature.ConvertCelsiusToFahrenheit(testValue);

            // assert
            var correctValue = 212;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelsiusToFahrenheit_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertCelsiusToFahrenheit(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertCelsiusToFahrenheit_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertCelsiusToFahrenheit(testValue);

            // assert is handled by ExpectedException 
        }


        [TestMethod]
        public void ConvertFahrenheitToCelsius_freezing()
        {
            // set params
            var testValue = 32;

            // call method
            var result = Temperature.ConvertFahrenheitToCelsius(testValue);

            // assert
            var correctValue = 0;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelsius_boiling()
        {
            // set params
            var testValue = 212;

            // call method
            var result = Temperature.ConvertFahrenheitToCelsius(testValue);

            // assert
            var correctValue = 100;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelsius_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertFahrenheitToCelsius(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertFahrenheitToCelsius_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertFahrenheitToCelsius(testValue);


            // Assert - Expects exception
        }

        [TestMethod]
        public void ConvertFahrenheitToKelvin_freezing()
        {
            // set params
            var testValue = 32;

            // call method
            var result = Temperature.ConvertFahrenheitToKelvin(testValue);

            // assert
            var correctValue = 273.15;
            Assert.AreEqual(result, correctValue);
        }


        [TestMethod]
        public void ConvertFahrenheitToKelvin_boiling()
        {
            // set params
            var testValue = 212;

            // call method
            var result = Temperature.ConvertFahrenheitToKelvin(testValue);

            // assert
            var correctValue = 373.15;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertFahrenheitToKelvin_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertFahrenheitToKelvin(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertFahrenheitToKelvin_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertFahrenheitToKelvin(testValue);


            // Assert - Expects exception
        }


        [TestMethod]
        public void ConvertCelsiusToKelvin_freezing()
        {
            // set params
            var testValue = 0;

            // call method
            var result = Temperature.ConvertCelsiusToKelvin(testValue);

            // assert
            var correctValue = 273.15;
            Assert.AreEqual(result, correctValue);
        }


        [TestMethod]
        public void ConvertCelsiusToKelvin_boiling()
        {
            // set params
            var testValue = 100;

            // call method
            var result = Temperature.ConvertCelsiusToKelvin(testValue);

            // assert
            var correctValue = 373.15;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelsiusToKelvin_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertCelsiusToKelvin(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertCelsiusToKelvin_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertCelsiusToKelvin(testValue);


            // assert
            double? correctValue = 1.7976931348623157E+308;
            Assert.AreEqual(result, correctValue);
        }


        [TestMethod]
        public void ConvertKelvinToFahrenheit_freezing()
        {
            // set params
            var testValue = 273.15;

            // call method
            var result = Temperature.ConvertKelvinToFahrenheit(testValue);

            // assert
            var correctValue = 32;
            Assert.AreEqual(result, correctValue);
        }


        [TestMethod]
        public void ConvertKelvinToFahrenheit_boiling()
        {
            // set params
            var testValue = 373.15;

            // call method
            var result = Temperature.ConvertKelvinToFahrenheit(testValue);

            // assert
            var correctValue = 212;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertKelvinToFahrenheit_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertKelvinToFahrenheit(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertKelvinToFahrenheit_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertKelvinToFahrenheit(testValue);


            // Assert - Expects exception
        }

        //ConvertKelvinToCelsius
        [TestMethod]
        public void ConvertKelvinToCelsius_freezing()
        {
            // set params
            var testValue = 273.15;

            // call method
            var result = Temperature.ConvertKelvinToCelsius(testValue);

            // assert
            var correctValue = 0;
            Assert.AreEqual(result, correctValue);
        }


        [TestMethod]
        public void ConvertKelvinToCelsius_boiling()
        {
            // set params
            var testValue = 373.15;

            // call method
            var result = Temperature.ConvertKelvinToCelsius(testValue);

            // assert
            var correctValue = 100;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertKelvinToCelsius_null()
        {
            // set params
            double? testValue = null;

            // call method
            var result = Temperature.ConvertKelvinToCelsius(testValue);

            // assert
            double? correctValue = null;
            Assert.AreEqual(result, correctValue);
        }

        [TestMethod]
        public void ConvertKelvinToCelsius_maxDouble()
        {
            // set params
            var testValue = double.MaxValue;

            // call method
            var result = Temperature.ConvertKelvinToCelsius(testValue);


            // assert
            double? correctValue = 1.7976931348623157E+308;
            Assert.AreEqual(result, correctValue);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // if any dispose or resets are needed
        }


    }
}
