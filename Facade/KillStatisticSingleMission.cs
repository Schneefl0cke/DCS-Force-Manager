using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class KillStatisticSingleMission
    {
        public List<HasBeenDestroyedEvent> DestroyedAllies = new List<HasBeenDestroyedEvent>();
        public List<List<KillStatistic_ByUnitType>> AlliedStatistic = new List<List<KillStatistic_ByUnitType>>();
        
        public List<HasBeenDestroyedEvent> DestroyedEnemies = new List<HasBeenDestroyedEvent>();
        public List<List<KillStatistic_ByUnitType>> EnemyStatistic = new List<List<KillStatistic_ByUnitType>>();
    }
}
