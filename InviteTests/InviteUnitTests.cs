using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Invite;
using System.IO;
using System.Text;

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

        [TestMethod]
        public void DeserializeCanDeserializeJsonObjectsFromStreamReader()
        {
            StreamReader mockStreamReader = CreateMockStream();
            
        }

        private static StreamReader CreateMockStream()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("{\"latitude\": \"52.986375\", \"user_id\": 12, \"name\": \"Christina McArdle\", \"longitude\": \"-6.043701\"}");
            stringBuilder.AppendLine("{\"latitude\": \"51.92893\", \"user_id\": 1, \"name\": \"Alice Cahill\", \"longitude\": \"-10.27699\"}");

            var streamReader = new StreamReader(new MemoryStream(Encoding.ASCII.GetBytes(stringBuilder.ToString())));
            return streamReader;
        }
    }
}
