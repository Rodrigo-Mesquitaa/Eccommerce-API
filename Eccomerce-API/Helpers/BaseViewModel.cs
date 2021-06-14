using System;

namespace Eccomerce_API.Helpers
{
    public class BaseViewModel
    {
        public virtual Int64 Id { get; set; }
        public DateTime AddeadDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
