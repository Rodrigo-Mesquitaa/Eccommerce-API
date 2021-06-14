using AutoMapper;
using Eccomerce_API.Models;
using Eccomerce_API.ViewModels;

namespace Eccomerce_API.AutomapperProfile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, CustomerViewModel>()
                .ReverseMap();
        }
    }
}
