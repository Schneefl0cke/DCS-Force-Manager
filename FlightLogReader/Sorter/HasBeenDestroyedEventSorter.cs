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
        public static List<HasBeenDestroyedEvent> DestroyedAllies;
        public static List<HasBeenDestroyedEvent> DestroyedEnemies;


        public static void Sort(List<HasBeenDestroyedEvent> hbdEvents)
        {
            //Infantry has no coalition!
            DestroyedAllies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            DestroyedEnemies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");
        }
    }
}
