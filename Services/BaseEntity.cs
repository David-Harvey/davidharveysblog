
using System;
using System.ComponentModel.DataAnnotations;

namespace davidharveysblog.Services
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
