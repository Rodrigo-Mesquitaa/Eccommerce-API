using Eccomerce_API.Helpers;

namespace Eccomerce_API.Models
{
    public class CustomerModel : BaseModel
    {
        public override long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public bool is_married { get; set; }
        public string Address { get; set; }
    }
}
