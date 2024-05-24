using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldFinder.Resources;

namespace GoldFinder.EntitySystem
{
    public class Sublocation : Entity
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<Resource> localResources = new List<Resource>();
        double localGold = 0;

        public Sublocation(string inName) : base(inName)
        {

        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }

        public void ChangeGold(double gold)
        {
            localGold += gold;
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DeleteRecipe(string recipeName)
        {
            List<Recipe> toDelete = new List<Recipe>();
            foreach(Recipe recipe in recipes)
            {
                if(recipe.name == recipeName)
                {
                    toDelete.Add(recipe);
                }
            }

            foreach(Recipe recipe in toDelete)
            {
                recipes.Remove(recipe);
            }
        }

        public Recipe GetRecipeByName(string name)
        {
            foreach(Recipe recipe in recipes)
            {
                if(recipe.name == name)
                {
                    return recipe;
                }
            }

            return null;
        }
    }
}
