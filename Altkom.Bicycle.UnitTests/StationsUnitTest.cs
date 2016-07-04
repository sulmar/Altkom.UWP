using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Altkom.Bicycle.UWPClient.Services;
using Altkom.Bicycle.Models;
using System.Collections.Generic;
using System.IO;

namespace Altkom.Bicycle.UnitTests
{
    [TestClass]
    public class StationsUnitTest
    {
        [TestMethod]
        public void GetStationsTest()
        {
           
            IStationsService stationsService = new XmlStationsService();
            var result = stationsService.GetStations();

            Assert.IsNotNull(result, "Nie moze byc wartosci null");

            Assert.IsTrue(result.Count > 0, "Lista jest pusta");            

        }
    }

}
