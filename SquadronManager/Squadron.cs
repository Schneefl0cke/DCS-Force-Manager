using Facade;

namespace SquadronManager
{
    public class Squadron
    {
        public string Name { get; set; }
        public int Deaths { get; set; } = 0;
        public List<PlayerStatistic_ByUnitType> CurrentMissionKills = new List<PlayerStatistic_ByUnitType>();
        public List<PlayerStatistic_ByUnitType> CompleteKillStatistic = new List<PlayerStatistic_ByUnitType>();
    }
}