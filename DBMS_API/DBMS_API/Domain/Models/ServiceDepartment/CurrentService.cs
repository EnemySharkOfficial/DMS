using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("CurrentService")]
    public partial class CurrentService : BaseEntity
    {

        [Column("way_of_implementation")]
        public string WayOfImplementation { get; set; } = null!;
        [Column("description")]
        public string Description { get; set; } = null!;
        [Column("id_service")]
        public int IdService { get; set; }
        [Column("id_car")]
        public int IdCar { get; set; }

        public virtual ServiceCar IdCarNavigation { get; set; } = null!;
        public virtual Service IdServiceNavigation { get; set; } = null!;
    }
}
