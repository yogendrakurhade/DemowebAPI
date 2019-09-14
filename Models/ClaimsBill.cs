using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsBill
    {
        public decimal BillId { get; set; }
        public decimal MemberId { get; set; }
        public string PlanType { get; set; }
        public decimal? Period { get; set; }
        public string GroupCode { get; set; }
        public decimal? EmpNo { get; set; }
        public decimal? MemberCode { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Division { get; set; }
        public string ServiceType { get; set; }
        public string CfNo { get; set; }
        public string EobNo { get; set; }
        public DateTime? ClaimDt { get; set; }
        public decimal? Advance { get; set; }
        public string HospName { get; set; }
        public DateTime? Doa { get; set; }
        public DateTime? Dod { get; set; }
        public string DiagCode { get; set; }
        public string ProcCode { get; set; }
        public decimal? Exgratia { get; set; }
        public string EntryBy { get; set; }
        public DateTime? EntryDt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string ActiveYn { get; set; }
        public string ServiceGroupCode { get; set; }
        public decimal? Discount { get; set; }
        public string EobReason { get; set; }
        public DateTime? CfRecvdDate { get; set; }
        public DateTime? CfSgrDate { get; set; }
        public decimal? DiagId { get; set; }
        public decimal? InsDisAmt { get; set; }
        public string ClaimClearedYn { get; set; }
        public decimal? HospitalId { get; set; }
        public string CfSgrBy { get; set; }
        public string CfDocBy { get; set; }
        public string ClaimType { get; set; }
        public string RejFlag { get; set; }
        public DateTime? RejDt { get; set; }
        public string RejBy { get; set; }
        public string ClosedYn { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? ClosedDt { get; set; }
        public DateTime? CaeStartDt { get; set; }
        public DateTime? CaeEndDt { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string DataEntryBy { get; set; }
        public DateTime? DataEntryDt { get; set; }
        public int? PrevMemberId { get; set; }
        public string UpdateStatus { get; set; }
        public int? CaseId { get; set; }
        public string QcFlag { get; set; }
        public DateTime? InsIntiDt { get; set; }
        public string InvoiceNo { get; set; }
        public string VoucherNo { get; set; }
        public int? BillIdTemp { get; set; }
        public string DataSource { get; set; }
    }
}
