using System.Xml;

namespace Layer
{
    //TODO: 1. analyze single mission + display
    //2. add campaign feature + analyze campaign stuff
    //3. add squadron + squadron statistic
    //4. add player statistics
    public class Layer
    {
        public XmlDocument ReadFlightLog(string path)
        {
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }
    }
}