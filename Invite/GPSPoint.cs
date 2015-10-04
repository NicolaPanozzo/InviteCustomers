using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invite
{
    struct GPSPoint
    {
        //GPS coordinates in radians
        private double latitude;
        private double longitude;

        public GPSPoint(double lt, double lg)
        {
            latitude = lt;
            longitude = lg;
        }

        //calculate distance bewteen two GPS points
        public double Distance(GPSPoint point)
        {
            double distance;
            //earth radius in KM
            const int earthRadius = 6371;
            double deltaLongitude = Math.Abs(longitude - point.longitude);
            double deltaSigma = Math.Acos(Math.Sin(point.latitude) * Math.Sin(latitude) +
                    Math.Cos(point.latitude) * Math.Cos(latitude) * Math.Cos(deltaLongitude));
            distance = earthRadius * deltaSigma;

            return distance;
        }
    }
}
