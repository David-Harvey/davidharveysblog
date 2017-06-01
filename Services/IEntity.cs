using System;

namespace davidharveysblog.Services
{
    public interface IEntity
    {
        Guid ID { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
    }
}