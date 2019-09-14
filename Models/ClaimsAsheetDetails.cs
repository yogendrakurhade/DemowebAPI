using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsAsheetDetails
    {
        public decimal AsheetDetailsId { get; set; }
        public decimal AsheetId { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDt { get; set; }
        public string ServiceCode { get; set; }
        public decimal? ClaimedAmt { get; set; }
        public decimal? CaeApprAmt { get; set; }
        public decimal? InsApprAmt { get; set; }
        public decimal? DisAmt { get; set; }
        public string EobCode { get; set; }
        public string EobReason { get; set; }
        public string EntredBy { get; set; }
        public DateTime? EntredDt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string ActiveYn { get; set; }
        public string BillStatus { get; set; }
        public string Remarks { get; set; }
        public decimal? EobId { get; set; }
        public string InDr { get; set; }
        public decimal? DrAmt { get; set; }
        public string DrDesc { get; set; }
        public decimal? NetApprAmt { get; set; }
        public decimal? NetDisallowAmt { get; set; }
        public decimal? HospApprAmt { get; set; }
        public decimal? HospDisallowAmt { get; set; }
        public decimal? InsDisallowAmt { get; set; }
    }
}
