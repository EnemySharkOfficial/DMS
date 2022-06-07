using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("ServiceClient")]
    public partial class ServiceClient : BaseEntity
    {
        public ServiceClient()
        {
            Cars = new HashSet<ServiceCar>();
        }

        [Column("fio")]
        public string Fio { get; set; } = null!;
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = null!;
        [Column("mail")]
        public string Mail { get; set; } = null!;
        [Column("passport_data")]
        public string PassportData { get; set; } = null!;

        public virtual ICollection<ServiceCar> Cars { get; set; }
    }
}
