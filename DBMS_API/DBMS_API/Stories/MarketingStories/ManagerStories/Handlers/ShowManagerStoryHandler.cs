using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Handlers
{
    public class ShowManagerStoryHandler : IRequestHandler<ShowManagerStoryContext, Manager>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public ShowManagerStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Manager> Handle(ShowManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<Manager>(request.Id);

            return item;
        }
    }
}
