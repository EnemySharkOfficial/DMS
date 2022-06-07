using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("Master")]
    public partial class Master : BaseEntity
    {
        public Master()
        {
            Cars = new HashSet<ServiceCar>();
        }

        [Column("fio")]
        public string Fio { get; set; } = null!;
        [Column("mail")]
        public string Mail { get; set; } = null!;
        [Column("passport_data")]
        public string PassportData { get; set; } = null!;
        [Column("post")]
        public string Post { get; set; } = null!;
        [Column("id_manager")]
        public int IdManager { get; set; }

        public virtual ServiceManager IdManagerNavigation { get; set; } = null!;
        public virtual ICollection<ServiceCar> Cars { get; set; }
    }
}
