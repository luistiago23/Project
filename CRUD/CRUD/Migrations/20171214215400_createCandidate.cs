using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace CRUD.Migrations
{
    public partial class createCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<int>(nullable: false),
                    Afternoon = table.Column<bool>(nullable: false),
                    Agency = table.Column<int>(nullable: false),
                    Android = table.Column<int>(nullable: false),
                    AngularJs = table.Column<int>(nullable: false),
                    AspNet = table.Column<int>(nullable: false),
                    Bank = table.Column<string>(nullable: true),
                    BankInformation = table.Column<string>(nullable: true),
                    Bootstrap = table.Column<int>(nullable: false),
                    Business = table.Column<bool>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CPlusPlus = table.Column<int>(nullable: false),
                    Cake = table.Column<int>(nullable: false),
                    Chain = table.Column<bool>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Cpf = table.Column<int>(nullable: false),
                    Css = table.Column<int>(nullable: false),
                    DJango = table.Column<int>(nullable: false),
                    Dawn = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FourToSix = table.Column<bool>(nullable: false),
                    Html = table.Column<int>(nullable: false),
                    Illustrator = table.Column<int>(nullable: false),
                    Ionic = table.Column<int>(nullable: false),
                    Ios = table.Column<int>(nullable: false),
                    Jquery = table.Column<int>(nullable: false),
                    LinkCrud = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Majento = table.Column<int>(nullable: false),
                    Morning = table.Column<bool>(nullable: false),
                    MySql = table.Column<int>(nullable: false),
                    MySqlServer = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NameInBank = table.Column<string>(nullable: true),
                    Night = table.Column<bool>(nullable: false),
                    OnlyWeekends = table.Column<bool>(nullable: false),
                    OtherTechnology = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Photoshop = table.Column<int>(nullable: false),
                    Php = table.Column<int>(nullable: false),
                    Phyton = table.Column<int>(nullable: false),
                    Portfolio = table.Column<string>(nullable: true),
                    Ruby = table.Column<int>(nullable: false),
                    SalaryRequirement = table.Column<string>(nullable: true),
                    SalesForce = table.Column<int>(nullable: false),
                    Savings = table.Column<bool>(nullable: false),
                    Seo = table.Column<int>(nullable: false),
                    SixToEight = table.Column<bool>(nullable: false),
                    Skype = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    UpToEight = table.Column<bool>(nullable: false),
                    UpToFourHours = table.Column<bool>(nullable: false),
                    Wordpress = table.Column<int>(nullable: false),
                    java = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Candidate");
        }
    }
}
