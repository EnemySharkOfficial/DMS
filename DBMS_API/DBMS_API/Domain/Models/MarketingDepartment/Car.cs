using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("cars")]
    public partial class Car : BaseEntity
    {
        [Column("booking")]
        public bool? Booking { get; set; }
        [Column("placement")]
        public string? Placement { get; set; }
        [Column("specialoffer")]
        public string? Specialoffer { get; set; }
        [Column("price")]
        public double? Price { get; set; }
        [Column("additional")]
        public string? Additional { get; set; }
        [Column("releasedate")]
        public DateOnly? Releasedate { get; set; }
        [Column("equipment")]
        public string? Equipment { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }

        public virtual Manager? Manager { get; set; }
        public virtual CarClass? Parent { get; set; }
    }
}
