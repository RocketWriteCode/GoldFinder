using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    public class Location : Entity
    {
        public readonly List<SubLocation> subLocations;

        public Location(string inName) : base(inName)
        {
            subLocations = new List<SubLocation>();
        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }

        public void AddSublocation(string inName)
        {
            subLocations.Add(new SubLocation(inName));
        }

        public void RemoveSublocation(string inName)
        {
            SubLocation toRemove = GetSublocationByName(inName);
            subLocations.Remove(toRemove);
        }

        SubLocation GetSublocationByName(string inName)
        {
            foreach(SubLocation location in subLocations)
            {
                if(location.name == inName)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
