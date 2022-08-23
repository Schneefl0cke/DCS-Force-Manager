using System.Text;
using System.Xml;
using AssetsManager;
using FlightLogReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightLogReaderTests
{
    [TestClass()]
    public class ReaderTests
    {
        public XmlDocument ReadXml()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "FlightLog.xml");
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }

        [TestMethod()]
        public void ReadFlightLogTest_HasBeenDestroyedEvents()
        {
            var hasBeenDestroyedEvents = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(ReadXml(), new List<Player>(), new List<SquadronManager.Squadron>());
            Assert.IsTrue(hasBeenDestroyedEvents.Count > 0);
        }
    }
}