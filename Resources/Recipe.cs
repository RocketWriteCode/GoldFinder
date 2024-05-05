using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.Resources
{
    class Recipe
    {
        public List<Resource> ingredients = new List<Resource>();
        public List<Resource> output = new List<Resource>();
        public WorkInfo workInfo;
    }
}
