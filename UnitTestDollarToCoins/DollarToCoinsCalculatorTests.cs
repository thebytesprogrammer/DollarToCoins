using DollarToCoins.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DollarToCoins.UnitTests
{
    [TestClass]
    public class DollarToCoinsCalculatorTests
    {
        [TestMethod]
        public void CalculateSilverDollars_TakesDecimal_SavesIntegerReturnsRemainder()
        {
            // Arrange
            var dToC = new DollarToCoinsCalculator();

            // Act
            var remainder = dToC.CalculateSilverDollars(31.99m);

            // Assert
            Assert.AreEqual(remainder, 99);
            Assert.AreEqual(dToC.coinsOutput.silverDollar, 31);
        }

        [TestMethod]
        public void CalculateHalfDollars_TakesInteger_SavesIntegerReturnsRemainder()
        {
            // Arrange
            var dToC = new DollarToCoinsCalculator();

            // Act
            var remainder = dToC.CalculateHalfDollars(197);

            // Assert
            Assert.AreEqual(remainder, 47);
            Assert.AreEqual(dToC.coinsOutput.halfDollar, 3);
        }

        [TestMethod]
        public void CalculateQuarters_TakesInteger_SavesIntegerReturnsRemainder()
        {
            // Arrange
            var dToC = new DollarToCoinsCalculator();

            // Act
            var remainder = dToC.CalculateQuarters(79);

            // Assert
            Assert.AreEqual(remainder, 4);
            Assert.AreEqual(dToC.coinsOutput.quarter, 3);
        }

        [TestMethod]
        public void CalculateDimes_TakesInteger_SavesIntegerReturnsRemainder()
        {
            // Arrange
            var dToC = new DollarToCoinsCalculator();

            // Act
            var remainder = dToC.CalculateDimes(171);

            // Assert
            Assert.AreEqual(remainder, 1);
            Assert.AreEqual(dToC.coinsOutput.dime, 17);
        }

        [TestMethod]
        public void CalculateNickels_TakesInteger_SavesIntegerReturnsRemainder()
        {
            // Arrange
            var dToC = new DollarToCoinsCalculator();

            // Act
            var remainder = dToC.CalculateNickles(33);

            // Assert
            Assert.AreEqual(remainder, 3);
            Assert.AreEqual(dToC.coinsOutput.nickel, 6);
        }

        [TestMethod]
        public void CalculateAllChange_TakesDecimal_SavesChange()
        {
            // Arrange
            var to1 = new CoinsOutput(0, 1, 1, 2, 0, 4);
            var to2 = new CoinsOutput(1, 1, 0, 0, 1, 1);
            var to3 = new CoinsOutput(12, 1, 1, 1, 0, 0);

            // Act
            var resObj1 = new DollarToCoins.Models.DollarToCoinsCalculator(0.99m).coinsOutput;
            var resObj2 = new DollarToCoins.Models.DollarToCoinsCalculator(1.56m).coinsOutput;
            var resObj3 = new DollarToCoins.Models.DollarToCoinsCalculator(12.85m).coinsOutput;

            // Assert
            Assert.IsTrue(resObj1.Equals(to1));
            Assert.IsTrue(resObj2.Equals(to2));
            Assert.IsTrue(resObj3.Equals(to3));
        }
    }
}
