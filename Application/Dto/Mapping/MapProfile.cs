using AutoMapper;
using DomainModel.Entities;
using Dto.Request.Customer;
using Dto.Response.Customer;

namespace Dto.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CustomerAddRequest, Customer>();
            CreateMap<Customer, CustomerGetAllResponse>();
            CreateMap<Customer, CustomerGetByIdResponse>();
            CreateMap<CustomerUpdateRequest, Customer>();
        }
    }
}
