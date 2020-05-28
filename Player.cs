namespace R3ERaceDataBackEnd
{
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
}
