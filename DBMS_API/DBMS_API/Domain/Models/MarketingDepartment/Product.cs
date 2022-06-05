using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("products")]
    public partial class Product : BaseEntity
    {
        public Product()
        {
            ProductsTosolds = new HashSet<ProductsToSold>();
            Soldproducts = new HashSet<Soldproduct>();
        }

        [Column("type")]
        public string? Type { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("price")]
        public double? Price { get; set; }

        public virtual ICollection<ProductsToSold> ProductsTosolds { get; set; }
        public virtual ICollection<Soldproduct> Soldproducts { get; set; }
    }
}
