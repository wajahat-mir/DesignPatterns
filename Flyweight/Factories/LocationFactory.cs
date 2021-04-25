using Flyweight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight.Factories
{
    class LocationFactory
    {
        public static List<LocationModel> locations;
        public LocationModel getLocation(int id)
        {
            return locations.Where(l => l.Id == id).FirstOrDefault();
        }
    }
}
