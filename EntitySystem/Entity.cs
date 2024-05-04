using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    abstract class Entity
    {
        public string name;

        public Entity(string inName)
        {
            name = inName;
        }

        public abstract void Tick();
    }
}
