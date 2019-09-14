using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoWebAPI.Models
{
    public partial class claimsContext : DbContext
    {
        public claimsContext()
        {
        }

        public claimsContext(DbContextOptions<claimsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BranchMaster> BranchMaster { get; set; }
        public virtual DbSet<CaseMaster> CaseMaster { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<ClaimsAsheet> ClaimsAsheet { get; set; }
        public virtual DbSet<ClaimsAsheetDetails> ClaimsAsheetDetails { get; set; }
        public virtual DbSet<ClaimsAsheetDocRec> ClaimsAsheetDocRec { get; set; }
        public virtual DbSet<ClaimsAssignTracker> ClaimsAssignTracker { get; set; }
        public virtual DbSet<ClaimsBill> ClaimsBill { get; set; }
        public virtual DbSet<ClaimsBillDetails> ClaimsBillDetails { get; set; }
        public virtual DbSet<DocRecoveryMaster> DocRecoveryMaster { get; set; }
        public virtual DbSet<DrReminder> DrReminder { get; set; }
        public virtual DbSet<Member> Member { get; set; }

        // Unable to generate entity type for table 'dbo.dr_mail_send'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-ULVON82;Database=claims;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BranchMaster>(entity =>
            {
                entity.HasKey(e => e.LocId)
                    .HasName("PK_branch_master_1");

                entity.ToTable("branch_master");

                entity.Property(e => e.LocId).HasColumnName("loc_id");

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("active_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrPersion)
                    .HasColumnName("dr_persion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrType)
                    .HasColumnName("dr_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManualDistributionYn)
                    .HasColumnName("manual_distribution_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MinShop)
                    .HasColumnName("min_shop")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseMaster>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("case_master");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.AssignTo)
                    .HasColumnName("assign_to")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BackwardFlowDate)
                    .HasColumnName("backward_flow_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaseAssignId).HasColumnName("case_assign_id");

                entity.Property(e => e.CaseType)
                    .HasColumnName("case_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimantId).HasColumnName("claimant_id");

                entity.Property(e => e.ClmRegAmt)
                    .HasColumnName("clm_reg_amt")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ClmSubType)
                    .HasColumnName("clm_sub_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasColumnType("numeric(17, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("created_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentStatusId).HasColumnName("current_status_id");

                entity.Property(e => e.DeathCase)
                    .HasColumnName("death_case")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasColumnName("email_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmrgncYn)
                    .HasColumnName("emrgnc_yn")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FbMailRefId).HasColumnName("fb_mail_ref_id");

                entity.Property(e => e.GrpCode)
                    .HasColumnName("grp_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HulPaid)
                    .HasColumnName("hul_paid")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InsClaimNo)
                    .HasColumnName("ins_claim_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsClaimNoUploadedDt)
                    .HasColumnName("ins_claim_no_Uploaded_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDrSubmitedByUser)
                    .HasColumnName("Is_DR_Submited_by_User")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsDrSubmitedByUserDt)
                    .HasColumnName("Is_DR_Submited_by_User_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPhyDocRecvd).HasColumnName("Is_Phy_Doc_Recvd");

                entity.Property(e => e.IssueDesc)
                    .HasColumnName("Issue_Desc")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IssuePriority)
                    .HasColumnName("Issue_Priority")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IssueTypeId).HasColumnName("Issue_Type_ID");

                entity.Property(e => e.LocNo)
                    .HasColumnName("loc_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MinShop)
                    .HasColumnName("min_shop")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MmReview)
                    .HasColumnName("mm_review")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("Mobile_no")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NetworkHospYn)
                    .HasColumnName("network_hosp_yn")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OnDischargeCase)
                    .HasColumnName("on_discharge_case")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PreAuthId).HasColumnName("pre_auth_id");

                entity.Property(e => e.PrevClaimantId).HasColumnName("prev_claimant_id");

                entity.Property(e => e.PrevEmpId).HasColumnName("prev_emp_id");

                entity.Property(e => e.PreviousCaseId).HasColumnName("previous_case_id");

                entity.Property(e => e.QueryMasterId).HasColumnName("query_master_id");

                entity.Property(e => e.RequestFrom)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .HasColumnName("Requested_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedRelation)
                    .HasColumnName("Requested_relation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequsetFromApplication)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StdCode).HasColumnName("std_code");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("Update_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK_CLAIMS");

                entity.ToTable("claims");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("claim_id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("account_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActCaStartDt)
                    .HasColumnName("act_ca_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddRemarks)
                    .HasColumnName("add_remarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AltUrilNo)
                    .HasColumnName("alt_uril_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AmtClaimedEmp)
                    .HasColumnName("amt_claimed_emp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtClaimedHosp)
                    .HasColumnName("amt_claimed_hosp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtDisallowedByIns)
                    .HasColumnName("amt_disallowed_by_ins")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtPayableEmp)
                    .HasColumnName("amt_payable_emp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtPayableHosp)
                    .HasColumnName("amt_payable_hosp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditBy)
                    .HasColumnName("audit_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditEndDt)
                    .HasColumnName("audit_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditStartDt)
                    .HasColumnName("audit_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankId)
                    .HasColumnName("bank_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BillDetailId)
                    .HasColumnName("bill_detail_id")
                    .HasColumnType("numeric(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CaeName)
                    .HasColumnName("cae_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CappedAilment)
                    .HasColumnName("Capped_Ailment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.CaseType)
                    .HasColumnName("case_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CcHelpDesk)
                    .HasColumnName("cc_help_desk")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CfClaimedAmt)
                    .HasColumnName("cf_claimed_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.CfRecvdDate)
                    .HasColumnName("cf_recvd_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CfSendToCaDate)
                    .HasColumnName("cf_send_to_ca_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CfSentToDrDate)
                    .HasColumnName("cf_sent_to_dr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CfSentToInsDate)
                    .HasColumnName("cf_sent_to_ins_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChqDate)
                    .HasColumnName("chq_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChqNoIns)
                    .HasColumnName("chq_no_ins")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ChqRecdAtAccts)
                    .HasColumnName("chq_recd_at_accts")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChqRecdAtAcctsBy)
                    .HasColumnName("chq_recd_at_accts_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ChqRecdAtAcctsDt)
                    .HasColumnName("chq_recd_at_accts_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChqSentToAccts)
                    .HasColumnName("chq_sent_to_accts")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChqSentToAcctsBy)
                    .HasColumnName("chq_sent_to_accts_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ChqSentToAcctsDt)
                    .HasColumnName("chq_sent_to_accts_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChqSentToCaDate)
                    .HasColumnName("chq_sent_to_ca_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClaimDiag)
                    .HasColumnName("claim_diag")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDiagIcd10)
                    .HasColumnName("claim_diag_icd10")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .HasColumnName("claim_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNoIns)
                    .HasColumnName("claim_no_ins")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimRemarks)
                    .HasColumnName("claim_remarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnName("claim_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimantId)
                    .HasColumnName("claimant_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ClaimesDeniedFlag)
                    .HasColumnName("claimes_denied_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimsSheetEndDt)
                    .HasColumnName("claims_sheet_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClaimsSheetEntredBy)
                    .HasColumnName("claims_sheet_entred_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimsSheetStartDt)
                    .HasColumnName("claims_sheet_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closed_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedOn)
                    .HasColumnName("closed_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosedStatus)
                    .HasColumnName("closed_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CompCfRecvdFromCaDate)
                    .HasColumnName("comp_cf_recvd_from_ca_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContributionAmt)
                    .HasColumnName("contribution_amt")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CopayAmtPaid)
                    .HasColumnName("copay_amt_paid")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CrsPrnFlag)
                    .IsRequired()
                    .HasColumnName("crs_prn_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CrsPrnStat)
                    .IsRequired()
                    .HasColumnName("crs_prn_stat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DiagId)
                    .HasColumnName("diag_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DnGenFlag)
                    .HasColumnName("dn_gen_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DnPrnFlag)
                    .HasColumnName("dn_prn_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DnaGenFlag)
                    .IsRequired()
                    .HasColumnName("dna_gen_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DnaPrnFlag)
                    .IsRequired()
                    .HasColumnName("dna_prn_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Doa)
                    .HasColumnName("doa")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoctrName)
                    .HasColumnName("doctr_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctrRegNo)
                    .HasColumnName("doctr_reg_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctrSpec)
                    .HasColumnName("doctr_spec")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Dod)
                    .HasColumnName("dod")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrBy)
                    .HasColumnName("dr_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrEmail)
                    .HasColumnName("dr_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DrMailDt)
                    .HasColumnName("dr_mail_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrPenReason).HasColumnName("dr_pen_reason");

                entity.Property(e => e.DrRemark)
                    .HasColumnName("dr_remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DrrCompDate)
                    .HasColumnName("drr_comp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employee_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EntryBy)
                    .HasColumnName("entry_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDt)
                    .HasColumnName("entry_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryEndDt)
                    .HasColumnName("entry_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactPayApprBy)
                    .HasColumnName("FACT_pay_appr_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactPayApprDt)
                    .HasColumnName("FACT_pay_appr_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactPaySent)
                    .HasColumnName("FACT_pay_sent")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HBillDate)
                    .HasColumnName("h_bill_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HBillNo)
                    .HasColumnName("h_bill_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HBillRecvdDate)
                    .HasColumnName("h_bill_recvd_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HBillYn)
                    .HasColumnName("h_bill_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.HospAccepFlagDt)
                    .HasColumnName("hosp_accep_flag_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.HospAccepFlagUpdatedby).HasColumnName("hosp_accep_flag_updatedby");

                entity.Property(e => e.HospAcceptanceFlag)
                    .HasColumnName("hosp_acceptance_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasColumnName("hospital_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.InsChqPayableTo)
                    .HasColumnName("ins_chq_payable_to")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsClaimNo)
                    .HasColumnName("ins_claim_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsClaimNoUploadedDt)
                    .HasColumnName("ins_claim_no_Uploaded_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsCoDiv)
                    .HasColumnName("ins_co_div")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsCoId)
                    .HasColumnName("ins_co_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsIntiDt)
                    .HasColumnName("ins_inti_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsQueryBy)
                    .HasColumnName("ins_query_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsQueryEndDt)
                    .HasColumnName("ins_query_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsQueryStartDt)
                    .HasColumnName("ins_query_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpqBy)
                    .HasColumnName("ipq_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IpqEndDt)
                    .HasColumnName("ipq_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpqStartDt)
                    .HasColumnName("ipq_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpqYn)
                    .HasColumnName("ipq_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KpiIncludeYn)
                    .HasColumnName("kpi_include_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LocNo)
                    .HasColumnName("loc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniShop)
                    .HasColumnName("mini_shop")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniShop1)
                    .HasColumnName("mini_shop1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnholdBy)
                    .HasColumnName("onhold_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnholdEndDt)
                    .HasColumnName("onhold_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnholdRemarks)
                    .HasColumnName("onhold_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnholdStartDt)
                    .HasColumnName("onhold_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnholdUpdatedBy)
                    .HasColumnName("onhold_updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnholdUpdatedDt)
                    .HasColumnName("onhold_updated_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenEnteredBy)
                    .HasColumnName("open_entered_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenEnteredOn)
                    .HasColumnName("open_entered_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenStatus)
                    .HasColumnName("open_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPay)
                    .IsRequired()
                    .HasColumnName("partial_pay")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PayApprBy)
                    .HasColumnName("pay_appr_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayApprDt)
                    .HasColumnName("pay_appr_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayRecvdConfirmBy).HasColumnName("pay_recvd_confirm_by");

                entity.Property(e => e.PayRecvdConfirmDt)
                    .HasColumnName("pay_recvd_confirm_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayRecvdFromInsDate)
                    .HasColumnName("pay_recvd_from_ins_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayReportBy)
                    .HasColumnName("pay_report_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayReportDt)
                    .HasColumnName("pay_report_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaySent)
                    .HasColumnName("pay_sent")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrevClaimantId).HasColumnName("prev_claimant_id");

                entity.Property(e => e.PrevEmployeeId).HasColumnName("prev_employee_id");

                entity.Property(e => e.PrevInsIntiDt)
                    .HasColumnName("prev_ins_inti_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreviousClaimId).HasColumnName("previous_claim_id");

                entity.Property(e => e.ProceId)
                    .HasColumnName("proce_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QCheckBy)
                    .HasColumnName("q_check_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QCheckEndDt)
                    .HasColumnName("q_check_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.QCheckStartDt)
                    .HasColumnName("q_check_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.RejectionFlag)
                    .IsRequired()
                    .HasColumnName("Rejection_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScanBy)
                    .HasColumnName("scan_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanEndDt)
                    .HasColumnName("scan_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScanStartDt)
                    .HasColumnName("scan_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchInsDate)
                    .HasColumnName("sch_ins_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SentToBrBy)
                    .HasColumnName("sent_to_br_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentToBrEndDt)
                    .HasColumnName("sent_to_br_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SentToBrStartDt)
                    .HasColumnName("sent_to_br_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SentToInsBy)
                    .HasColumnName("sent_to_ins_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TdsAmount)
                    .HasColumnName("TDS_Amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TdsAmountRcvdDate)
                    .HasColumnName("TDS_amount_rcvd_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TdsFileGenDate)
                    .HasColumnName("TDS_File_Gen_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TdsPercentage)
                    .HasColumnName("tds_percentage")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.TdsRcvdFlag)
                    .HasColumnName("TDS_rcvd_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TopupCaseFlag)
                    .HasColumnName("Topup_case_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotAmtApproved)
                    .HasColumnName("tot_amt_approved")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotAmtClaimed)
                    .HasColumnName("tot_amt_claimed")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotAmtClaimedIns)
                    .HasColumnName("tot_amt_claimed_ins")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotAmtPassedIns)
                    .HasColumnName("tot_amt_passed_ins")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeOfBill)
                    .HasColumnName("type_of_bill")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("Update_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UrlNo)
                    .IsRequired()
                    .HasColumnName("url_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherNo)
                    .HasColumnName("voucher_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimsAsheet>(entity =>
            {
                entity.HasKey(e => e.AsheetId)
                    .HasName("pk_asheet_id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("claims_asheet");

                entity.Property(e => e.AsheetId)
                    .HasColumnName("asheet_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("active_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AssessedBy)
                    .HasColumnName("assessed_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRemark)
                    .HasColumnName("audit_remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitDetailsComp)
                    .HasColumnName("benefit_details_comp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaseType)
                    .HasColumnName("case_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId)
                    .HasColumnName("claim_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ClaimantId)
                    .HasColumnName("claimant_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ClientPpnYn)
                    .HasColumnName("client_ppn_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CopayPaidByEmp)
                    .HasColumnName("copay_paid_by_emp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CopayPayableByEmp)
                    .HasColumnName("copay_payable_by_emp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CopayRefundToEmp)
                    .HasColumnName("copay_refund_to_emp")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CopayYn)
                    .HasColumnName("copay_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CriticalIllnessApplied)
                    .HasColumnName("critical_illness_applied")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiagCode)
                    .HasColumnName("diag_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiagName)
                    .HasColumnName("diag_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Doa)
                    .HasColumnName("doa")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dod)
                    .HasColumnName("dod")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpAmt)
                    .HasColumnName("emp_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EntredBy)
                    .HasColumnName("entred_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntredDt)
                    .HasColumnName("entred_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExepBy)
                    .HasColumnName("exep_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExepDate)
                    .HasColumnName("exep_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExepFor)
                    .HasColumnName("exep_for")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExepReason)
                    .HasColumnName("exep_reason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExepYn)
                    .HasColumnName("exep_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlotterAmt)
                    .HasColumnName("flotter_amt")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.GenRoomDays)
                    .HasColumnName("gen_room_days")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.GipsaRemDescription)
                    .HasColumnName("Gipsa_rem_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GipsaRemarks).HasColumnName("Gipsa_remarks");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpPlanId).HasColumnName("grp_plan_id");

                entity.Property(e => e.HospAddress)
                    .HasColumnName("hosp_address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HospAmt)
                    .HasColumnName("hosp_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.HospDisallowAmt)
                    .HasColumnName("hosp_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HospName)
                    .HasColumnName("hosp_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasColumnName("hospital_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IcuRoomDays)
                    .HasColumnName("icu_room_days")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.IncompleteReason)
                    .HasColumnName("incomplete_reason")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IncompleteStatus)
                    .HasColumnName("incomplete_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsDisallowAmt)
                    .HasColumnName("ins_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceTo)
                    .HasColumnName("invoice_to")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MemberCode)
                    .HasColumnName("member_code")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MnBillNo)
                    .HasColumnName("mn_bill_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NetAccptBy)
                    .HasColumnName("net_accpt_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAccptDt)
                    .HasColumnName("net_accpt_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetAccptYn)
                    .HasColumnName("net_accpt_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NetDisallowAmt)
                    .HasColumnName("net_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfDoc)
                    .HasColumnName("no_of_doc")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Observation)
                    .HasColumnName("observation")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrgFlotter)
                    .HasColumnName("org_flotter")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PartnerClaimId).HasColumnName("partner_claim_id");

                entity.Property(e => e.PrevClaimantId).HasColumnName("prev_claimant_id");

                entity.Property(e => e.PrevMemberId).HasColumnName("prev_member_id");

                entity.Property(e => e.PriDiagIcd10)
                    .HasColumnName("pri_diag_icd10")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PriDiagId)
                    .HasColumnName("pri_diag_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PriProcId)
                    .HasColumnName("pri_proc_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ProcCode)
                    .HasColumnName("proc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcName)
                    .HasColumnName("proc_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingAt)
                    .HasColumnName("processing_at")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PropDedApplyYn)
                    .HasColumnName("prop_ded_apply_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionalDiag)
                    .HasColumnName("provisional_diag")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QCheckReqYn)
                    .HasColumnName("q_check_req_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ReconciledBy)
                    .HasColumnName("reconciled_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomCapApplyYn)
                    .HasColumnName("room_cap_apply_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RoomType)
                    .HasColumnName("Room_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecDiag1Icd10)
                    .HasColumnName("sec_diag1_icd10")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SecDiag1Id)
                    .HasColumnName("sec_diag1_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.SecDiag2Icd10)
                    .HasColumnName("sec_diag2_icd10")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SecDiag2Id)
                    .HasColumnName("sec_diag2_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.SecProc1Id)
                    .HasColumnName("sec_proc1_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.SecProc2Id)
                    .HasColumnName("sec_proc2_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TariffRemark)
                    .HasColumnName("tariff_remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerDiagIcd10)
                    .HasColumnName("ter_diag_icd10")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TerDiagId)
                    .HasColumnName("ter_diag_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TerProcId)
                    .HasColumnName("ter_proc_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.UhcDisallowAmt)
                    .HasColumnName("uhc_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("Update_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UrlNo)
                    .HasColumnName("url_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimsAsheetDetails>(entity =>
            {
                entity.HasKey(e => e.AsheetDetailsId)
                    .HasName("pk_asheet_details_id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("claims_asheet_details");

                entity.Property(e => e.AsheetDetailsId)
                    .HasColumnName("asheet_details_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("active_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AsheetId)
                    .HasColumnName("asheet_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BillDt)
                    .HasColumnName("bill_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasColumnName("bill_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .HasColumnName("bill_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CaeApprAmt)
                    .HasColumnName("cae_appr_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ClaimedAmt)
                    .HasColumnName("claimed_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.DisAmt)
                    .HasColumnName("dis_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.DrAmt)
                    .HasColumnName("dr_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrDesc)
                    .HasColumnName("dr_desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntredBy)
                    .HasColumnName("entred_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntredDt)
                    .HasColumnName("entred_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EobCode)
                    .HasColumnName("eob_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EobId)
                    .HasColumnName("eob_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EobReason)
                    .HasColumnName("eob_reason")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HospApprAmt)
                    .HasColumnName("hosp_appr_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HospDisallowAmt)
                    .HasColumnName("hosp_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InDr)
                    .HasColumnName("in_dr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InsApprAmt)
                    .HasColumnName("ins_appr_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.InsDisallowAmt)
                    .HasColumnName("ins_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApprAmt)
                    .HasColumnName("net_appr_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDisallowAmt)
                    .HasColumnName("net_disallow_amt")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("service_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ClaimsAsheetDocRec>(entity =>
            {
                entity.HasKey(e => e.ClaimsDocRecId)
                    .HasName("pk_claims_asheet_doc_rec");

                entity.ToTable("claims_asheet_doc_rec");

                entity.Property(e => e.ClaimsDocRecId)
                    .HasColumnName("claims_doc_rec_id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AsheetDetailsId)
                    .HasColumnName("asheet_details_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.AsheetId)
                    .HasColumnName("asheet_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CloserReminder)
                    .HasColumnName("closer_reminder")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDocRecdAtMumbai)
                    .HasColumnName("date_doc_recd_at_mumbai")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDocRecdFromEmp)
                    .HasColumnName("date_doc_recd_from_emp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDocSentToMumbai)
                    .HasColumnName("date_doc_sent_to_mumbai")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNonRecepitTag)
                    .HasColumnName("doc_non_recepit_tag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocRecId)
                    .HasColumnName("doc_rec_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DocRecvdAtBrBy)
                    .HasColumnName("doc_recvd_at_br_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocRecvdAtBrRemark)
                    .HasColumnName("doc_recvd_at_br_remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DrAmt)
                    .HasColumnName("dr_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.DrCount)
                    .HasColumnName("dr_count")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DrDescRemark)
                    .HasColumnName("dr_desc_remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DrReceiptReason)
                    .HasColumnName("dr_receipt_reason")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntredBy)
                    .HasColumnName("entred_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntredDt)
                    .HasColumnName("entred_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailureMarkDt)
                    .HasColumnName("failure_mark_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailureYn)
                    .IsRequired()
                    .HasColumnName("failure_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FirstContact)
                    .HasColumnName("first_contact")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstContactRemark)
                    .HasColumnName("first_contact_remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstContactYn)
                    .HasColumnName("first_contact_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FirstReminder)
                    .HasColumnName("first_reminder")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstReminderRemark)
                    .HasColumnName("first_reminder_remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstReminderSentYn)
                    .HasColumnName("first_reminder_sent_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InDr)
                    .HasColumnName("in_dr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NextFallowupDt)
                    .HasColumnName("next_fallowup_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonOfNonRecepit)
                    .HasColumnName("reason_of_non_recepit")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecoveryEndDt)
                    .HasColumnName("recovery_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecoveryFor)
                    .HasColumnName("recovery_for")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecoveryFrom)
                    .HasColumnName("recovery_from")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecoveryStartDt)
                    .HasColumnName("recovery_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks1)
                    .HasColumnName("remarks1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks2)
                    .HasColumnName("remarks2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderMode)
                    .HasColumnName("reminder_mode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderStatus)
                    .HasColumnName("reminder_status")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecReminder)
                    .HasColumnName("sec_reminder")
                    .HasColumnType("datetime");

                entity.Property(e => e.SecReminderRemark)
                    .HasColumnName("sec_reminder_remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecReminderSentYn)
                    .HasColumnName("sec_reminder_sent_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ThirdReminder)
                    .HasColumnName("third_reminder")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThirdReminderRemark)
                    .HasColumnName("third_reminder_remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdReminderSentYn)
                    .HasColumnName("third_reminder_sent_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ClaimsAssignTracker>(entity =>
            {
                entity.HasKey(e => e.AssignedId);

                entity.ToTable("claims_assign_tracker");

                entity.Property(e => e.AssignedId).HasColumnName("assigned_id");

                entity.Property(e => e.ActiveFlag)
                    .HasColumnName("active_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssignStartDt)
                    .HasColumnName("assign_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assigned_to")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("created_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrackerId).HasColumnName("tracker_id");
            });

            modelBuilder.Entity<ClaimsBill>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK_CLAIMS_BILL");

                entity.ToTable("claims_bill");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("active_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Advance)
                    .HasColumnName("advance")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.BillIdTemp).HasColumnName("bill_id_temp");

                entity.Property(e => e.CaeEndDt)
                    .HasColumnName("cae_end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaeStartDt)
                    .HasColumnName("cae_start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CfDocBy)
                    .HasColumnName("cf_doc_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CfNo)
                    .HasColumnName("cf_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CfRecvdDate)
                    .HasColumnName("cf_recvd_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CfSgrBy)
                    .HasColumnName("cf_sgr_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CfSgrDate)
                    .HasColumnName("cf_sgr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClaimAmount)
                    .HasColumnName("claim_amount")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ClaimClearedYn)
                    .HasColumnName("claim_cleared_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDt)
                    .HasColumnName("claim_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnName("claim_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closed_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDt)
                    .HasColumnName("closed_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosedYn)
                    .HasColumnName("closed_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DataEntryBy)
                    .HasColumnName("data_entry_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEntryDt)
                    .HasColumnName("data_entry_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagCode)
                    .HasColumnName("diag_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DiagId)
                    .HasColumnName("diag_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Doa)
                    .HasColumnName("doa")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dod)
                    .HasColumnName("dod")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EntryBy)
                    .HasColumnName("entry_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDt)
                    .HasColumnName("entry_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EobNo)
                    .HasColumnName("eob_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EobReason)
                    .HasColumnName("eob_reason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Exgratia)
                    .HasColumnName("exgratia")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HospName)
                    .HasColumnName("hosp_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasColumnName("hospital_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.InsDisAmt)
                    .HasColumnName("ins_dis_amt")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.InsIntiDt)
                    .HasColumnName("ins_inti_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MemberCode)
                    .HasColumnName("member_code")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PlanType)
                    .HasColumnName("plan_type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PrevMemberId).HasColumnName("prev_member_id");

                entity.Property(e => e.ProcCode)
                    .HasColumnName("proc_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QcFlag)
                    .HasColumnName("qc_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RejBy)
                    .HasColumnName("rej_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejDt)
                    .HasColumnName("rej_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.RejFlag)
                    .HasColumnName("rej_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceGroupCode)
                    .HasColumnName("service_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("Update_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherNo)
                    .HasColumnName("voucher_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimsBillDetails>(entity =>
            {
                entity.HasKey(e => e.BillDetailsId)
                    .HasName("PK_CLAIMS_BILL_DETAILS");

                entity.ToTable("claims_bill_details");

                entity.Property(e => e.BillDetailsId)
                    .HasColumnName("bill_details_id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("active_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AmtClaimed)
                    .HasColumnName("amt_claimed")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.AmtExgratia)
                    .HasColumnName("amt_exgratia")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.AmtPayable)
                    .HasColumnName("amt_payable")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.BillDt)
                    .HasColumnName("bill_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BillNo)
                    .HasColumnName("bill_no")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CareType)
                    .IsRequired()
                    .HasColumnName("care_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CfNo)
                    .HasColumnName("cf_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimantId).HasColumnName("claimant_id");

                entity.Property(e => e.CoPayExcessAmt)
                    .HasColumnName("co_pay_excess_amt")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.EmailPartialdocCommuEmailRefId).HasColumnName("email_partialdoc_commu_email_ref_id");

                entity.Property(e => e.EmailPartialdocCommuEmailSent)
                    .HasColumnName("email_partialdoc_commu_email_sent")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EntryBy)
                    .HasColumnName("entry_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDt)
                    .HasColumnName("entry_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EobNo)
                    .HasColumnName("eob_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileExt)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FileNames)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FromDt)
                    .HasColumnName("from_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PrevMemberId).HasColumnName("prev_member_id");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasColumnName("relation")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("service_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceGroupCode)
                    .HasColumnName("service_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasColumnName("sr_no")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ToDt)
                    .HasColumnName("to_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("Update_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocRecoveryMaster>(entity =>
            {
                entity.HasKey(e => new { e.DocRecType, e.RequiredForDept, e.DocRecDesc })
                    .HasName("pk_doc_recovery_master");

                entity.ToTable("doc_recovery_master");

                entity.Property(e => e.DocRecType)
                    .HasColumnName("doc_rec_type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredForDept)
                    .HasColumnName("required_for_dept")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocRecDesc)
                    .HasColumnName("doc_rec_desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocRecId)
                    .HasColumnName("doc_rec_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EntredBy)
                    .HasColumnName("entred_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntredDt)
                    .HasColumnName("entred_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqdYn)
                    .HasColumnName("reqd_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DrReminder>(entity =>
            {
                entity.ToTable("dr_reminder");

                entity.Property(e => e.DrReminderId).HasColumnName("dr_reminder_id");

                entity.Property(e => e.ClientType)
                    .HasColumnName("client_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("created_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncludeWeekend)
                    .HasColumnName("include_weekend")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Interval).HasColumnName("interval");

                entity.Property(e => e.Reminder).HasColumnName("reminder");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("updated_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.MemId)
                    .HasName("PK__member__7EF6D905");

                entity.ToTable("member");

                entity.Property(e => e.MemId).HasColumnName("mem_id");

                entity.Property(e => e.AdditionMailFlag).HasColumnName("Addition_Mail_Flag");

                entity.Property(e => e.AmexPiEmpId)
                    .HasColumnName("Amex_PI_Emp_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Band)
                    .HasColumnName("band")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompGrade)
                    .HasColumnName("comp_grade")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmFlag)
                    .HasColumnName("confirm_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EkId)
                    .HasColumnName("ek_id")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GreenFlag)
                    .HasColumnName("green_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GroupGradeId).HasColumnName("group_grade_id");

                entity.Property(e => e.GrpCode)
                    .IsRequired()
                    .HasColumnName("grp_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrpDesgId).HasColumnName("grp_desg_id");

                entity.Property(e => e.GrpId).HasColumnName("grp_id");

                entity.Property(e => e.HealthCheckupFlag)
                    .HasColumnName("health_checkup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HlplanTypeId).HasColumnName("hlplan_type_id");

                entity.Property(e => e.HrApprBy)
                    .HasColumnName("hr_appr_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HrApprDt)
                    .HasColumnName("hr_appr_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.HrApprFlag)
                    .HasColumnName("hr_appr_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredLastYear).HasColumnName("Insured_Last_year");

                entity.Property(e => e.IsDom)
                    .HasColumnName("isDom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsSelfFunded)
                    .HasColumnName("isSelfFunded")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemActiveFlag)
                    .HasColumnName("mem_active_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MemAddAvlFlag)
                    .HasColumnName("mem_add_avl_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MemAddPdfSent)
                    .HasColumnName("mem_add_pdf_sent")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemAddPdfSentDt)
                    .HasColumnName("mem_add_pdf_sent_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemAltEmpNo)
                    .HasColumnName("mem_alt_emp_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemBabyOfFlag)
                    .HasColumnName("mem_baby_of_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemClientGrade)
                    .HasColumnName("mem_client_grade")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MemCode).HasColumnName("mem_code");

                entity.Property(e => e.MemCostCenterId).HasColumnName("mem_CostCenterID");

                entity.Property(e => e.MemCreatedBy)
                    .HasColumnName("mem_created_by")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemCreatedDt)
                    .HasColumnName("mem_created_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemDelPdfSent)
                    .HasColumnName("mem_del_pdf_sent")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemDelPdfSentDt)
                    .HasColumnName("mem_del_pdf_sent_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemDeleteVerifyBy)
                    .HasColumnName("mem_delete_verify_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MemDeleteVerifyDt)
                    .HasColumnName("mem_delete_verify_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemDeleteVerifyFlag)
                    .HasColumnName("mem_delete_verify_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemDeptId).HasColumnName("mem_dept_id");

                entity.Property(e => e.MemDob)
                    .HasColumnName("mem_dob")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemDoc)
                    .HasColumnName("mem_DOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemDot)
                    .HasColumnName("mem_dot")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemEmpNo).HasColumnName("mem_emp_no");

                entity.Property(e => e.MemEntityId).HasColumnName("mem_entity_id");

                entity.Property(e => e.MemGrpDisclaimer)
                    .HasColumnName("mem_grp_disclaimer")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemGrpDisclaimerUpdatedDt)
                    .HasColumnName("mem_grp_disclaimer_updated_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemIenrollExpFlag)
                    .IsRequired()
                    .HasColumnName("mem_ienroll_exp_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MemJoinDt)
                    .HasColumnName("mem_join_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLapsedAckRcvdDt)
                    .HasColumnName("mem_lapsed_ack_rcvd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLapsedDt)
                    .HasColumnName("mem_lapsed_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLapsedFlag)
                    .HasColumnName("mem_lapsed_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MemLapsedIntToInsCo)
                    .HasColumnName("mem_lapsed_int_to_ins_co")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLapsedIntToUhci)
                    .HasColumnName("mem_lapsed_int_to_uhci")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLapsedReason)
                    .HasColumnName("mem_lapsed_reason")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemLapsedRemarks)
                    .HasColumnName("mem_lapsed_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemLeavingDt)
                    .HasColumnName("mem_leaving_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemLocationId).HasColumnName("mem_location_id");

                entity.Property(e => e.MemMailZoneId).HasColumnName("mem_MailZoneID");

                entity.Property(e => e.MemMarriageDt)
                    .HasColumnName("mem_marriage_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMartialStatus)
                    .HasColumnName("mem_martial_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemMasterlistId).HasColumnName("mem_masterlist_id");

                entity.Property(e => e.MemMasterlistRcvdDt)
                    .HasColumnName("mem_masterlist_rcvd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMasterlistRcvdFrm)
                    .HasColumnName("mem_masterlist_rcvd_frm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemMgrEmail)
                    .HasColumnName("mem_MgrEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemMgrName)
                    .HasColumnName("mem_MgrName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemMisId).HasColumnName("mem_mis_id");

                entity.Property(e => e.MemMisRcvdBoDt)
                    .HasColumnName("mem_mis_rcvd_bo_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMisRcvdHoDt)
                    .HasColumnName("mem_mis_rcvd_ho_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMisVerifyBy)
                    .HasColumnName("mem_mis_verify_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemMisVerifyDt)
                    .HasColumnName("mem_mis_verify_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMisVerifyFlag)
                    .HasColumnName("mem_mis_verify_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemMtiFlag)
                    .HasColumnName("mem_mti_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MemMtiFlagDt)
                    .HasColumnName("mem_mti_flag_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemMtiUnflagDt)
                    .HasColumnName("mem_mti_unflag_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemName)
                    .IsRequired()
                    .HasColumnName("mem_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemPanCard)
                    .HasColumnName("memPanCard")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MemParentsDisclaimer)
                    .HasColumnName("mem_parents_disclaimer")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemParentsDisclaimerUpdatedDt)
                    .HasColumnName("mem_parents_disclaimer_updated_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemQcRequired)
                    .HasColumnName("mem_qc_required")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MemRefundFlag)
                    .HasColumnName("mem_refund_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MemRefundReason)
                    .HasColumnName("mem_refund_reason")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MemRegionId).HasColumnName("mem_RegionID");

                entity.Property(e => e.MemRelId)
                    .HasColumnName("mem_rel_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemRemarks)
                    .HasColumnName("mem_remarks")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemSex)
                    .HasColumnName("mem_sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemSpDolDt)
                    .HasColumnName("mem_sp_dol_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemSpIpReqDt)
                    .HasColumnName("mem_sp_ip_req_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemTempCoverlevel)
                    .HasColumnName("mem_temp_coverlevel")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.MemTitle)
                    .HasColumnName("mem_title")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemUnlapsedDt)
                    .HasColumnName("mem_unlapsed_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemUnlapsedRemarks)
                    .HasColumnName("mem_unlapsed_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemUpdatedBy)
                    .HasColumnName("mem_updated_by")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemUpdatedDt)
                    .HasColumnName("mem_updated_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemVipFlag)
                    .HasColumnName("mem_vip_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NameToBePrintedOnIdcard)
                    .HasColumnName("Name_to_be_printed_On_IDCard")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationId).HasColumnName("occupation_id");

                entity.Property(e => e.OnlineEnrollmentDt)
                    .HasColumnName("OnlineEnrollment_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnlineStatusBy)
                    .HasColumnName("OnlineStatus_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnlineStatusDate)
                    .HasColumnName("OnlineStatus_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnlineStatusFlag).HasColumnName("OnlineStatus_flag");

                entity.Property(e => e.ParentsEnrollFor3yr)
                    .IsRequired()
                    .HasColumnName("ParentsEnroll_for_3yr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ParentsEnrollFor3yrFromDt)
                    .HasColumnName("ParentsEnroll_for_3yr_From_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelExtendedFlag)
                    .HasColumnName("rel_extended_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialStatus)
                    .HasColumnName("special_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SummaryForCtsMailFlag)
                    .HasColumnName("Summary_For_CTS_Mail_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SybaseCurrentPeriod)
                    .HasColumnName("sybase_current_period")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.SybaseMemberId)
                    .HasColumnName("sybase_member_id")
                    .HasColumnType("numeric(10, 0)");
            });
        }
    }
}
