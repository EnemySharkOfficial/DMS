using DBMS_API.Domain.Models.Provider;
using MediatR;

namespace DBMS_API.Stories.ProviderStories.Contexts
{
    public class ShowAllOrderStoryContext : IRequest<List<Orders>>
    {
    }
}
