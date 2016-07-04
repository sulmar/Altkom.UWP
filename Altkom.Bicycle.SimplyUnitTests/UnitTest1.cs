using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Altkom.Bicycle.Services;

namespace Altkom.Bicycle.SimplyUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetStationsTest()
        {
            XmlStationsService stationsService = new XmlStationsService();
            stationsService.GetStations();


        }
    }
}
