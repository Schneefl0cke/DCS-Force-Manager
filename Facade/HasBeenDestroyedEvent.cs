using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HasBeenDestroyedEvent
    {
        public string PrimaryType { get; set; } = "";
        public string PrimaryUnitTypeName { get; set; } = "";
        public string PrimaryPilot { get; set; } = "";
        public string PrimaryCoalition { get; set; } = "";
        public string PrimaryCountry { get; set; } = "";
        public string PrimaryGroup { get; set; } = "";
        public bool PlayerDeath { get; set; } = false;

        public string SecondaryType { get; set; } = "";
        public string SecondaryUnitTypeName { get; set; } = "";
        public string SecondaryPilot { get; set; } = "";
        public string SecondaryCoalition { get; set; } = "";
        public string SecondaryCountry { get; set; } = "";
        public string SecondaryGroup { get; set; } = "";
        public bool PlayerKill { get; set; } = false;
    }
}
