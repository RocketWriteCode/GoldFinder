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

        public void AddOrRemoveResource(Resource resource, int count)
        {
            if (!localResources.Contains(resource)) return;

            foreach(Resource listedResource in localResources)
            {
                if (listedResource.name != resource.name) continue;
                listedResource.amount += count;

                if (listedResource.amount >= 0) continue;
                listedResource.amount = 0;
            }
        }
    }
}
