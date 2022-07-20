using System.Xml;
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
            xml.LoadXml(path);
            return xml;
        }

        [TestMethod()]
        public void ReadFlightLogTest()
        {
            Assert.Fail();
        }
    }
}