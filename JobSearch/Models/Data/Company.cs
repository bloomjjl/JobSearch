using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSearch.Models.Data
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        [Column("CompanyType_Id")]
        public int CompanyTypeId { get; set; }
        public string CompanyUserName { get; set; }
        public string CompanyUserPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CompanyTypeId")]
        public virtual CompanyType CompanyType { get; set; }
    }
}