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

        public List<HasBeenDestroyedEvent> DestroyedAlliedPlanes = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedAlliedPlanes_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedAlliedHelicopter = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedAlliedHelicopter_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedAlliedTanks = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedAlliedTanks_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedAlliedSam = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedAlliedSam_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedAlliedShips = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedAlliedShips_KillStatistic = new List<KillStatistic_ByUnitType>();


        //Enemies **********************************************************************************************
        public List<HasBeenDestroyedEvent> DestroyedEnemies = new List<HasBeenDestroyedEvent>();

        public List<HasBeenDestroyedEvent> DestroyedEnemyPlanes = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedEnemyPlanes_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedEnemyHelicopter = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedEnemyHelicopter_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedEnemyTanks = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedEnemyTanks_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedEnemySam = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedEnemySam_KillStatistic = new List<KillStatistic_ByUnitType>();

        public List<HasBeenDestroyedEvent> DestroyedEnemyShips = new List<HasBeenDestroyedEvent>();
        public List<KillStatistic_ByUnitType> DestroyedEnemyShips_KillStatistic = new List<KillStatistic_ByUnitType>();
    }
}
