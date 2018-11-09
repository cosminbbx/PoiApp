using System;
using System.Collections.Generic;
using System.Text;

namespace Poi.Data
{
    public class PointOfInterest
    {
        public Guid Id { get; private set; }
        public double Latitude { get; private set; }
        public double  Longitude { get; private set; }
        public string Name { get; private set; }

        public PointOfInterest(double latitude, double longitude, string name)
        {
            Id = Guid.NewGuid();
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }
        public bool Update(double latitude, double longitude, string name)
        {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            return true;
        }
      
    }
}
