using FlightLogReader.Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CXmlWriter;

namespace FlightLogReaderTests
{
    [TestClass]
    public class HasBeenDestroyedEventSorter_Tests
    {
        public XmlDocument ReadXml()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "FlightLog.xml");
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }

        [TestMethod]
        public void Sort_Test()
        {
            var hasBeenDestroyedEvents = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(ReadXml());
            var statistic = HasBeenDestroyedEventSorter.Sort(hasBeenDestroyedEvents);

            var d_Allies = statistic.DestroyedAllies;
           Assert.IsNotNull(d_Allies);

            var d_Enemies = statistic.DestroyedEnemies;
            Assert.IsNotNull(d_Enemies);

            var safePath = "C:\\Users\\z003ddaz\\Desktop\\testXlsLib\\test";
            WriteCxml.WriteKillStatistics_SingleMission(safePath, statistic);
        }
    }
}
