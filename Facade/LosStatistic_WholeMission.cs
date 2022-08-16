using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class LosStatistic_WholeMission
    {
        public List<HasBeenDestroyedEvent> DestroyedRed = new List<HasBeenDestroyedEvent>();
        public List<List<LossStatistic_UnitType>> RedStatistic = new List<List<LossStatistic_UnitType>>();
        
        public List<HasBeenDestroyedEvent> DestroyedBlue = new List<HasBeenDestroyedEvent>();
        public List<List<LossStatistic_UnitType>> BlueStatistic = new List<List<LossStatistic_UnitType>>();
    }
}
