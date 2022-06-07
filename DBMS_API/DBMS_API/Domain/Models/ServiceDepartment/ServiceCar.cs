using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("ServiceCar")]
    public partial class ServiceCar : BaseEntity
    {
        public ServiceCar()
        {
            CurrentServices = new HashSet<CurrentService>();
        }

        [Column("brand")]
        public string Brand { get; set; } = null!;
        [Column("model")]
        public string Model { get; set; } = null!;
        [Column("year")]
        public DateTime Year { get; set; }
        [Column("equipment")]
        public string Equipment { get; set; } = null!;
        [Column("price")]
        public int Price { get; set; }
        [Column("image")]
        public string Image { get; set; } = null!;
        [Column("description")]
        public string Description { get; set; } = null!;
        [Column("characteristics")]
        public string Characteristics { get; set; } = null!;
        [Column("id_client")]
        public int IdClient { get; set; }
        [Column("id_master")]
        public int IdMaster { get; set; }

        public virtual ServiceClient IdClientNavigation { get; set; } = null!;
        public virtual Master IdMasterNavigation { get; set; } = null!;
        public virtual ICollection<CurrentService> CurrentServices { get; set; }
    }
}
