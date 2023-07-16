using Bogus_MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace Bogus_MVC_.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


        public virtual DbSet<PostTran> PostTrans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("post_tran");

                entity.Property(e => e.AbortRspCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("abort_rsp_code")
                    .IsFixedLength();

                entity.Property(e => e.AcquirerNetworkId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("acquirer_network_id");

                entity.Property(e => e.AcquiringInstIdCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("acquiring_inst_id_code");

                entity.Property(e => e.AdditionalRspData)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("additional_rsp_data");

                entity.Property(e => e.AuthIdRsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("auth_id_rsp");

                entity.Property(e => e.AuthReason)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auth_reason");

                entity.Property(e => e.AuthType)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auth_type");

                entity.Property(e => e.BankDetails)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("bank_details");

                entity.Property(e => e.BatchNr).HasColumnName("batch_nr");

                entity.Property(e => e.CardVerificationResult)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("card_verification_result")
                    .IsFixedLength();

                entity.Property(e => e.CreditDebitConversion).HasColumnName("credit_debit_conversion");

                entity.Property(e => e.Cvv2AvailableAtAuth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cvv2_available_at_auth")
                    .IsFixedLength();

                entity.Property(e => e.CvvAvailableAtAuth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cvv_available_at_auth")
                    .IsFixedLength();

                entity.Property(e => e.DatetimeReq)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_req");

                entity.Property(e => e.DatetimeRsp)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_rsp");

                entity.Property(e => e.DatetimeTranGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_tran_gmt");

                entity.Property(e => e.DatetimeTranLocal)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_tran_local");

                entity.Property(e => e.ExtendedTranType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extended_tran_type")
                    .IsFixedLength();

                entity.Property(e => e.FromAccountId)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("from_account_id");

                entity.Property(e => e.FromAccountIdCs).HasColumnName("from_account_id_cs");

                entity.Property(e => e.FromAccountType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("from_account_type")
                    .IsFixedLength();

                entity.Property(e => e.FromAccountTypeQualifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("from_account_type_qualifier")
                    .IsFixedLength();

                entity.Property(e => e.IccDataReq).HasColumnName("icc_data_req");

                entity.Property(e => e.IccDataRsp).HasColumnName("icc_data_rsp");

                entity.Property(e => e.IssuerNetworkId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("issuer_network_id");

                entity.Property(e => e.MappedExtdCaIdCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("mapped_extd_ca_id_code");

                entity.Property(e => e.MappedExtdCaTermId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("mapped_extd_ca_term_id");

                entity.Property(e => e.MappedTerminalId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("mapped_terminal_id")
                    .IsFixedLength();

                entity.Property(e => e.MessageReasonCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("message_reason_code")
                    .IsFixedLength();

                entity.Property(e => e.MessageType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("message_type")
                    .IsFixedLength();

                entity.Property(e => e.NetworkFeeActual)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("network_fee_actual");

                entity.Property(e => e.NetworkFeeMax)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("network_fee_max");

                entity.Property(e => e.NetworkFeeMin)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("network_fee_min");

                entity.Property(e => e.NetworkProgramIdActual)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("network_program_id_actual");

                entity.Property(e => e.NetworkProgramIdMin)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("network_program_id_min");

                entity.Property(e => e.NextPostTranId).HasColumnName("next_post_tran_id");

                entity.Property(e => e.OnlineSystemId).HasColumnName("online_system_id");

                entity.Property(e => e.OppParticipantId).HasColumnName("opp_participant_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Payee)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("payee")
                    .IsFixedLength();

                entity.Property(e => e.PayerAccountId)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("payer_account_id");

                entity.Property(e => e.PosConditionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("pos_condition_code")
                    .IsFixedLength();

                entity.Property(e => e.PosEntryMode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("pos_entry_mode")
                    .IsFixedLength();

                entity.Property(e => e.PosGeographicData)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("pos_geographic_data")
                    .IsFixedLength();

                entity.Property(e => e.PostTranCustId).HasColumnName("post_tran_cust_id");

                entity.Property(e => e.PostTranId).HasColumnName("post_tran_id");

                entity.Property(e => e.PrevPostTranId).HasColumnName("prev_post_tran_id");

                entity.Property(e => e.PrevTranApproved)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("prev_tran_approved");

                entity.Property(e => e.ProcOnlineSystemId).HasColumnName("proc_online_system_id");

                entity.Property(e => e.PtPosCardInputMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_card_input_mode")
                    .IsFixedLength();

                entity.Property(e => e.PtPosCardholderAuthMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_cardholder_auth_method")
                    .IsFixedLength();

                entity.Property(e => e.PtPosOperatingEnvironment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_operating_environment")
                    .IsFixedLength();

                entity.Property(e => e.PtPosPinCaptureAbility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_pin_capture_ability")
                    .IsFixedLength();

                entity.Property(e => e.PtPosTerminalOperator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_terminal_operator")
                    .IsFixedLength();

                entity.Property(e => e.RealtimeBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("realtime_business_date");

                entity.Property(e => e.ReceivingInstIdCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("receiving_inst_id_code");

                entity.Property(e => e.ReconBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recon_business_date");

                entity.Property(e => e.RetentionData)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("retention_data");

                entity.Property(e => e.RetrievalReferenceNr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("retrieval_reference_nr")
                    .IsFixedLength();

                entity.Property(e => e.RoutingType).HasColumnName("routing_type");

                entity.Property(e => e.RspCodeReq)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_req")
                    .IsFixedLength();

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp")
                    .IsFixedLength();

                entity.Property(e => e.SettleAmountImpact)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_impact");

                entity.Property(e => e.SettleAmountReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_req");

                entity.Property(e => e.SettleAmountRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_rsp");

                entity.Property(e => e.SettleCashReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_cash_req");

                entity.Property(e => e.SettleCashRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_cash_rsp");

                entity.Property(e => e.SettleCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("settle_currency_code")
                    .IsFixedLength();

                entity.Property(e => e.SettleEntityId).HasColumnName("settle_entity_id");

                entity.Property(e => e.SettleProcFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_proc_fee_req");

                entity.Property(e => e.SettleProcFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_proc_fee_rsp");

                entity.Property(e => e.SettleTranFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_tran_fee_req");

                entity.Property(e => e.SettleTranFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_tran_fee_rsp");

                entity.Property(e => e.SinkNodeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sink_node_name");

                entity.Property(e => e.SourceNodeKey)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("source_node_key");

                entity.Property(e => e.SponsorBank)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("sponsor_bank")
                    .IsFixedLength();

                entity.Property(e => e.StructuredDataReq).HasColumnName("structured_data_req");

                entity.Property(e => e.StructuredDataRsp).HasColumnName("structured_data_rsp");

                entity.Property(e => e.SystemTraceAuditNr)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("system_trace_audit_nr")
                    .IsFixedLength();

                entity.Property(e => e.ToAccountId)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("to_account_id");

                entity.Property(e => e.ToAccountIdCs).HasColumnName("to_account_id_cs");

                entity.Property(e => e.ToAccountType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("to_account_type")
                    .IsFixedLength();

                entity.Property(e => e.ToAccountTypeQualifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("to_account_type_qualifier")
                    .IsFixedLength();

                entity.Property(e => e.TranAmountReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_amount_req");

                entity.Property(e => e.TranAmountRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_amount_rsp");

                entity.Property(e => e.TranCashReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_cash_req");

                entity.Property(e => e.TranCashRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_cash_rsp");

                entity.Property(e => e.TranCompleted)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tran_completed");

                entity.Property(e => e.TranCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_currency_code")
                    .IsFixedLength();

                entity.Property(e => e.TranNr).HasColumnName("tran_nr");

                entity.Property(e => e.TranPostilionOriginated)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tran_postilion_originated");

                entity.Property(e => e.TranProcFeeCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_proc_fee_currency_code")
                    .IsFixedLength();

                entity.Property(e => e.TranProcFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_proc_fee_req");

                entity.Property(e => e.TranProcFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_proc_fee_rsp");

                entity.Property(e => e.TranReversed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tran_reversed")
                    .IsFixedLength();

                entity.Property(e => e.TranTranFeeCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_tran_fee_currency_code")
                    .IsFixedLength();

                entity.Property(e => e.TranTranFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_tran_fee_req");

                entity.Property(e => e.TranTranFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_tran_fee_rsp");

                entity.Property(e => e.TranType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tran_type")
                    .IsFixedLength();

                entity.Property(e => e.UcafData)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("ucaf_data");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
