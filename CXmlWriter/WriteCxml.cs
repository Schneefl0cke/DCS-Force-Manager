using AssetsManager;
using ClosedXML.Excel;
using Facade;
using SquadronManager;
using System.Numerics;

namespace CXmlWriter
{
    //TODO: export as text
    public static class WriteCxml
    {
        //Not really nice parameters, but I dont care rn
        public static void WriteKillStatistics_SingleMission(string savePath, KillStatisticSingleMission statistic, bool includePlayers, List<Player> players, bool includeSquadrons, List<Squadron> squadrons)
        {
            using (var workbook = new XLWorkbook())
            {
                int position = 1;
                var alliedWorksheet = workbook.AddWorksheet("Red - Statistic");
                alliedWorksheet.Cell("A" + position).Value = "Red - Statistic";
                alliedWorksheet.Cell("A" + position).Style.Font.Bold = true;
                position += 2;

                foreach (var alliedLosses in statistic.RedStatistic)
                {
                    WriteTypeStatistic(alliedWorksheet, alliedLosses, ref position);
                }

                position = 1;
                var enemyWorksheet = workbook.AddWorksheet("Blue - Statistic");
                enemyWorksheet.Cell("A" + position).Value = "Blue - Statistic";
                enemyWorksheet.Cell("A" + position).Style.Font.Bold = true;
                position += 2;
                foreach (var enemyLosses in statistic.BlueStatistic)
                {
                    WriteTypeStatistic(enemyWorksheet, enemyLosses, ref position);
                }

                if (includePlayers)
                {
                    foreach (var player in players)
                    {
                        var playerWorksheet = workbook.AddWorksheet(player.Name);
                        WritePlayerStatistic(playerWorksheet, player);
                    }
                }

                if (includeSquadrons)
                {
                    foreach (var squadron in squadrons)
                    {
                        var playerWorksheet = workbook.AddWorksheet(squadron.Name);
                        WriteSquadronStatistic(playerWorksheet, squadron);
                    }
                }

                workbook.SaveAs(savePath);
            }
        }

        private static void WriteSquadronStatistic(IXLWorksheet worksheet, Squadron squadron)
        {
            worksheet.Cell("A1").Value = squadron.Name;
            worksheet.Cell("A1").Style.Font.Bold = true;

            worksheet.Cell("A2").Value = "Died in mission: ";
            worksheet.Cell("A2").Style.Font.Bold = true;
            worksheet.Cell("B2").Value = squadron.Deaths;

            worksheet.Cell("A4").Value = "Player kills:";
            worksheet.Cell("A4").Style.Font.Bold = true;

            worksheet.Cell("A5").Value = "Type:";
            worksheet.Cell("A5").Style.Font.Bold = true;
            worksheet.Cell("B5").Value = "Unit Type:";
            worksheet.Cell("B5").Style.Font.Bold = true;
            worksheet.Cell("C5").Value = "Killcount:";
            worksheet.Cell("C5").Style.Font.Bold = true;
            int position = 6;

            //TODO: do it in the sorter, this is a temporary solution
            var airKills = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "aircraft");
            var heliKills = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "helicopter");
            var tankKills = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "tank");
            var samKills = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "sam/aaa");
            var shipKills = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "ship");
            var other = squadron.CurrentMissionKills.FindAll(x => x.Type.ToLower() != "ship" && x.Type.ToLower() != "sam/aaa" && x.Type.ToLower() != "tank" && x.Type.ToLower() != "helicopter" && x.Type.ToLower() != "aircraft");

            foreach (var kill in airKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (airKills.Count != 0)
                position++;

            foreach (var kill in heliKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (heliKills.Count != 0)
                position++;

            foreach (var kill in tankKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (tankKills.Count != 0)
                position++;

            foreach (var kill in samKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (samKills.Count != 0)
                position++;

            foreach (var kill in shipKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (shipKills.Count != 0)
                position++;

            foreach (var kill in other)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }
        }

        private static void WritePlayerStatistic(IXLWorksheet worksheet, Player player)
        {
            worksheet.Cell("A1").Value = player.Name;
            worksheet.Cell("A1").Style.Font.Bold = true;

            worksheet.Cell("A2").Value = "Died in mission: ";
            worksheet.Cell("A2").Style.Font.Bold = true;
            worksheet.Cell("B2").Value = player.Deaths;

            worksheet.Cell("A4").Value = "Player kills:";
            worksheet.Cell("A4").Style.Font.Bold = true;

            worksheet.Cell("A5").Value = "Type:";
            worksheet.Cell("A5").Style.Font.Bold = true;
            worksheet.Cell("B5").Value = "Unit Type:";
            worksheet.Cell("B5").Style.Font.Bold = true;
            worksheet.Cell("C5").Value = "Killcount:";
            worksheet.Cell("C5").Style.Font.Bold = true;
            int position = 6;

            //TODO: do it in the sorter, this is a temporary solution
            var airKills = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "aircraft");
            var heliKills = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "helicopter");
            var tankKills = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "tank");
            var samKills = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "sam/aaa");
            var shipKills = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() == "ship");
            var other = player.CurrentMissionKills.FindAll(x => x.Type.ToLower() != "ship" && x.Type.ToLower() != "sam/aaa" && x.Type.ToLower() != "tank" && x.Type.ToLower() != "helicopter" && x.Type.ToLower() != "aircraft");

            foreach (var kill in airKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (airKills.Count != 0)
                position++;

            foreach (var kill in heliKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (heliKills.Count != 0)
                position++;

            foreach (var kill in tankKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (tankKills.Count != 0)
                position++;

            foreach (var kill in samKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (samKills.Count != 0)
                position++;

            foreach (var kill in shipKills)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }

            if (shipKills.Count != 0)
                position++;

            foreach (var kill in other)
            {
                worksheet.Cell("A" + position).Value = kill.Type;
                worksheet.Cell("B" + position).Value = kill.UnitTypeName;
                worksheet.Cell("C" + position).Value = kill.Killed;
                position++;
            }
        }

        private static void WriteTypeStatistic(IXLWorksheet worksheet, List<KillStatistic_ByUnitType> statistic, ref int position)
        {
            if (statistic.Count > 0)
            {
                worksheet.Cell("A" + position).Value = statistic[0].Type;
                worksheet.Cell("A" + position).Style.Font.Bold = true;
                position++;

                worksheet.Cell("A" + position).Value = "Unit Type";
                worksheet.Cell("A" + position).Style.Font.Bold = true;
                worksheet.Cell("B" + position).Value = "Killed";
                worksheet.Cell("B" + position).Style.Font.Bold = true;
                worksheet.Cell("C" + position).Value = "Destroyed/Missing/Accidents";
                worksheet.Cell("C" + position).Style.Font.Bold = true;
                worksheet.Cell("D" + position).Value = "Total";
                worksheet.Cell("D" + position).Style.Font.Bold = true;
                worksheet.Cell("E" + position).Value = "Dead Players";
                worksheet.Cell("E" + position).Style.Font.Bold = true;
                worksheet.Cell("F" + position).Value = "Killed by Players";
                worksheet.Cell("F" + position).Style.Font.Bold = true;
                position++;

                var totalLosses = 0;
                var totalPlayerKills = 0;
                var totalPlayerDeaths = 0;

                foreach (var killStatistic in statistic)
                {
                    worksheet.Cell("A" + position).Value = killStatistic.UnitTypeName;
                    worksheet.Cell("B" + position).Value = killStatistic.Killed;
                    worksheet.Cell("C" + position).Value = killStatistic.Destroyed;
                    worksheet.Cell("D" + position).Value = killStatistic.Killed + killStatistic.Destroyed;
                    worksheet.Cell("E" + position).Value = killStatistic.PlayerDeaths;
                    worksheet.Cell("F" + position).Value = killStatistic.PlayerKills;
                    totalLosses += killStatistic.Killed + killStatistic.Destroyed;
                    totalPlayerDeaths += killStatistic.PlayerDeaths;
                    totalPlayerKills += killStatistic.PlayerKills;
                    position++;
                }

                worksheet.Cell("C" + position).Value = "Total";
                worksheet.Cell("C" + position).Style.Font.Bold = true;
                worksheet.Cell("D" + position).Value = totalLosses;
                worksheet.Cell("D" + position).Style.Font.Bold = true;

                worksheet.Cell("E" + position).Value = totalPlayerDeaths;
                worksheet.Cell("E" + position).Style.Font.Bold = true;

                worksheet.Cell("F" + position).Value = totalPlayerKills;
                worksheet.Cell("F" + position).Style.Font.Bold = true;

                position += 2;
            }
        }
    }
}