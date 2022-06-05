using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.MarketingDepartment
{
    [Table("productstosold")]
    public partial class ProductsToSold : BaseEntity
    {
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("numberOfProducts")]
        public int NumberOfProducts { get; set; }

        public virtual Soldproduct Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
