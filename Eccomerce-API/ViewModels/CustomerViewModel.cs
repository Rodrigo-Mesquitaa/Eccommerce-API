using Eccomerce_API.Helpers;

namespace Eccomerce_API.ViewModels
{
    public class CustomerViewModel:BaseViewModel
    {
        public override long Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public bool is_married { get; set; }
        public string address { get; set; }
    }
}
