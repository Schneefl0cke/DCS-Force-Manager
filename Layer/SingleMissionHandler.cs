using Facade;
using FlightLogReader;
using System.Xml;

namespace Layer
{
    //TODO: 1. analyze single mission + display
    //2. add campaign feature + analyze campaign stuff
    //3. add squadron + squadron statistic
    //4. add player statistics
    public static class SingleMissionHandler
    {
        public static KillStatisticSingleMission? MissionStatistic;

        public static KillStatisticSingleMission AnalzyeSingleMission(string path)
        {

            var xml = ReadFlightLog(path);
            var eventsInMission = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(xml);
            var statistic = FlightLogReader.Sorter.HasBeenDestroyedEventSorter.Sort(eventsInMission);
            MissionStatistic = statistic;
            return statistic;
        }

        public static void ExportSingleMissionStatisticAsXML(string path, KillStatisticSingleMission statistic)
        {
            if (statistic != null)
            {
                CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(path, statistic);
            }
        }

        private static XmlDocument ReadFlightLog(string path)
        {
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }
    }
}