using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMapProject;

namespace RouteSearchSystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // private Map map = new Map();
        [TestMethod]
        public void LoadFile()
        {
            Map map = new Map("nederland");
            map.CreateAMap();
            Assert.AreEqual(map.Cities.Count, 31);
        }

        [TestMethod]
        public void LeastStopRoute()
        {
            Map map = new Map("nederland");
            map.CreateAMap();

            LeastStopRoute route = new LeastStopRoute();

            List<string> resultShouldBe = new List<string>();

            // test the least stop route from "Breda" to "DenHaag"
            route.Calculate(map.Cities[6], map.Cities[9]);

            List<string> cityNames = route.ResultRoute.Stations.Select(c => c.Name).ToList();
            resultShouldBe.Add("Breda");
            resultShouldBe.Add("Utrecht");
            resultShouldBe.Add("DenHaag");
            CollectionAssert.AreEqual(cityNames, resultShouldBe);


            // test the least stop route from "Eindhoven" to "Leeuwarden"
            route.Calculate(map.Cities[7], map.Cities[17]);

            cityNames.Clear();
            cityNames.AddRange(route.ResultRoute.Stations.Select(c => c.Name));
            resultShouldBe.Clear();
            resultShouldBe.Add("Eindhoven");
            resultShouldBe.Add("DenBosch");
            resultShouldBe.Add("Utrecht");
            resultShouldBe.Add("Amersfoort");
            resultShouldBe.Add("Zwolle");
            resultShouldBe.Add("Leeuwarden");

            CollectionAssert.AreEqual(cityNames, resultShouldBe);

            // test the least stop route from "Harlingen" to "Nijmegen"
            route.Calculate(map.Cities[14], map.Cities[21]);
            cityNames.Clear();
            cityNames.AddRange(route.ResultRoute.Stations.Select(c => c.Name));
            resultShouldBe.Clear();
            resultShouldBe.Add("Harlingen");
            resultShouldBe.Add("Leeuwarden");
            resultShouldBe.Add("Zwolle");
            resultShouldBe.Add("Apeldoorn");
            resultShouldBe.Add("Arnhem");
            resultShouldBe.Add("Nijmegen");

            CollectionAssert.AreEqual(cityNames, resultShouldBe);
        }

        [TestMethod]
        public void RandomRoute()
        {
            Map map = new Map("nederland");
            map.CreateAMap();
            RandomRoute route = new RandomRoute();

            // test the least stop route from "Breda" to "DenHaag"
            route.Calculate(map.Cities[6], map.Cities[9]);
            Assert.AreNotEqual(route.ResultRoute.Stations.Count, 0);
        }

        [TestMethod]
        public void RandomRouteLongDistance()
        {
            Map map = new Map("nederland");
            map.CreateAMap();
            RandomRoute route = new RandomRoute();

            // test the least stop route from "Leeuwarden" to "Eindhoven"
            route.Calculate(map.Cities[17], map.Cities[7]);
            Assert.AreNotEqual(route.ResultRoute.Stations.Count, 0);
        }
    }
}
