using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DollarToCoins.Models
{
    public class DollarToCoinsCalculator
    {
        public Decimal dollarInput { get; set; }
        public CoinsOutput coinsOutput { get; set; }

        public DollarToCoinsCalculator()
        {
            coinsOutput = new CoinsOutput();
        }

        public DollarToCoinsCalculator(Decimal _dollarInput)
        {
            try
            {
                dollarInput = _dollarInput;
                coinsOutput = new CoinsOutput();

                Calculate();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public CoinsOutput Calculate()
        {
            try
            {
                int remainderInPennies = CalculateSilverDollars(dollarInput);

                remainderInPennies = CalculateHalfDollars(remainderInPennies);

                remainderInPennies = CalculateQuarters(remainderInPennies);

                remainderInPennies = CalculateDimes(remainderInPennies);

                remainderInPennies = CalculateNickles(remainderInPennies);

                // After all other calculations are done, just consider the leftover.
                this.coinsOutput.penny = remainderInPennies;

                return coinsOutput;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculates how many silver dollars are in input
        // and returns the remainder.
        public int CalculateSilverDollars(Decimal _dollarInput)
        {
            try
            {
                this.coinsOutput.silverDollar = (int)_dollarInput;

                return (int)((decimal)_dollarInput % 1.0m * 100);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculates how many half dollar coins are in the remainder
        // and returns the remainder of the previous remainder
        public int CalculateHalfDollars(int remainder)
        {
            try
            {
                this.coinsOutput.halfDollar = (int) remainder / 50;

                return (int)(remainder % 50);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculates how many quarter coins are in the remainder
        // and returns the remainder of the previous remainder
        public int CalculateQuarters(int remainder)
        {
            try
            {
                this.coinsOutput.quarter = (int)remainder / 25;

                return (int)(remainder % 25);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculates how many dime coins are in the remainder
        // and returns the remainder of the previous remainder
        public int CalculateDimes(int remainder)
        {
            try
            {
                this.coinsOutput.dime = (int)remainder / 10;

                return (int)(remainder % 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculates how many nickle coins are in the remainder
        // and returns the remainder of the previous remainder
        public int CalculateNickles(int remainder)
        {
            try
            {
                this.coinsOutput.nickel = (int)remainder / 5;

                return (int)(remainder % 5);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
