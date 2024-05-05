using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    class LocationManager
    {
        public List<Location> locations;

        public LocationManager()
        {
            locations = new List<Location>();
        }

        public void Tick()
        {
            foreach(Entity entity in locations)
            {
                entity.Tick();
            }
        }

        public void AddLocation(string name)
        {
            locations.Add(new Location(name));
        }

        public void DeleteLocation(string name)
        {
            Location toRemove;
            if(GetLocationByName(name, out toRemove))
            {
                locations.Remove(toRemove);
            }
        }

        public bool GetLocationByName(string name, out Location outLocation)
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

        public Location GetLocationByName(string name)
        {
            if(GetLocationByName(name, out Location location))
            {
                return location;
            }
            return null;
        }
    }
}
