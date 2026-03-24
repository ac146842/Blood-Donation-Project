using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blood_Donation_Project.Migrations
{
    /// <inheritdoc />
    public partial class BloodDonationProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Appointment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donor_ID = table.Column<int>(type: "int", nullable: false),
                    AppointmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Appointment_ID);
                });

            migrationBuilder.CreateTable(
                name: "BloodTypeTable",
                columns: table => new
                {
                    BloodType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypeTable", x => x.BloodType_ID);
                });

            migrationBuilder.CreateTable(
                name: "DonatedBlood",
                columns: table => new
                {
                    Donation_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donor_ID = table.Column<int>(type: "int", nullable: false),
                    Nurse_ID = table.Column<int>(type: "int", nullable: false),
                    Appointment_ID = table.Column<int>(type: "int", nullable: false),
                    DonationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonatedBlood", x => x.Donation_ID);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    Donor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodType_ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.Donor_ID);
                });

            migrationBuilder.CreateTable(
                name: "FormAnswers",
                columns: table => new
                {
                    Answers_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Form_ID = table.Column<int>(type: "int", nullable: false),
                    HealthQ_ID = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAnswers", x => x.Answers_ID);
                });

            migrationBuilder.CreateTable(
                name: "FormQuestions",
                columns: table => new
                {
                    HealthQ_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormQuestions", x => x.HealthQ_ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    BloodBank_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donation_ID = table.Column<int>(type: "int", nullable: false),
                    BloodType_ID = table.Column<int>(type: "int", nullable: false),
                    VolumeML = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.BloodBank_ID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalForm",
                columns: table => new
                {
                    Form_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donor_ID = table.Column<int>(type: "int", nullable: false),
                    Nurse_ID = table.Column<int>(type: "int", nullable: false),
                    FormDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalForm", x => x.Form_ID);
                });

            migrationBuilder.CreateTable(
                name: "Nurse",
                columns: table => new
                {
                    Nurse_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.Nurse_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "BloodTypeTable");

            migrationBuilder.DropTable(
                name: "DonatedBlood");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "FormAnswers");

            migrationBuilder.DropTable(
                name: "FormQuestions");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "MedicalForm");

            migrationBuilder.DropTable(
                name: "Nurse");
        }
    }
}
