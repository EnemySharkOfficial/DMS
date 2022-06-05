using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Contexts
{
    public class ShowAllManagerStoryContext : IRequest<List<Manager>>
    {

    }
}
