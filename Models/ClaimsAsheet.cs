using System;
using System.Collections.Generic;

namespace DemoWebAPI.Models
{
    public partial class ClaimsAsheet
    {
        public decimal AsheetId { get; set; }
        public string UrlNo { get; set; }
        public string GroupCode { get; set; }
        public decimal? EmpNo { get; set; }
        public decimal? MemberCode { get; set; }
        public decimal? MemberId { get; set; }
        public decimal? ClaimantId { get; set; }
        public string HospName { get; set; }
        public string HospAddress { get; set; }
        public DateTime? Doa { get; set; }
        public DateTime? Dod { get; set; }
        public string DiagName { get; set; }
        public string ProcName { get; set; }
        public decimal? NoOfDoc { get; set; }
        public string AssessedBy { get; set; }
        public string ReconciledBy { get; set; }
        public decimal? HospAmt { get; set; }
        public decimal? EmpAmt { get; set; }
        public string InvoiceTo { get; set; }
        public string EntredBy { get; set; }
        public DateTime? EntredDt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string ActiveYn { get; set; }
        public string IncompleteStatus { get; set; }
        public string IncompleteReason { get; set; }
        public string DiagCode { get; set; }
        public string ProcCode { get; set; }
        public decimal? PriDiagId { get; set; }
        public decimal? SecDiag1Id { get; set; }
        public decimal? SecDiag2Id { get; set; }
        public decimal? TerDiagId { get; set; }
        public decimal? PriProcId { get; set; }
        public decimal? SecProc1Id { get; set; }
        public decimal? SecProc2Id { get; set; }
        public decimal? TerProcId { get; set; }
        public decimal? HospitalId { get; set; }
        public decimal? ClaimId { get; set; }
        public string Observation { get; set; }
        public decimal? HospDisallowAmt { get; set; }
        public decimal? NetDisallowAmt { get; set; }
        public decimal? UhcDisallowAmt { get; set; }
        public decimal? InsDisallowAmt { get; set; }
        public string NetAccptYn { get; set; }
        public DateTime? NetAccptDt { get; set; }
        public string NetAccptBy { get; set; }
        public string QCheckReqYn { get; set; }
        public string CaseType { get; set; }
        public decimal? CopayPaidByEmp { get; set; }
        public decimal? CopayRefundToEmp { get; set; }
        public decimal? CopayPayableByEmp { get; set; }
        public string PriDiagIcd10 { get; set; }
        public string SecDiag1Icd10 { get; set; }
        public string SecDiag2Icd10 { get; set; }
        public string TerDiagIcd10 { get; set; }
        public string OrgFlotter { get; set; }
        public decimal? FlotterAmt { get; set; }
        public string AuditRemark { get; set; }
        public string ExepYn { get; set; }
        public string ExepReason { get; set; }
        public DateTime? ExepDate { get; set; }
        public int? PrevClaimantId { get; set; }
        public int? PrevMemberId { get; set; }
        public string UpdateStatus { get; set; }
        public string RoomType { get; set; }
        public string TariffRemark { get; set; }
        public string MnBillNo { get; set; }
        public string ExepFor { get; set; }
        public string ExepBy { get; set; }
        public string ClientPpnYn { get; set; }
        public string ProcessingAt { get; set; }
        public string ProvisionalDiag { get; set; }
        public decimal? GenRoomDays { get; set; }
        public decimal? IcuRoomDays { get; set; }
        public string RoomCapApplyYn { get; set; }
        public string PropDedApplyYn { get; set; }
        public string CopayYn { get; set; }
        public int? GipsaRemarks { get; set; }
        public string GipsaRemDescription { get; set; }
        public int? GrpPlanId { get; set; }
        public int? PartnerClaimId { get; set; }
        public string CriticalIllnessApplied { get; set; }
        public string BenefitDetailsComp { get; set; }
    }
}
