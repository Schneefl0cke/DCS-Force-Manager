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
        public List<LosStatistic_WholeMission> CampaignMissions = new List<LosStatistic_WholeMission> ();
        public LosStatistic_WholeMission CampaignStatistic = new LosStatistic_WholeMission ();
    }
}
