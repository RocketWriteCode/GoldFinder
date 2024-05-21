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

        public void DeleteIngredientByName(string name)
        {
            List<Resource> toDelete = new List<Resource>();
            foreach(Resource ingredient in ingredients)
            {
                if(ingredient.name == name)
                {
                    toDelete.Add(ingredient);
                }
            }

            foreach(Resource delete in toDelete)
            {
                ingredients.Remove(delete);
            }
        }
    }
}
