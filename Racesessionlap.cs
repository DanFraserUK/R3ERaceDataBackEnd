namespace R3ERaceDataBackEnd
{
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
}
