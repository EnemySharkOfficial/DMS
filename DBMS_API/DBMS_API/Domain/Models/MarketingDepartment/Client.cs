using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("clients")]
    public partial class Client : BaseEntity
    {
        [Column("fio")]
        public string? Fio { get; set; }
        [Column("phonenumber")]
        public string? Phonenumber { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("passportdata")]
        public string? Passportdata { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }
        [Column("requisites")]
        public string? Requisites { get; set; }

        public virtual Manager? Manager { get; set; }
    }
}
