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
            HasBeenDestroyedEventSorter.Sort(hasBeenDestroyedEvents);

            var d_Allies = HasBeenDestroyedEventSorter.DestroyedAllies;
            var d_Allies_Planes = HasBeenDestroyedEventSorter.DestroyedAlliedPlanes;
            var d_Allies_Helicopter = HasBeenDestroyedEventSorter.DestroyedAlliedHelicopter;
            var d_Allies_Tanks = HasBeenDestroyedEventSorter.DestroyedAlliedTanks;
            var d_Allies_Sam = HasBeenDestroyedEventSorter.DestroyedAlliedSam;

            var d_Enemies = HasBeenDestroyedEventSorter.DestroyedEnemies;
            var d_Enemies_Planes = HasBeenDestroyedEventSorter.DestroyedEnemyPlanes;
            var d_Enemies_Helicopter = HasBeenDestroyedEventSorter.DestroyedEnemyHelicopter;
            var d_Enemies_Tanks = HasBeenDestroyedEventSorter.DestroyedEnemyTanks;
            var d_Enemies_Sam = HasBeenDestroyedEventSorter.DestroyedEnemySam;

            var plane = HasBeenDestroyedEventSorter.DestroyedEnemyPlanes_KillStatistic;
        }
    }
}
