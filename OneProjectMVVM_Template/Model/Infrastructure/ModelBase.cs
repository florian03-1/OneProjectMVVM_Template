using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProjectMVVM_Template.Model.Infrastructure
{
    public abstract class ModelBase
    {
        public Guid ID { get; set; }
        public string Comment { get; set; } = "";

        public string CreatedBy { get; set; } = "";
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;

        public string LastModifiedBy { get; set; } = "";
        public DateTime LastModifiedTimestamp { get; set; } = DateTime.Now;
    }
}
