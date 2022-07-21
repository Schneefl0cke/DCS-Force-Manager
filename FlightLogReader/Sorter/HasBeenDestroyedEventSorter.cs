using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;

namespace FlightLogReader.Sorter
{
    public static class HasBeenDestroyedEventSorter
    {
        public static List<HasBeenDestroyedEvent> DestroyedAllies = new List<HasBeenDestroyedEvent>();

        public static List<HasBeenDestroyedEvent> DestroyedAlliedPlanes = new List<HasBeenDestroyedEvent> ();
        public static List <KillStatistic_ByUnitType> DestroyedAlliedPlanes_KillStatistic = new List<KillStatistic_ByUnitType> ();

        public static List<HasBeenDestroyedEvent> DestroyedAlliedHelicopter = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedAlliedHelicopter_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedAlliedTanks = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedAlliedTanks_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedAlliedSam = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedAlliedSam_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedAlliedShips = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedAlliedShips_KillStatistic = new List<KillStatistic_ByUnitType>();


        //Enemies **********************************************************************************************
        public static List<HasBeenDestroyedEvent> DestroyedEnemies = new List<HasBeenDestroyedEvent>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemyPlanes = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedEnemyPlanes_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemyHelicopter = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedEnemyHelicopter_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemyTanks = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedEnemyTanks_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemySam = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedEnemySam_KillStatistic = new List<KillStatistic_ByUnitType>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemyShips = new List<HasBeenDestroyedEvent>();
        public static List<KillStatistic_ByUnitType> DestroyedEnemyShips_KillStatistic = new List<KillStatistic_ByUnitType>();


        public static void Sort(List<HasBeenDestroyedEvent> hbdEvents)
        {
            //Infantry has no coalition!
            DestroyedAllies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            DestroyedAlliedPlanes = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            DestroyedAlliedPlanes_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedAlliedPlanes);

            DestroyedAlliedHelicopter = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            DestroyedAlliedHelicopter_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedAlliedHelicopter);

            DestroyedAlliedTanks = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            DestroyedAlliedTanks_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedAlliedTanks);

            DestroyedAlliedSam = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");
            DestroyedAlliedSam_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedAlliedSam);

            DestroyedAlliedShips = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "ship");
            DestroyedAlliedShips_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedAlliedShips);

            //***************
            DestroyedEnemies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");
            DestroyedEnemyPlanes = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            DestroyedEnemyPlanes_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedEnemyPlanes);

            DestroyedEnemyHelicopter = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            DestroyedEnemyHelicopter_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedEnemyHelicopter);

            DestroyedEnemyTanks = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            DestroyedEnemyTanks_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedEnemyTanks);

            DestroyedEnemySam = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");
            DestroyedEnemySam_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedEnemySam);

            DestroyedEnemyShips = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "ship");
            DestroyedEnemyShips_KillStatistic = CalculateKillStatistic_ByUnitTypeName(DestroyedEnemyShips);
        }

        private static List<KillStatistic_ByUnitType> CalculateKillStatistic_ByUnitTypeName(List<HasBeenDestroyedEvent> list)
        {
            var killStatistics = new List<KillStatistic_ByUnitType>();

            foreach (var unit in list)
            {
                var entry = killStatistics.FirstOrDefault(x => x.UnitTypeName == unit.PrimaryUnitTypeName);
                if (entry == null)
                {
                    killStatistics.Add(new KillStatistic_ByUnitType() { Coalition = unit.PrimaryCoalition, /*Country = unit.PrimaryCountry,*/ Type = unit.PrimaryType, UnitTypeName = unit.PrimaryUnitTypeName});
                }
                else
                {
                    entry.Killed++;
                }
            }

            return killStatistics;
        }
    }
}
