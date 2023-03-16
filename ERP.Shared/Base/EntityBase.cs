using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Shared.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
