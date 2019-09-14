using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class DrReminder
    {
        public int DrReminderId { get; set; }
        public string ClientType { get; set; }
        public int? Reminder { get; set; }
        public int? Interval { get; set; }
        public string IncludeWeekend { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
    }
}
