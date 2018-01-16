    public class LoggerInfoModel
    {
        public string SiteName { get; set; }
        public List<EpochInfoModel> Epochs { get; set; }
    }

    public class EpochInfoModel
    {
        public DateTime StartDate { get; set; }
        public int LCF { get; set; }
        public int CNV { get; set; }      
        public Nullable<double> RemainingBattery { get; set; }
    }