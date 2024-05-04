﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.EntitySystem
{
    public class Location : Entity
    {
        List<Entity> SubLocations;

        public Location(string inName) : base(inName)
        {
            SubLocations = new List<Entity>();
        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }
    }
}