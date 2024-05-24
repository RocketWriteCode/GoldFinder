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
            DeleteResourceFromListByName(ingredients, name);
        }

        public void DeleteOutputByName(string name)
        {
            DeleteResourceFromListByName(output, name);
        }

        private void DeleteResourceFromListByName(List<Resource> list, string name)
        {
            List<Resource> toDelete = new List<Resource>();
            foreach(Resource resource in list)
            {
                if(resource.name == name)
                {
                    toDelete.Add(resource);
                }
            }

            foreach(Resource resource in toDelete)
            {
                list.Remove(resource);
            }
        }

        private Resource GetResourceFromListByName(List<Resource> list, string name)
        {
            foreach(Resource resource in list)
            {
                if (resource == null) continue;
                if (resource.name != name) continue;
                return resource;
            }

            return null;
        }

        public Resource GetIngredientByName(string name)
        {
            return GetResourceFromListByName(ingredients, name);
        }

        public void ReplaceIngredient(Resource oldIngredient, Resource newIngredient)
        {
            if (!ingredients.Contains(oldIngredient)) return;

            ingredients.Remove(oldIngredient);
            ingredients.Add(newIngredient);
        }

        public void ReplaceIngredient(string oldName, string newName)
        {
            Resource oldResource = ResourceManager.GetResourceByName(oldName);
            Resource newResource = ResourceManager.GetResourceByName(newName);
            ReplaceIngredient(oldResource, newResource);
        }
    }
}
