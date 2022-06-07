using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("Service")]
    public partial class Service : BaseEntity
    {
        public Service()
        {
            CurrentServices = new HashSet<CurrentService>();
        }

        [Column("service_type")]
        public string ServiceType { get; set; } = null!;
        [Column("prise")]
        public int Prise { get; set; }
        [Column("description")]
        public string Description { get; set; } = null!;

        public virtual ICollection<CurrentService> CurrentServices { get; set; }
    }
}
