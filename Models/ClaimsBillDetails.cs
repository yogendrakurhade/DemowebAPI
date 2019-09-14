using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsBillDetails
    {
        public decimal BillDetailsId { get; set; }
        public decimal BillId { get; set; }
        public decimal MemberId { get; set; }
        public decimal BillNo { get; set; }
        public string CareType { get; set; }
        public DateTime? BillDt { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceType { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public decimal? AmtClaimed { get; set; }
        public decimal? AmtPayable { get; set; }
        public decimal? AmtExgratia { get; set; }
        public string Reason { get; set; }
        public string CfNo { get; set; }
        public string EobNo { get; set; }
        public string EntryBy { get; set; }
        public DateTime? EntryDt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string ActiveYn { get; set; }
        public string ServiceGroupCode { get; set; }
        public string Relation { get; set; }
        public decimal? SrNo { get; set; }
        public int? PrevMemberId { get; set; }
        public string UpdateStatus { get; set; }
        public int? ClaimantId { get; set; }
        public decimal? CoPayExcessAmt { get; set; }
        public string FileNames { get; set; }
        public string FileExt { get; set; }
        public string EmailPartialdocCommuEmailSent { get; set; }
        public int? EmailPartialdocCommuEmailRefId { get; set; }
    }
}
