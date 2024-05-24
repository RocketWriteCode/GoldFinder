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

        public Resource(string inName, double inPriceInGold)
        {
            name = inName;
            priceInGold = inPriceInGold;
        }

        public Resource(string inName)
        {
            name = inName;
        }
    }
}
