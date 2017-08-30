using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PrimeApi.Models
{
    [DataContract]
    public class DeploymentDataTransfer
    {
        [DataMember]
        public DateTime Timestamp { get; set; }
        [DataMember]
        public int Logger { get; set; }
        [DataMember]
        public float Latitude { get; set; }
        [DataMember]
        public float Longitude { get; set; }
        [DataMember]
        public float BatteryVoltage { get; set; }
        [DataMember]
        public float BatteryRemain { get; set; }
        [DataMember]
        public float Temperature { get; set; }
    }
}