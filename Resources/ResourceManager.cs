using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.Resources
{
    public static class ResourceManager
    {
        static List<Resource> globalResources = new List<Resource>();

        public static void AddResource(Resource toBeAdded)
        {
            globalResources.Add(toBeAdded);
        }

        public static void RemoveResource(Resource toBeRemoved)
        {
            globalResources.Remove(toBeRemoved);
        }

        public static void RemoveResource(string name)
        {
            Resource toBeRemoved = GetResourceByName(name);

            if (toBeRemoved == null) return;

            RemoveResource(toBeRemoved);
        }

        public static List<Resource> GetAllGlobalResources()
        {
            List<Resource> output = new List<Resource>();
            output.AddRange(globalResources);
            return output;
        }

        public static void RenameResource(Resource target, string name)
        {
            Resource globalTarget = GetResourceByName(target.name);
            globalTarget.name = name;
        }

        public static void RenameResource(string targetName, string name)
        {
            Resource target = GetResourceByName(targetName);
            RenameResource(target, name);
        }

        static Resource GetResourceByName(string name)
        {
            if (name == "" || name == null) return null;

            Resource result = null;

            foreach (Resource resource in globalResources)
            {
                if (name != resource.name) continue;
                result = resource;
            }

            return result;
        }
    }
}
