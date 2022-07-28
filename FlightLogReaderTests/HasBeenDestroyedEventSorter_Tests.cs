using FlightLogReader.Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CXmlWriter;
using AssetsManager;

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

        //manual test
        [TestMethod]
        public void Sort_Test()
        {
            var hasBeenDestroyedEvents = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(ReadXml(), new List<Player>());
            var statistic = HasBeenDestroyedEventSorter.Sort(hasBeenDestroyedEvents);

            var d_Allies = statistic.DestroyedRed;
           Assert.IsNotNull(d_Allies);

            var d_Enemies = statistic.DestroyedBlue;
            Assert.IsNotNull(d_Enemies);

            var safePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            WriteCxml.WriteKillStatistics_SingleMission(safePath, statistic);
        }
    }
}
