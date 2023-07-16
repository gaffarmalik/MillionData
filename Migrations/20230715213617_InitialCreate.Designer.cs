﻿// <auto-generated />
using System;
using Bogus_MVC_.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bogus_MVC_.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230715213617_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bogus_MVC_.Models.PostTran", b =>
                {
                    b.Property<string>("AbortRspCode")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("abort_rsp_code")
                        .IsFixedLength();

                    b.Property<string>("AcquirerNetworkId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("acquirer_network_id");

                    b.Property<string>("AcquiringInstIdCode")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("acquiring_inst_id_code");

                    b.Property<string>("AdditionalRspData")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("additional_rsp_data");

                    b.Property<string>("AuthIdRsp")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("auth_id_rsp");

                    b.Property<decimal?>("AuthReason")
                        .HasColumnType("numeric(1,0)")
                        .HasColumnName("auth_reason");

                    b.Property<decimal?>("AuthType")
                        .HasColumnType("numeric(1,0)")
                        .HasColumnName("auth_type");

                    b.Property<string>("BankDetails")
                        .HasMaxLength(31)
                        .IsUnicode(false)
                        .HasColumnType("varchar(31)")
                        .HasColumnName("bank_details");

                    b.Property<int?>("BatchNr")
                        .HasColumnType("int")
                        .HasColumnName("batch_nr");

                    b.Property<string>("CardVerificationResult")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("card_verification_result")
                        .IsFixedLength();

                    b.Property<byte?>("CreditDebitConversion")
                        .HasColumnType("tinyint")
                        .HasColumnName("credit_debit_conversion");

                    b.Property<string>("Cvv2AvailableAtAuth")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("cvv2_available_at_auth")
                        .IsFixedLength();

                    b.Property<string>("CvvAvailableAtAuth")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("cvv_available_at_auth")
                        .IsFixedLength();

                    b.Property<DateTime?>("DatetimeReq")
                        .HasColumnType("datetime")
                        .HasColumnName("datetime_req");

                    b.Property<DateTime?>("DatetimeRsp")
                        .HasColumnType("datetime")
                        .HasColumnName("datetime_rsp");

                    b.Property<DateTime?>("DatetimeTranGmt")
                        .HasColumnType("datetime")
                        .HasColumnName("datetime_tran_gmt");

                    b.Property<DateTime?>("DatetimeTranLocal")
                        .HasColumnType("datetime")
                        .HasColumnName("datetime_tran_local");

                    b.Property<string>("ExtendedTranType")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("extended_tran_type")
                        .IsFixedLength();

                    b.Property<string>("FromAccountId")
                        .HasMaxLength(28)
                        .IsUnicode(false)
                        .HasColumnType("varchar(28)")
                        .HasColumnName("from_account_id");

                    b.Property<int?>("FromAccountIdCs")
                        .HasColumnType("int")
                        .HasColumnName("from_account_id_cs");

                    b.Property<string>("FromAccountType")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("from_account_type")
                        .IsFixedLength();

                    b.Property<string>("FromAccountTypeQualifier")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("from_account_type_qualifier")
                        .IsFixedLength();

                    b.Property<string>("IccDataReq")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("icc_data_req");

                    b.Property<string>("IccDataRsp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("icc_data_rsp");

                    b.Property<string>("IssuerNetworkId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("issuer_network_id");

                    b.Property<string>("MappedExtdCaIdCode")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("mapped_extd_ca_id_code");

                    b.Property<string>("MappedExtdCaTermId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("mapped_extd_ca_term_id");

                    b.Property<string>("MappedTerminalId")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("mapped_terminal_id")
                        .IsFixedLength();

                    b.Property<string>("MessageReasonCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("message_reason_code")
                        .IsFixedLength();

                    b.Property<string>("MessageType")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("message_type")
                        .IsFixedLength();

                    b.Property<decimal?>("NetworkFeeActual")
                        .HasColumnType("numeric(16,4)")
                        .HasColumnName("network_fee_actual");

                    b.Property<decimal?>("NetworkFeeMax")
                        .HasColumnType("numeric(16,4)")
                        .HasColumnName("network_fee_max");

                    b.Property<decimal?>("NetworkFeeMin")
                        .HasColumnType("numeric(16,4)")
                        .HasColumnName("network_fee_min");

                    b.Property<string>("NetworkProgramIdActual")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("network_program_id_actual");

                    b.Property<string>("NetworkProgramIdMin")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("network_program_id_min");

                    b.Property<long?>("NextPostTranId")
                        .HasColumnType("bigint")
                        .HasColumnName("next_post_tran_id");

                    b.Property<int?>("OnlineSystemId")
                        .HasColumnType("int")
                        .HasColumnName("online_system_id");

                    b.Property<int?>("OppParticipantId")
                        .HasColumnType("int")
                        .HasColumnName("opp_participant_id");

                    b.Property<int?>("ParticipantId")
                        .HasColumnType("int")
                        .HasColumnName("participant_id");

                    b.Property<string>("Payee")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("payee")
                        .IsFixedLength();

                    b.Property<string>("PayerAccountId")
                        .HasMaxLength(28)
                        .IsUnicode(false)
                        .HasColumnType("varchar(28)")
                        .HasColumnName("payer_account_id");

                    b.Property<string>("PosConditionCode")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("pos_condition_code")
                        .IsFixedLength();

                    b.Property<string>("PosEntryMode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("pos_entry_mode")
                        .IsFixedLength();

                    b.Property<string>("PosGeographicData")
                        .HasMaxLength(17)
                        .IsUnicode(false)
                        .HasColumnType("char(17)")
                        .HasColumnName("pos_geographic_data")
                        .IsFixedLength();

                    b.Property<long?>("PostTranCustId")
                        .HasColumnType("bigint")
                        .HasColumnName("post_tran_cust_id");

                    b.Property<long?>("PostTranId")
                        .HasColumnType("bigint")
                        .HasColumnName("post_tran_id");

                    b.Property<long?>("PrevPostTranId")
                        .HasColumnType("bigint")
                        .HasColumnName("prev_post_tran_id");

                    b.Property<decimal?>("PrevTranApproved")
                        .HasColumnType("numeric(1,0)")
                        .HasColumnName("prev_tran_approved");

                    b.Property<int?>("ProcOnlineSystemId")
                        .HasColumnType("int")
                        .HasColumnName("proc_online_system_id");

                    b.Property<string>("PtPosCardInputMode")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("pt_pos_card_input_mode")
                        .IsFixedLength();

                    b.Property<string>("PtPosCardholderAuthMethod")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("pt_pos_cardholder_auth_method")
                        .IsFixedLength();

                    b.Property<string>("PtPosOperatingEnvironment")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("pt_pos_operating_environment")
                        .IsFixedLength();

                    b.Property<string>("PtPosPinCaptureAbility")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("pt_pos_pin_capture_ability")
                        .IsFixedLength();

                    b.Property<string>("PtPosTerminalOperator")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("pt_pos_terminal_operator")
                        .IsFixedLength();

                    b.Property<DateTime?>("RealtimeBusinessDate")
                        .HasColumnType("datetime")
                        .HasColumnName("realtime_business_date");

                    b.Property<string>("ReceivingInstIdCode")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("receiving_inst_id_code");

                    b.Property<DateTime?>("ReconBusinessDate")
                        .HasColumnType("datetime")
                        .HasColumnName("recon_business_date");

                    b.Property<string>("RetentionData")
                        .HasMaxLength(999)
                        .IsUnicode(false)
                        .HasColumnType("varchar(999)")
                        .HasColumnName("retention_data");

                    b.Property<string>("RetrievalReferenceNr")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("retrieval_reference_nr")
                        .IsFixedLength();

                    b.Property<int?>("RoutingType")
                        .HasColumnType("int")
                        .HasColumnName("routing_type");

                    b.Property<string>("RspCodeReq")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("rsp_code_req")
                        .IsFixedLength();

                    b.Property<string>("RspCodeRsp")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("rsp_code_rsp")
                        .IsFixedLength();

                    b.Property<decimal?>("SettleAmountImpact")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_amount_impact");

                    b.Property<decimal?>("SettleAmountReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_amount_req");

                    b.Property<decimal?>("SettleAmountRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_amount_rsp");

                    b.Property<decimal?>("SettleCashReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_cash_req");

                    b.Property<decimal?>("SettleCashRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_cash_rsp");

                    b.Property<string>("SettleCurrencyCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("settle_currency_code")
                        .IsFixedLength();

                    b.Property<int?>("SettleEntityId")
                        .HasColumnType("int")
                        .HasColumnName("settle_entity_id");

                    b.Property<decimal?>("SettleProcFeeReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_proc_fee_req");

                    b.Property<decimal?>("SettleProcFeeRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_proc_fee_rsp");

                    b.Property<decimal?>("SettleTranFeeReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_tran_fee_req");

                    b.Property<decimal?>("SettleTranFeeRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("settle_tran_fee_rsp");

                    b.Property<string>("SinkNodeName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("sink_node_name");

                    b.Property<string>("SourceNodeKey")
                        .HasMaxLength(32)
                        .IsUnicode(false)
                        .HasColumnType("varchar(32)")
                        .HasColumnName("source_node_key");

                    b.Property<string>("SponsorBank")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("sponsor_bank")
                        .IsFixedLength();

                    b.Property<string>("StructuredDataReq")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("structured_data_req");

                    b.Property<string>("StructuredDataRsp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("structured_data_rsp");

                    b.Property<string>("SystemTraceAuditNr")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("system_trace_audit_nr")
                        .IsFixedLength();

                    b.Property<string>("ToAccountId")
                        .HasMaxLength(28)
                        .IsUnicode(false)
                        .HasColumnType("varchar(28)")
                        .HasColumnName("to_account_id");

                    b.Property<int?>("ToAccountIdCs")
                        .HasColumnType("int")
                        .HasColumnName("to_account_id_cs");

                    b.Property<string>("ToAccountType")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("to_account_type")
                        .IsFixedLength();

                    b.Property<string>("ToAccountTypeQualifier")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("to_account_type_qualifier")
                        .IsFixedLength();

                    b.Property<decimal?>("TranAmountReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_amount_req");

                    b.Property<decimal?>("TranAmountRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_amount_rsp");

                    b.Property<decimal?>("TranCashReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_cash_req");

                    b.Property<decimal?>("TranCashRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_cash_rsp");

                    b.Property<decimal?>("TranCompleted")
                        .HasColumnType("numeric(1,0)")
                        .HasColumnName("tran_completed");

                    b.Property<string>("TranCurrencyCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("tran_currency_code")
                        .IsFixedLength();

                    b.Property<long?>("TranNr")
                        .HasColumnType("bigint")
                        .HasColumnName("tran_nr");

                    b.Property<decimal?>("TranPostilionOriginated")
                        .HasColumnType("numeric(1,0)")
                        .HasColumnName("tran_postilion_originated");

                    b.Property<string>("TranProcFeeCurrencyCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("tran_proc_fee_currency_code")
                        .IsFixedLength();

                    b.Property<decimal?>("TranProcFeeReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_proc_fee_req");

                    b.Property<decimal?>("TranProcFeeRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_proc_fee_rsp");

                    b.Property<string>("TranReversed")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("tran_reversed")
                        .IsFixedLength();

                    b.Property<string>("TranTranFeeCurrencyCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("tran_tran_fee_currency_code")
                        .IsFixedLength();

                    b.Property<decimal?>("TranTranFeeReq")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_tran_fee_req");

                    b.Property<decimal?>("TranTranFeeRsp")
                        .HasColumnType("numeric(16,0)")
                        .HasColumnName("tran_tran_fee_rsp");

                    b.Property<string>("TranType")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("tran_type")
                        .IsFixedLength();

                    b.Property<string>("UcafData")
                        .HasMaxLength(33)
                        .IsUnicode(false)
                        .HasColumnType("varchar(33)")
                        .HasColumnName("ucaf_data");

                    b.ToTable("post_tran", (string)null);
                });

            modelBuilder.Entity("Bogus_MVC_.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}