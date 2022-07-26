using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class KillStatistic_ByUnitType
    {
        public string Display
        {
            get { return $"{UnitTypeName}: KIA: {Killed}, MIA: {Destroyed}, Total: {Killed+Destroyed}"; }
        }
        public int Killed { get; set; } = 0;
        public int Destroyed { get; set; } = 0;
        public string Type { get; set; } = "";
        public string UnitTypeName { get; set; } = "";
        public string Coalition { get; set; } = "";
    }
}
