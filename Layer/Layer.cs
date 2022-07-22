using System.Xml;

namespace Layer
{
    public class Class1
    {
        public XmlDocument ReadFlightLog(string path)
        {
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }
    }
}