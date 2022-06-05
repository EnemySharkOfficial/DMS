using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("contracts")]
    public partial class Contract : BaseEntity
    {
        [Column("companyinformation")]
        public string? Companyinformation { get; set; }
        [Column("companyrequisites")]
        public string? Companyrequisites { get; set; }
        [Column("clientrequisites")]
        public string? Clientrequisites { get; set; }
        [Column("price")]
        public double? Price { get; set; }
        [Column("date")]
        public DateOnly? Date { get; set; }
        [Column("car_id")]
        public int? CarId { get; set; }
        [Column("client_id")]
        public int? ClientId { get; set; }
    }
}
