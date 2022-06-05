using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("carsclass")]
    public partial class CarClass : BaseEntity
    {
        public CarClass()
        {
            Cars = new HashSet<Car>();
        }

        [Column("brand")]
        public string? Brand { get; set; }
        [Column("model")]
        public string? Model { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("characteristics")]
        public string? Characteristics { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
