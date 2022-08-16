using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class LossStatistic_UnitType
    {
        //TODO: raus da und anders machen
        public string Display
        {
            get { return $"{UnitTypeName}: \n" +
                    $"KIA: {Killed}, \n" +
                    $"MIA: {Destroyed}, \n" +
                    $"(Dead players: { PlayerDeaths})\n" +
                    $"(Shot by players: {PlayerKills})\n" +
                    $"Total: {Killed+Destroyed} \n"; }
        }
        public int Killed { get; set; } = 0;
        public int PlayerKills { get; set; } = 0;
        public int PlayerDeaths { get; set; } = 0;
        public int Destroyed { get; set; } = 0;
        public string Type { get; set; } = "";
        public string UnitTypeName { get; set; } = "";
        public string Coalition { get; set; } = "";
    }
}
