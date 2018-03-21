using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PrimeApi.Models
{
    [DataContract]
    public class EpochDataTransfer
    {
        public EpochDataTransfer(DateTime start_date, int lcf, int cnv)
        {
            StartDate = start_date;
            LCF = lcf;
            CNV = cnv;
        }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public int LCF { get; set; }
        [DataMember]
        public int CNV { get; set; }
        [DataMember]
        public Nullable<double> Latitude { get; set; }
        [DataMember]
        public Nullable<double> Longitude { get; set; }
        [DataMember]
        public Nullable<double> RemainingBattery { get; set; }
        [DataMember]
        public Nullable<int> OutlierThresh { get; set; }
        [DataMember]
        public Nullable<int> TH2 { get; set; }
        [DataMember]
        public Nullable<int> TH3 { get; set; }
        [DataMember]
        public Nullable<int> TH4 { get; set; }
        [DataMember]
        public Nullable<int> CNT2 { get; set; }
        [DataMember]
        public Nullable<int> CNT3 { get; set; }
        [DataMember]
        public Nullable<int> CNT4 { get; set; }
        [DataMember]
        public Nullable<int> Duration { get; set; }
        [DataMember]
        public int[] SoundData { get; set; }
        [DataMember]
        public List<HistogramDataTransfer> Histograms { get; set; }
    }
}
