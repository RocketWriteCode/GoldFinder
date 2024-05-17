using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.Resources
{
    public class Recipe
    {
        public string name;
        public List<Resource> ingredients = new List<Resource>();
        public List<Resource> output = new List<Resource>();
        public WorkInfo workInfo = new WorkInfo();

        public Recipe(string inName, List<Resource> inIngredients, List<Resource> inOutput, WorkInfo inWorkInfo)
        {
            name = inName;
            ingredients = inIngredients;
            output = inOutput;
            workInfo = inWorkInfo;
        }

        public Recipe(string inName)
        {
            name = inName;
        }
    }
}
