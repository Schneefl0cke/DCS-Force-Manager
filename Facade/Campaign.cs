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
        public List<(int missionCount, KillStatisticSingleMission missionstatistic)> Campaignstatistic = new List<(int missionCount, KillStatisticSingleMission missionstatistic)> ();
        public KillStatisticSingleMission CampaignStatistic = new KillStatisticSingleMission ();
    }
}
