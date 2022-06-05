using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Handlers
{
    public class ShowAllManagerStoryHandler : IRequestHandler<ShowAllManagerStoryContext, List<Manager>>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public ShowAllManagerStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<Manager>> Handle(ShowAllManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<Manager>();

            return item.ToList();
        }
    }
}
