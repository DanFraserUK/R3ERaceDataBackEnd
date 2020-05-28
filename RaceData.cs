using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3ERaceDataBackEnd
{
    public class RaceData
    {
        public string Server { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Time { get; set; }
        public string Experience { get; set; }
        public string Difficulty { get; set; }
        public string FuelUsage { get; set; }
        public string TireWear { get; set; }
        public object MechanicalDamage { get; set; }
        public string FlagRules { get; set; }
        public string CutRules { get; set; }
        public object RaceSeriesFormat { get; set; }
        public string WreckerPrevention { get; set; }
        public string MandatoryPitstop { get; set; }
        public string Track { get; set; }
        public string TrackLayout { get; set; }
        public Session[] Sessions { get; set; }
    }
}
