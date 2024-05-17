using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    public class Location : Entity
    {
        public readonly List<Sublocation> subLocations;

        public Location(string inName) : base(inName)
        {
            subLocations = new List<Sublocation>();
        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }

        public void AddSublocation(string inName)
        {
            subLocations.Add(new Sublocation(inName));
        }

        public void AddSublocation(Sublocation sublocation)
        {
            subLocations.Add(sublocation);
        }

        public void RemoveSublocation(string inName)
        {
            Sublocation toRemove = GetSublocationByName(inName);
            subLocations.Remove(toRemove);
        }

        public Sublocation GetSublocationByName(string inName)
        {
            foreach(Sublocation location in subLocations)
            {
                if(location.name == inName)
                {
                    return location;
                }
            }
            return null;
        }

        public bool GetSublocationByName(string inName, out Sublocation outSublocation)
        {
            outSublocation = GetSublocationByName(inName);
            if(outSublocation != null)
            {
                return true;
            }
            return false;
        }
    }
}
