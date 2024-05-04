using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    class EntityManager
    {
        public List<Entity> entities;

        public EntityManager()
        {
            entities = new List<Entity>();
        }

        public void Tick()
        {
            foreach(Entity entity in entities)
            {
                entity.Tick();
            }
        }

        public void AddLocation(string name)
        {
            entities.Add(new Location(name));
        }

        public void DeleteLocation(string name)
        {
            Entity toRemove;
            if(GetLocationByName(name, out toRemove))
            {
                entities.Remove(toRemove);
            }
        }

        public bool GetLocationByName(string name, out Entity outEntity)
        {
            foreach(Entity entity in entities)
            {
                if(entity.name == name)
                {
                    outEntity = entity;
                    return true;
                }
            }
            outEntity = null;
            return false;
        }
    }
}
