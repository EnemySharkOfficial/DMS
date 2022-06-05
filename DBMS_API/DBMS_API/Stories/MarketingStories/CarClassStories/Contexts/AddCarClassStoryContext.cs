using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories
{
    public class AddCarClassStoryContext : IRequest<int>
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public string? Characteristics { get; set; }
    }
}
