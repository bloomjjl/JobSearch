using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSearch.Models.Data
{
    [Table("tblCompanyType")]
    public class CompanyType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}