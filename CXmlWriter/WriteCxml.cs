using ClosedXML.Excel;
using Facade;

namespace CXmlWriter
{
    public static class WriteCxml
    {
        public static void WriteKillStatistics_SingleMission(string safePath, KillStatisticSingleMission statistic)
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

                workbook.SaveAs(safePath + ".xlsx");
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
                position++;

                var totalLosses = 0;
                foreach (var killStatistic in statistic)
                {
                    worksheet.Cell("A" + position).Value = killStatistic.UnitTypeName;
                    worksheet.Cell("B" + position).Value = killStatistic.Killed;
                    worksheet.Cell("C" + position).Value = killStatistic.Destroyed;
                    worksheet.Cell("D" + position).Value = killStatistic.Killed + killStatistic.Destroyed;
                    totalLosses += killStatistic.Killed + killStatistic.Destroyed;
                    position++;
                }

                worksheet.Cell("C" + position).Value = "Total";
                worksheet.Cell("C" + position).Style.Font.Bold = true;
                worksheet.Cell("D" + position).Value = totalLosses;
                worksheet.Cell("D" + position).Style.Font.Bold = true;

                position+= 2;
            }
        }
    }
}