using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogus_MVC_.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
             name: "Users",
             columns: table => new
             {
                 Id = table.Column<int>(type: "int", nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_Users", x => x.Id);
             });

            migrationBuilder.CreateTable(
                name: "post_tran",
                columns: table => new
                {
                    post_tran_id = table.Column<long>(type: "bigint", nullable: true),
                    post_tran_cust_id = table.Column<long>(type: "bigint", nullable: true),
                    settle_entity_id = table.Column<int>(type: "int", nullable: true),
                    batch_nr = table.Column<int>(type: "int", nullable: true),
                    prev_post_tran_id = table.Column<long>(type: "bigint", nullable: true),
                    next_post_tran_id = table.Column<long>(type: "bigint", nullable: true),
                    sink_node_name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tran_postilion_originated = table.Column<decimal>(type: "numeric(1,0)", nullable: true),
                    tran_completed = table.Column<decimal>(type: "numeric(1,0)", nullable: true),
                    message_type = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    tran_type = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    tran_nr = table.Column<long>(type: "bigint", nullable: true),
                    system_trace_audit_nr = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true),
                    rsp_code_req = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    rsp_code_rsp = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    abort_rsp_code = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    auth_id_rsp = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    auth_type = table.Column<decimal>(type: "numeric(1,0)", nullable: true),
                    auth_reason = table.Column<decimal>(type: "numeric(1,0)", nullable: true),
                    retention_data = table.Column<string>(type: "varchar(999)", unicode: false, maxLength: 999, nullable: true),
                    acquiring_inst_id_code = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    message_reason_code = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    sponsor_bank = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: true),
                    retrieval_reference_nr = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true),
                    datetime_tran_gmt = table.Column<DateTime>(type: "datetime", nullable: true),
                    datetime_tran_local = table.Column<DateTime>(type: "datetime", nullable: true),
                    datetime_req = table.Column<DateTime>(type: "datetime", nullable: true),
                    datetime_rsp = table.Column<DateTime>(type: "datetime", nullable: true),
                    realtime_business_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    recon_business_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    from_account_type = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    to_account_type = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    from_account_id = table.Column<string>(type: "varchar(28)", unicode: false, maxLength: 28, nullable: true),
                    to_account_id = table.Column<string>(type: "varchar(28)", unicode: false, maxLength: 28, nullable: true),
                    tran_amount_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_amount_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_amount_impact = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_cash_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_cash_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_currency_code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    tran_tran_fee_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_tran_fee_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_tran_fee_currency_code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    tran_proc_fee_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_proc_fee_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    tran_proc_fee_currency_code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    settle_amount_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_amount_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_cash_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_cash_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_tran_fee_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_tran_fee_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_proc_fee_req = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_proc_fee_rsp = table.Column<decimal>(type: "numeric(16,0)", nullable: true),
                    settle_currency_code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    icc_data_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icc_data_rsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pos_entry_mode = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    pos_condition_code = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    additional_rsp_data = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    structured_data_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    structured_data_rsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tran_reversed = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    prev_tran_approved = table.Column<decimal>(type: "numeric(1,0)", nullable: true),
                    issuer_network_id = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    acquirer_network_id = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    extended_tran_type = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    ucaf_data = table.Column<string>(type: "varchar(33)", unicode: false, maxLength: 33, nullable: true),
                    from_account_type_qualifier = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    to_account_type_qualifier = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    bank_details = table.Column<string>(type: "varchar(31)", unicode: false, maxLength: 31, nullable: true),
                    payee = table.Column<string>(type: "char(25)", unicode: false, fixedLength: true, maxLength: 25, nullable: true),
                    card_verification_result = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    online_system_id = table.Column<int>(type: "int", nullable: true),
                    participant_id = table.Column<int>(type: "int", nullable: true),
                    opp_participant_id = table.Column<int>(type: "int", nullable: true),
                    receiving_inst_id_code = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    routing_type = table.Column<int>(type: "int", nullable: true),
                    pt_pos_operating_environment = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    pt_pos_card_input_mode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    pt_pos_cardholder_auth_method = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    pt_pos_pin_capture_ability = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    pt_pos_terminal_operator = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    source_node_key = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true),
                    proc_online_system_id = table.Column<int>(type: "int", nullable: true),
                    from_account_id_cs = table.Column<int>(type: "int", nullable: true),
                    to_account_id_cs = table.Column<int>(type: "int", nullable: true),
                    pos_geographic_data = table.Column<string>(type: "char(17)", unicode: false, fixedLength: true, maxLength: 17, nullable: true),
                    payer_account_id = table.Column<string>(type: "varchar(28)", unicode: false, maxLength: 28, nullable: true),
                    cvv_available_at_auth = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cvv2_available_at_auth = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    mapped_terminal_id = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: true),
                    mapped_extd_ca_term_id = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    mapped_extd_ca_id_code = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    network_program_id_actual = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    network_program_id_min = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    network_fee_actual = table.Column<decimal>(type: "numeric(16,4)", nullable: true),
                    network_fee_min = table.Column<decimal>(type: "numeric(16,4)", nullable: true),
                    network_fee_max = table.Column<decimal>(type: "numeric(16,4)", nullable: true),
                    credit_debit_conversion = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "post_tran");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
