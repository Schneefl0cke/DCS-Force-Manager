using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    [Serializable]
    public class Campaign
    {
        public List<KillStatisticSingleMission> CampaignMissions = new List<KillStatisticSingleMission> ();
        public KillStatisticSingleMission CampaignStatistic = new KillStatisticSingleMission ();
    }
}
