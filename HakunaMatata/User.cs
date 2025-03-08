using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HakunaMatata.Models
{
    [Table("Subscribers_mtbl", Schema = "dbo")]
    public class User
    {
        public int CustCode { get; set; } // Assuming Id is the primary key
        public string CustQRCode { get; set; }
        public string CustFName { get; set; }
        public string CustLName { get; set; }
        public string CustPassword { get; set; }
        public string CustNationality { get; set; }
        public string CustInternationalCode { get; set; }
        public string CustMobileNo { get; set; }
        public string CustEmail { get; set; }
        public string CustGender { get; set; }
        public DateTime CustBirthDate { get; set; }
        public string CustAlergy { get; set; }
        public int CustCounter { get; set; }
        public bool CustDeleted { get; set; }
    }
}
