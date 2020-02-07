using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DollarToCoins.Models
{
    public class CoinsOutput
    {
        public int silverDollar { get; set; }
        public int halfDollar { get; set; }
        public int quarter { get; set; }
        public int dime { get; set; }
        public int nickel { get; set; }
        public int penny { get; set; }

        public CoinsOutput() { }

        public CoinsOutput(int _silverDollar, int _halfDollar, int _quarter,
                           int _dime, int _nickel, int _penny)
        {
            this.silverDollar = _silverDollar;
            this.halfDollar = _halfDollar;
            this.quarter = _quarter;
            this.dime = _dime;
            this.nickel = _nickel;
            this.penny = _penny;
        }

        public bool Equals(CoinsOutput co)
        {
            return (this.silverDollar == co.silverDollar &&
                    this.halfDollar == co.halfDollar &&
                    this.quarter == co.quarter &&
                    this.dime == co.dime &&
                    this.nickel == co.nickel &&
                    this.penny == co.penny);
        }
    }
}
