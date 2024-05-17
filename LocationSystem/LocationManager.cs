using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    public static class LocationManager
    {
        public static List<Location> locations = new List<Location>();

        public static void Tick()
        {
            foreach(Entity entity in locations)
            {
                entity.Tick();
            }
        }

        public static void AddLocation(string name)
        {
            locations.Add(new Location(name));
        }

        public static void AddLocation(Location location)
        {
            locations.Add(location);
        }

        public static void DeleteLocation(string name)
        {
            if(GetLocationByName(name, out Location toRemove))
            {
                locations.Remove(toRemove);
            }
        }

        public static bool GetLocationByName(string name, out Location outLocation)
        {
            foreach(Location location in locations)
            {
                if(location.name == name)
                {
                    outLocation = location;
                    return true;
                }
            }
            outLocation = null;
            return false;
        }

        public static Location GetLocationByName(string name)
        {
            if(GetLocationByName(name, out Location location))
            {
                return location;
            }
            return null;
        }

        public static void Clear()
        {
            locations.Clear();
        }
    }
}
