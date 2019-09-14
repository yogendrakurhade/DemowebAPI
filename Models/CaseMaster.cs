using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class CaseMaster
    {
        public int CaseId { get; set; }
        public string GrpCode { get; set; }
        public int? EmpId { get; set; }
        public int? ClaimantId { get; set; }
        public string CaseType { get; set; }
        public int? PreAuthId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedRelation { get; set; }
        public decimal? MobileNo { get; set; }
        public string EmailId { get; set; }
        public int? QueryMasterId { get; set; }
        public decimal? ContactNo { get; set; }
        public string NetworkHospYn { get; set; }
        public int? CurrentStatusId { get; set; }
        public string EmrgncYn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string EmailStatus { get; set; }
        public int? PrevClaimantId { get; set; }
        public int? PrevEmpId { get; set; }
        public string UpdateStatus { get; set; }
        public string MinShop { get; set; }
        public string LocNo { get; set; }
        public string AssignTo { get; set; }
        public int? CaseAssignId { get; set; }
        public int? StdCode { get; set; }
        public string InsClaimNo { get; set; }
        public int? FbMailRefId { get; set; }
        public string IssuePriority { get; set; }
        public int? IssueTypeId { get; set; }
        public string IssueDesc { get; set; }
        public DateTime? BackwardFlowDate { get; set; }
        public string DeathCase { get; set; }
        public string OnDischargeCase { get; set; }
        public string MmReview { get; set; }
        public string ClmSubType { get; set; }
        public decimal? ClmRegAmt { get; set; }
        public int? PreviousCaseId { get; set; }
        public DateTime? InsClaimNoUploadedDt { get; set; }
        public string RequestFrom { get; set; }
        public string RequsetFromApplication { get; set; }
        public string IsDrSubmitedByUser { get; set; }
        public DateTime? IsDrSubmitedByUserDt { get; set; }
        public bool? IsPhyDocRecvd { get; set; }
        public string HulPaid { get; set; }
    }
}
