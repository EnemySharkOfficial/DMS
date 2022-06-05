using AutoMapper;
using DBMS_API.Domain.Models.MarketingDepartment;

namespace DBMS_API.Properties.Common
{
    public class BaseAppMappingProfile : Profile
    {
        public BaseAppMappingProfile()
        {
            CreateMap<CarClass, CarClass>();
            CreateMap<Manager, Manager>();
        }
    }
}
