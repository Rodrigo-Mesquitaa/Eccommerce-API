using System;

namespace Eccomerce_API.Helpers
{
    public abstract class BaseModel
    {
        public virtual Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
