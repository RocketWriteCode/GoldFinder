using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.Resources
{
    public class Resource
    {
        public string name;
        public double priceInGold;
        public int amount;

        public Resource(string inName, double inPriceInGold, int inAmount)
        {
            name = inName;
            priceInGold = inPriceInGold;
            amount = inAmount;
        }

        public Resource(string inName)
        {
            name = inName;
        }
    }
}
