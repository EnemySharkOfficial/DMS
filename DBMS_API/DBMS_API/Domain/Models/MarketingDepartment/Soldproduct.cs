using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("soldproducts")]
    public partial class Soldproduct : BaseEntity
    {
        public Soldproduct()
        {
            ProductsTosolds = new HashSet<ProductsToSold>();
        }

        [Column("date")]
        public DateOnly? Date { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }

        public virtual Manager? Manager { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<ProductsToSold> ProductsTosolds { get; set; }
    }
}
