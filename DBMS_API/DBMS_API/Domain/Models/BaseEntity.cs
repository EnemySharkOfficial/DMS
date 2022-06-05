using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models
{
    public abstract class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
