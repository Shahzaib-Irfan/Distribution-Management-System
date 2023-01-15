using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class Directions
    {
        private float Longitude;
        private float Latitude;

        public float Longitude1 { get => Longitude; set => Longitude = value; }
        public float Latitude1 { get => Latitude; set => Latitude = value; }

        public Directions(float longitude, float latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
