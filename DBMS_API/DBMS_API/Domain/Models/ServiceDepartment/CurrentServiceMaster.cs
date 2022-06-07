using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMS_API.Domain.Models.ServiceDepartment
{
    [Table("CurrentServiceMaster")]
    public partial class CurrentServiceMaster : BaseEntity
    {
        [Column("id_current_servise")]
        public int IdCurrentServise { get; set; }
        [Column("id_master")]
        public int IdMaster { get; set; }
        [Column("description")]
        public string Description { get; set; } = null!;

        public virtual CurrentService IdCurrentServiseNavigation { get; set; } = null!;
        public virtual Master IdMasterNavigation { get; set; } = null!;
    }
}
