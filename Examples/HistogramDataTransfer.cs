using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PrimeApi.Models
{
    [DataContract]
    public class HistogramDataTransfer
    {
        [DataMember]
        public DateTime Timestamp { get; set; }
        [DataMember]
        public int[] Bins { get; set; }
    }
}