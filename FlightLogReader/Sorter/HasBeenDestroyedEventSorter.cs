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
        public static KillStatisticSingleMission Sort(List<HasBeenDestroyedEvent> hbdEvents)
        {
            var killStatisticSingleMission = new KillStatisticSingleMission();

            //Infantry has no coalition!
            killStatisticSingleMission.DestroyedAllies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            killStatisticSingleMission.DestroyedAlliedPlanes = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            killStatisticSingleMission.DestroyedAlliedPlanes_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedAlliedPlanes);
            killStatisticSingleMission.DestroyedAlliedHelicopter = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            killStatisticSingleMission.DestroyedAlliedHelicopter_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedAlliedHelicopter);
            killStatisticSingleMission.DestroyedAlliedTanks = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            killStatisticSingleMission.DestroyedAlliedTanks_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedAlliedTanks);
            killStatisticSingleMission.DestroyedAlliedSam = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");
            killStatisticSingleMission.DestroyedAlliedSam_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedAlliedSam);
            killStatisticSingleMission.DestroyedAlliedShips = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "ship");
            killStatisticSingleMission.DestroyedAlliedShips_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedAlliedShips);

            //***************
            killStatisticSingleMission.DestroyedEnemies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");
            killStatisticSingleMission.DestroyedEnemyPlanes = killStatisticSingleMission.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            killStatisticSingleMission.DestroyedEnemyPlanes_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedEnemyPlanes);
            killStatisticSingleMission.DestroyedEnemyHelicopter = killStatisticSingleMission.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            killStatisticSingleMission.DestroyedEnemyHelicopter_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedEnemyHelicopter);
            killStatisticSingleMission.DestroyedEnemyTanks = killStatisticSingleMission.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            killStatisticSingleMission.DestroyedEnemyTanks_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedEnemyTanks);
            killStatisticSingleMission.DestroyedEnemySam = killStatisticSingleMission.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");
            killStatisticSingleMission.DestroyedEnemySam_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedEnemySam);
            killStatisticSingleMission.DestroyedEnemyShips = killStatisticSingleMission.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "ship");
            killStatisticSingleMission.DestroyedEnemyShips_KillStatistic = CalculateKillStatistic_ByUnitTypeName(killStatisticSingleMission.DestroyedEnemyShips);

            return killStatisticSingleMission;
        }

        //KIA, TODO: MIA
        private static List<KillStatistic_ByUnitType> CalculateKillStatistic_ByUnitTypeName(List<HasBeenDestroyedEvent> list)
        {
            var killStatistics = new List<KillStatistic_ByUnitType>();

            foreach (var unit in list)
            {
                var entry = killStatistics.FirstOrDefault(x => x.UnitTypeName == unit.PrimaryUnitTypeName);
                if (entry == null)
                {
                    if (unit.SecondaryPilot == string.Empty)
                    {
                        killStatistics.Add(new KillStatistic_ByUnitType() { Destroyed = 1, Coalition = unit.PrimaryCoalition, /*Country = unit.PrimaryCountry,*/ Type = unit.PrimaryType, UnitTypeName = unit.PrimaryUnitTypeName });
                    }
                    else
                    {
                        killStatistics.Add(new KillStatistic_ByUnitType() { Killed = 1, Coalition = unit.PrimaryCoalition, /*Country = unit.PrimaryCountry,*/ Type = unit.PrimaryType, UnitTypeName = unit.PrimaryUnitTypeName });
                    }
                }
                else
                {
                    if (unit.SecondaryPilot == string.Empty)
                    {
                        entry.Destroyed++;
                    }
                    else
                    {
                        entry.Killed++;
                    }
                }
            }

            return killStatistics;
        }
    }
}
