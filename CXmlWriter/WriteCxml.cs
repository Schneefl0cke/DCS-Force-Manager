using ClosedXML.Excel;

namespace CXmlWriter
{
    public static class WriteCxml
    {
        public static void WriteKillStatistics(string path)
        {
            using (var workbook = new XLWorkbook())
            {
                //WriteKillsToExcel(killed, workbook, "KIA");
                //WriteKillsToExcel(mia, workbook, "MIA and Accidents");//

                //workbook.SaveAs(savePath + ".xlsx"); //savePath
            }
        }

        private static void WriteCoalitionStatistics(XLWorkbook workbook)
        {

        }
    }
}