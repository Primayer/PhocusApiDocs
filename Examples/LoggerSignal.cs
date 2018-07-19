public class LoggerSignalModel
{
    public string SiteName { get; set; }
    public List<SignalModel> Signals { get; set; }
}

public class SignalModel
{
    public DateTime Timestamp { get; set; }
    public string Signal { get; set; }
    public string NetworkName { get; set; }
    public string NetworkType { get; set; }
}