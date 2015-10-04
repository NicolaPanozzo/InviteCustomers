using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Invite;

namespace InviteTests
{
    [TestClass]
    public class InviteUnitTests
    {
        [TestMethod]
        public void DistanceReturnsCorrectDistance()
        {
            double latitude1 = 0.929302344;
            double longitude1 = -0.108879486;
            double latitude2 = 0.930927181;
            double longitude2 = -0.109244654;

            double expectedDistance = 10.444825879238;

            GPSPoint point1 = new GPSPoint(latitude1, longitude1);
            GPSPoint point2 = new GPSPoint(latitude2, longitude2);

            double actualDistance = point1.Distance(point2);

            Assert.AreEqual(expectedDistance, actualDistance, 0.000001, "Distance not calculated correctly");

        }
    }
}
