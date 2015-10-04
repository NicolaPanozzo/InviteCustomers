using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invite
{
    //map to JSON objects
    class Customer
    {
        public double Latitude { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }

        public GPSPoint GetCustomerLocation()
        {
            GPSPoint customerLocation = new GPSPoint(Latitude * Math.PI / 180,
                        Longitude * Math.PI / 180);
            return customerLocation;
        }
    }
}
