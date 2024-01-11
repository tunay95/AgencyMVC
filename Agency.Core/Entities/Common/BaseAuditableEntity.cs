using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Core.Entities.Common
{
    public class BaseAuditableEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
