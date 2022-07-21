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
        public static List<HasBeenDestroyedEvent> DestroyedAlliedHelicopter = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedAlliedTanks = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedAlliedSam = new List<HasBeenDestroyedEvent>();

        public static List<HasBeenDestroyedEvent> DestroyedEnemies = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedEnemyPlanes = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedEnemyHelicopter = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedEnemyTanks = new List<HasBeenDestroyedEvent>();
        public static List<HasBeenDestroyedEvent> DestroyedEnemySam = new List<HasBeenDestroyedEvent>();


        public static void Sort(List<HasBeenDestroyedEvent> hbdEvents)
        {
            //Infantry has no coalition!
            DestroyedAllies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            DestroyedAlliedPlanes = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            DestroyedAlliedHelicopter = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            DestroyedAlliedTanks = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            DestroyedAlliedSam = DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");

            DestroyedEnemies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");
            DestroyedEnemyPlanes = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "aircraft");
            DestroyedEnemyHelicopter = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "helicopter");
            DestroyedEnemyTanks = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "tank");
            DestroyedEnemySam = DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa");
        }
    }
}
