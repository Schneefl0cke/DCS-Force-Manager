﻿using AssetsManager;
using Facade;
using FlightLogReader.Sorter;
using SquadronManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Layer
{
    public static class CampaignHandler
    {
        public static Campaign Campaign = new Campaign();

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
            var statistic = HasBeenDestroyedEventSorter.Sort(eventsInMission);
            
            Campaign.CampaignMissions.Add(statistic);

            if (includePlayers)
                PlayerStatisticSorter.Sort(eventsInMission, PlayerHandler.Players);

            if (includeSquadrons)
                SquadronStatisticSorter.Sort(eventsInMission, SquadronHandler.Squadrons);

            CalculateCampaignStatistic();

            return statistic;
        }

        public static void CalculateCampaignStatistic()
        {
            var completeStatistic = new KillStatisticSingleMission();
            foreach (var mission in Campaign.CampaignMissions)
            {
                completeStatistic = HasBeenDestroyedEventSorter.MergeMissions(mission, completeStatistic);
            }
            Campaign.CampaignStatistic = completeStatistic;
        }

        private static XmlDocument ReadFlightLog(string path)
        {
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }

        public static void SaveCampaign(string path)
        {
            path = Path.Combine(path);

            XmlSerializer serializer = new XmlSerializer(typeof(Campaign));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Campaign);
            }
        }

        public static void LoadCampaign(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Campaign));

                using (TextReader writer = new StreamReader(path))
                {
                    Campaign = (Campaign)serializer.Deserialize(writer);
                }
            }
        }

        //Analyze Campaign Mission (like single mission)

        //Analyze all Campaigns (concat all lists, then like single mission), increase counter
    }
}
