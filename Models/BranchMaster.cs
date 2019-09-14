using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class BranchMaster
    {
        public int LocId { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string Tel { get; set; }
        public string EMail { get; set; }
        public string Name { get; set; }
        public string DrPersion { get; set; }
        public string ActiveYn { get; set; }
        public string ManualDistributionYn { get; set; }
        public string DrType { get; set; }
        public string MinShop { get; set; }
    }
}
