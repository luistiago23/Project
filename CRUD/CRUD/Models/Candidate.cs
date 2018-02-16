using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Candidate
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Skype { get; set; }
        public int Phone { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Portfolio { get; set; }
        public bool UpToFourHours { get; set; }
        public bool FourToSix { get; set; }
        public bool SixToEight { get; set; }
        public bool UpToEight { get; set; }
        public bool OnlyWeekends { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Night { get; set; }
        public bool Dawn { get; set; }
        public bool Business { get; set; }
        public string SalaryRequirement { get; set; }
        public string BankInformation { get; set; }
        public string NameInBank { get; set; }
        public int Cpf { get; set; }
        public string Bank { get; set; }
        public int Agency { get; set; }
        public bool Chain { get; set; }
        public bool Savings { get; set; }
        public int AccountNumber { get; set; }
        /****Conhecimentos*****/
        public int Ionic { get; set; }
        public int Android { get; set; }
        public int Ios { get; set; }
        public int Html { get; set; }
        public int Css { get; set; }
        public int Bootstrap { get; set; }
        public int Jquery { get; set; }
        public int AngularJs { get; set; }
        public int java { get; set; }
        public int AspNet { get; set; }
        public int C { get; set; }
        public int CPlusPlus { get; set; }
        public int Cake { get; set; }
        public int DJango { get; set; }
        public int Majento { get; set; }
        public int Php { get; set; }
        public int Wordpress { get; set; }
        public int Phyton { get; set; }
        public int Ruby { get; set; }
        public int MySqlServer { get; set; }
        public int MySql { get; set; }
        public int SalesForce { get; set; }
        public int Photoshop { get; set; }
        public int Illustrator { get; set; }
        public int Seo { get; set; }
        public string OtherTechnology { get; set; }
        public string LinkCrud { get; set; }
    }
}