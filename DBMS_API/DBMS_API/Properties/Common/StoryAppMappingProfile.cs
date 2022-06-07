using AutoMapper;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Domain.Models.Provider;
using DBMS_API.Stories.MarketingStories.CarClassStories;
using DBMS_API.Stories.MarketingStories.CarClassStories.Contexts;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using DBMS_API.Stories.ProviderStories.Contexts;

namespace DBMS_API.Properties.Common
{
    public class StoryAppMappingProfile : Profile
    {
        public StoryAppMappingProfile()
        {
            CreateMap<AddCarClassStoryContext, CarClass>();
            CreateMap<UpdateCarClassStoryContext, CarClass>();

            CreateMap<AddManagerStoryContext, Manager>();
            CreateMap<UpdateManagerStoryContext, Manager>();

            CreateMap<AddServiceManagerStoryContext, ServiceManager>();
            CreateMap<UpdateServiceManagerStoryContext, ServiceManager>();

            CreateMap<AddServiceClientStoryContext, ServiceClient>();
            CreateMap<UpdateServiceClientStoryContext, ServiceClient>();

            CreateMap<AddOrderStoryContext, Orders>();
            CreateMap<UpdateOrderStoryContext, Orders>();
        }
    }
}
