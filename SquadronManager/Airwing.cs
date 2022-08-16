using Facade;

namespace SquadronManager
{
    public class Airwing
    {
        public string Name { get; set; }
        public List<SimpleKillStatistic> CurrentMissionKills = new List<SimpleKillStatistic>();
        public List<SimpleKillStatistic> CurrentMissionLosses = new List<SimpleKillStatistic>();
        public List<SimpleKillStatistic> SummaryOfAllMissions = new List<SimpleKillStatistic>();
        public List<SimpleKillStatistic> SummaryLossesallMissions = new List<SimpleKillStatistic>();

    }
}