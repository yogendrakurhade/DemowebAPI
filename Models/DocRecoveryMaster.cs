using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class DocRecoveryMaster
    {
        public decimal? DocRecId { get; set; }
        public string DocRecType { get; set; }
        public string RequiredForDept { get; set; }
        public string DocRecDesc { get; set; }
        public string EntredBy { get; set; }
        public DateTime? EntredDt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string ReqdYn { get; set; }
        public int? FlagId { get; set; }
    }
}
