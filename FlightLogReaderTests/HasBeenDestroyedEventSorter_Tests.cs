using FlightLogReader.Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FlightLogReaderTests
{
    [TestClass]
    public class HasBeenDestroyedEventSorter_Tests
    {
        public XmlDocument ReadXml()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "FlightLog.xml");
            var xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));
            return xml;
        }

        [TestMethod]
        public void Sort_Test()
        {
            var hasBeenDestroyedEvents = FlightLogReader.FlightLogReader.ReadHasBeenDestroyedEvents(ReadXml());
            var statistic = HasBeenDestroyedEventSorter.Sort(hasBeenDestroyedEvents);

            var d_Allies = statistic.DestroyedAllies;
            var d_Allies_Planes = statistic.DestroyedAlliedPlanes;
            var d_Allies_Helicopter = statistic.DestroyedAlliedHelicopter;
            var d_Allies_Tanks = statistic.DestroyedAlliedTanks;
            var d_Allies_Sam = statistic.DestroyedAlliedSam;

            var d_Enemies = statistic.DestroyedEnemies;
            var d_Enemies_Planes = statistic.DestroyedEnemyPlanes;
            var d_Enemies_Helicopter = statistic.DestroyedEnemyHelicopter;
            var d_Enemies_Tanks = statistic.DestroyedEnemyTanks;
            var d_Enemies_Sam = statistic.DestroyedEnemySam;

            var plane = statistic.DestroyedEnemyPlanes_KillStatistic;
        }
    }
}
