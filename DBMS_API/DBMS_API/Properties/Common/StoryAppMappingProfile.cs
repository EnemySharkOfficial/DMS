using AutoMapper;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.CarClassStories;
using DBMS_API.Stories.MarketingStories.CarClassStories.Contexts;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;

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
        }
    }
}
