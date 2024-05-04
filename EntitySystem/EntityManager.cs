using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    class EntityManager
    {
        List<Entity> entities;

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

        public void RegisterEntity(Entity entity)
        {
            entities.Add(entity);
        }

        public void DeregisterEntity(Entity entity)
        {
            entities.Remove(entity);
        }
    }
}
