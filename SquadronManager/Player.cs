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
        public List<SimpleKillStatistic> CurrentMissionKills = new List<SimpleKillStatistic>();
        public List<SimpleKillStatistic> SummaryOfAllMissions = new List<SimpleKillStatistic>();
        //Future: killed by
        //Ammonition used
    }
}
