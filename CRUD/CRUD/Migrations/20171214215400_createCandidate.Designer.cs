using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CRUD;

namespace CRUD.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20171214215400_createCandidate")]
    partial class createCandidate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD.Models.Candidate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountNumber");

                    b.Property<bool>("Afternoon");

                    b.Property<int>("Agency");

                    b.Property<int>("Android");

                    b.Property<int>("AngularJs");

                    b.Property<int>("AspNet");

                    b.Property<string>("Bank");

                    b.Property<string>("BankInformation");

                    b.Property<int>("Bootstrap");

                    b.Property<bool>("Business");

                    b.Property<int>("C");

                    b.Property<int>("CPlusPlus");

                    b.Property<int>("Cake");

                    b.Property<bool>("Chain");

                    b.Property<string>("City");

                    b.Property<int>("Cpf");

                    b.Property<int>("Css");

                    b.Property<int>("DJango");

                    b.Property<bool>("Dawn");

                    b.Property<string>("Email");

                    b.Property<bool>("FourToSix");

                    b.Property<int>("Html");

                    b.Property<int>("Illustrator");

                    b.Property<int>("Ionic");

                    b.Property<int>("Ios");

                    b.Property<int>("Jquery");

                    b.Property<string>("LinkCrud");

                    b.Property<string>("Linkedin");

                    b.Property<int>("Majento");

                    b.Property<bool>("Morning");

                    b.Property<int>("MySql");

                    b.Property<int>("MySqlServer");

                    b.Property<string>("Name");

                    b.Property<string>("NameInBank");

                    b.Property<bool>("Night");

                    b.Property<bool>("OnlyWeekends");

                    b.Property<string>("OtherTechnology");

                    b.Property<int>("Phone");

                    b.Property<int>("Photoshop");

                    b.Property<int>("Php");

                    b.Property<int>("Phyton");

                    b.Property<string>("Portfolio");

                    b.Property<int>("Ruby");

                    b.Property<string>("SalaryRequirement");

                    b.Property<int>("SalesForce");

                    b.Property<bool>("Savings");

                    b.Property<int>("Seo");

                    b.Property<bool>("SixToEight");

                    b.Property<string>("Skype");

                    b.Property<string>("State");

                    b.Property<bool>("UpToEight");

                    b.Property<bool>("UpToFourHours");

                    b.Property<int>("Wordpress");

                    b.Property<int>("java");

                    b.HasKey("ID");
                });
        }
    }
}
