using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PrimeApi.Models
{
    [DataContract]
    public class LoggerDataTransfer
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public Nullable<long> Serial { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string SiteName { get; set; }
        [DataMember]
        public Nullable<double> Latitude { get; set; }
        [DataMember]
        public Nullable<double> Longitude { get; set; }
        [DataMember]
        public List<EpochDataTransfer> Epochs { get; set; }
        [DataMember]
        public Guid UserID { get; set; }
        [DataMember]
        public List<DeploymentDataTransfer> Deployments { get; set; }
        [DataMember]
        public string Dma { get; set; }
    }

    

    public class DMAInsertModel
    {
        public string Name { get; set; }
        public LoggerDataTransfer Logger { get; set; }
    }
}