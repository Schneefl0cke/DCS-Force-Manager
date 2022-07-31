using AssetsManager;
using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLogReader.Sorter
{
    public static class PlayerStatisticSorter
    {
        /// <summary>
        /// Currently only for one mission, merging must be done later
        /// </summary>
        /// <param name="killEvents"></param>
        /// <param name="players"></param>
        public static void Sort(List<HasBeenDestroyedEvent> killEvents, List<Player> players)
        {
            foreach (var player in players)
            {
                //maybe bug in futer with playernames that are similar.
                var deaths = killEvents.FindAll(x => x.PrimaryPilot.ToLower().Contains(player.Name.ToLower()));
                var kills = killEvents.FindAll(x => x.SecondaryPilot.ToLower().Contains(player.Name.ToLower()));

                player.Deaths = deaths.Count;
                player.CurrentMissionKills = CalculateKillStatistic_ByUnitTypeName(kills);
            }
        }

        private static List<PlayerStatistic_ByUnitType> CalculateKillStatistic_ByUnitTypeName(List<HasBeenDestroyedEvent> list)
        {
            var killStatistics = new List<PlayerStatistic_ByUnitType>();

            foreach (var unit in list)
            {
               var kill  = killStatistics.FirstOrDefault(x => x.UnitTypeName == unit.PrimaryUnitTypeName);
                if (kill == null)
                {
                    var statistic = new PlayerStatistic_ByUnitType();
                    statistic.Killed = 1;
                    statistic.UnitTypeName = unit.PrimaryUnitTypeName;
                    statistic.Type = unit.PrimaryType;

                    killStatistics.Add(statistic);
                }
                else
                {
                    kill.Killed += 1;
                }
            }

            return killStatistics;
        }

        private static List<PlayerStatistic_ByUnitType> CalculateDeathStatistic_ByUnitTypeName(List<HasBeenDestroyedEvent> list)
        {
            var deathStatistic = new List<PlayerStatistic_ByUnitType>();

            foreach (var unit in list)
            {
                var death = deathStatistic.FirstOrDefault(x => x.UnitTypeName == unit.SecondaryUnitTypeName);


                if (death == null)
                {
                    var statistic = new PlayerStatistic_ByUnitType();
                    statistic.Killed = 1;
                    statistic.UnitTypeName = unit.SecondaryUnitTypeName;
                    statistic.Type = unit.PrimaryType;

                    deathStatistic.Add(statistic);
                }
                else
                {
                    death.Killed += 1;
                }
            }

            return deathStatistic;
        }
    }
}
