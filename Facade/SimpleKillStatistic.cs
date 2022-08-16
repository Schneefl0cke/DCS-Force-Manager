using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SimpleKillStatistic
    {
        //public string Display
        //{
        //    get
        //    {
        //        return $"{UnitTypeName}: \n" +
        //            $"KIA: {Killed}, \n" +
        //            $"MIA: {Destroyed}, \n" +
        //            $"(Dead players: {PlayerDeaths})\n" +
        //            $"(Shot by players: {PlayerKills})\n" +
        //            $"Total: {Killed + Destroyed} \n";
        //    }
        //}
        public int KillCount { get; set; } = 0;
        public string Type { get; set; } = "";
        public string UnitTypeName { get; set; } = "";
    }
}
