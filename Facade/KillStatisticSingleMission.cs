using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class KillStatisticSingleMission
    {
        public List<HasBeenDestroyedEvent> DestroyedRed = new List<HasBeenDestroyedEvent>();
        public List<List<KillStatistic_ByUnitType>> RedStatistic = new List<List<KillStatistic_ByUnitType>>();
        
        public List<HasBeenDestroyedEvent> DestroyedBlue = new List<HasBeenDestroyedEvent>();
        public List<List<KillStatistic_ByUnitType>> BlueStatistic = new List<List<KillStatistic_ByUnitType>>();
    }
}
