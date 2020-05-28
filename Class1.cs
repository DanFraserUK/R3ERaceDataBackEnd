using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3ERaceDataBackEnd
{

    public class Rootobject
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

    public class Session
    {
        public string Type { get; set; }
        public Player[] Players { get; set; }
    }

    public class Player
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public int UserWeightPenalty { get; set; }
        public int CarId { get; set; }
        public string Car { get; set; }
        public int CarWeightPenalty { get; set; }
        public int LiveryId { get; set; }
        public int CarPerformanceIndex { get; set; }
        public int Position { get; set; }
        public int PositionInClass { get; set; }
        public int StartPosition { get; set; }
        public int StartPositionInClass { get; set; }
        public int BestLapTime { get; set; }
        public int TotalTime { get; set; }
        public string FinishStatus { get; set; }
        public Racesessionlap[] RaceSessionLaps { get; set; }
    }

    public class Racesessionlap
    {
        public int Time { get; set; }
        public int[] SectorTimes { get; set; }
        public int PositionInClass { get; set; }
        public bool Valid { get; set; }
        public int Position { get; set; }
        public bool PitStopOccured { get; set; }
        public Incident[] Incidents { get; set; }
    }

    public class Incident
    {
        public int Type { get; set; }
        public int Points { get; set; }
        public int OtherUserId { get; set; }
    }

}
