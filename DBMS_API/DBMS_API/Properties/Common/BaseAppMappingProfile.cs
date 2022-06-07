using AutoMapper;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Domain.Models.Provider;
using DBMS_API.Domain.Models.ServiceDepartment;

namespace DBMS_API.Properties.Common
{
    public class BaseAppMappingProfile : Profile
    {
        public BaseAppMappingProfile()
        {
            CreateMap<CarClass, CarClass>();
            CreateMap<Manager, Manager>();

            CreateMap<ServiceManager, ServiceManager>();
            CreateMap<ServiceClient, ServiceClient>();

            CreateMap<Orders, Orders>();
        }
    }
}