using AssetsManager;
using Facade;
using FlightLogReader;
using FlightLogReader.Sorter;
using SquadronManager;
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

        public static KillStatisticSingleMission AnalzyeSingleMission(string path, bool includePlayers, bool includeSquadrons)
        {
            var xml = ReadFlightLog(path);
            List<Player> players = new List<Player>();
            if (includePlayers)
                players = PlayerHandler.Players;

            List<Squadron> squadrons = new List<Squadron>();
            if (includeSquadrons)
                squadrons = SquadronHandler.Squadrons;

            var eventsInMission = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(xml, players, squadrons);

            var statistic = FlightLogReader.Sorter.HasBeenDestroyedEventSorter.Sort(eventsInMission);
            MissionStatistic = statistic;

            if (includePlayers)
                PlayerStatisticSorter.Sort(eventsInMission, PlayerHandler.Players);

            if (includeSquadrons)
                SquadronStatisticSorter.Sort(eventsInMission, SquadronHandler.Squadrons);

            return statistic;
        }

        //here or in Form 1?
        //public static void ExportSingleMissionStatisticAsXML(string path, KillStatisticSingleMission statistic, bool includePlayers)
        //{
        //    if (statistic != null)
        //    {
        //        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(path, statistic, includePlayers);
        //    }
        //}

        private static XmlDocument ReadFlightLog(string path)
        {
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }
    }
}