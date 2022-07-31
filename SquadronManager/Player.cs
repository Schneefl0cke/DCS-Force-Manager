using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManager
{
    [Serializable]
    public class Player
    {
        //Muss ein Objekt sein, das man speichern kann. AddPlayer Statistics, + AddSquadron Statistics addieren die Statistic auf. Edit Player muss möglich sein! (Custom Form)
        public string Name { get; set; } = "";
        public int Missions { get; set; } = 0;
        public int Deaths { get; set; } = 0; //TODO: flesh out later
        public List<PlayerStatistic_ByUnitType> CurrentMissionKills = new List<PlayerStatistic_ByUnitType>();
        public List<PlayerStatistic_ByUnitType> KillStatistic = new List<PlayerStatistic_ByUnitType>();
        //Future: killed by
        //Ammonition used
    }
}
