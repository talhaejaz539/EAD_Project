using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "BloodRequest",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        RequiredBloodGroup = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        HospitalName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        RequestorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        RequestorRollNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        RequestorPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Case = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        AttendantName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        AttendantPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        TimeAndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        PickAndDrop = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        DonorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        DonorContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__BloodReq__3214EC07AD11FD9B", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Donor",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        RollNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PhoneNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        BloodGroup = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        TemporaryAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        PermanentAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        LastDonationDate = table.Column<DateTime>(type: "date", nullable: false),
            //        Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Donor__3214EC074E2B53BF", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Member",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        RollNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Designation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        ListGroup = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Member__3214EC0755BBA30D", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "BloodRequest");

            //migrationBuilder.DropTable(
            //    name: "Donor");

            //migrationBuilder.DropTable(
            //    name: "Member");
        }
    }
}
