using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsAsheetDocRec
    {
        public decimal ClaimsDocRecId { get; set; }
        public decimal? AsheetDetailsId { get; set; }
        public decimal? AsheetId { get; set; }
        public decimal? DocRecId { get; set; }
        public DateTime? RecoveryStartDt { get; set; }
        public DateTime? RecoveryEndDt { get; set; }
        public string RecoveryFor { get; set; }
        public string RecoveryFrom { get; set; }
        public string Remarks { get; set; }
        public string EntredBy { get; set; }
        public DateTime? EntredDt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public DateTime? FirstReminder { get; set; }
        public DateTime? SecReminder { get; set; }
        public DateTime? ThirdReminder { get; set; }
        public string ReminderMode { get; set; }
        public string ReminderStatus { get; set; }
        public string DocNonRecepitTag { get; set; }
        public string ReasonOfNonRecepit { get; set; }
        public DateTime? DateDocRecdFromEmp { get; set; }
        public DateTime? DateDocSentToMumbai { get; set; }
        public DateTime? DateDocRecdAtMumbai { get; set; }
        public decimal? DrCount { get; set; }
        public string FirstReminderSentYn { get; set; }
        public string FirstReminderRemark { get; set; }
        public string SecReminderSentYn { get; set; }
        public string SecReminderRemark { get; set; }
        public string ThirdReminderSentYn { get; set; }
        public string ThirdReminderRemark { get; set; }
        public DateTime? FirstContact { get; set; }
        public string FirstContactYn { get; set; }
        public string FirstContactRemark { get; set; }
        public string InDr { get; set; }
        public decimal? DrAmt { get; set; }
        public string FailureYn { get; set; }
        public DateTime? FailureMarkDt { get; set; }
        public string DrDescRemark { get; set; }
        public DateTime? NextFallowupDt { get; set; }
        public DateTime? CloserReminder { get; set; }
        public string DocRecvdAtBrBy { get; set; }
        public string DocRecvdAtBrRemark { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string DrReceiptReason { get; set; }
    }
}
