using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("ServiceManager")]
    public partial class ServiceManager : BaseEntity
    {
        public ServiceManager()
        {
            Masters = new HashSet<Master>();
        }

        [Column("fio")]
        public string Fio { get; set; } = null!;
        [Column("mail")]
        public string Mail { get; set; } = null!;
        [Column("passport_data")]
        public string PassportData { get; set; } = null!;

        public virtual ICollection<Master> Masters { get; set; }
    }
}
