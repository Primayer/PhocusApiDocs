    public class EnigmaSummaryModel
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public string GroupName { get; set; }
        public int Leaks { get; set; }
    }

    public class GroupSummaryModel
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public int Confidence { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float DistanceFromLeft { get; set; }
        public string URL { get; set; }
    }

    public class AudioModel
    {
        public string Logger { get; set; }
        public string Timestamp { get; set; }
        public byte[] Audio { get; set; }
    }
