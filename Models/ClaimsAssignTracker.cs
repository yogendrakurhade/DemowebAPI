using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsAssignTracker
    {
        public int AssignedId { get; set; }
        public int? TrackerId { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? AssignStartDt { get; set; }
        public string ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
    }
}
