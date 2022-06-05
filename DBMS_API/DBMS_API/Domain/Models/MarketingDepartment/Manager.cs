using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("managers")]
    public partial class Manager : BaseEntity
    {
        public Manager()
        {
            Cars = new HashSet<Car>();
            Clients = new HashSet<Client>();
            Soldproducts = new HashSet<Soldproduct>();
        }

        [Column("fio")]
        public string? Fio { get; set; }
        [Column("phonenumber")]
        public string? Phonenumber { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("passportdata")]
        public string? Passportdata { get; set; }
        [Column("post")]
        public string? Post { get; set; }
        [Column("requisites")]
        public string? Requisites { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Soldproduct> Soldproducts { get; set; }
    }
}
