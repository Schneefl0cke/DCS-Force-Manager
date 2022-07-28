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
        public int Deaths { get; set; } = 0;
        public List<KillStatistic_ByUnitType> CurrentMissionKills = new List<KillStatistic_ByUnitType>();
        public List<KillStatistic_ByUnitType> KillStatistic = new List<KillStatistic_ByUnitType>();
        //Future: killed by
        //Ammonition used
    }
}
