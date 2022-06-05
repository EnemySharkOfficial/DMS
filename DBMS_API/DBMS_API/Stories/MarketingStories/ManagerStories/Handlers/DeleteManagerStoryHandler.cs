using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Handlers
{
    public class DeleteManagerStoryHandler : IRequestHandler<DeleteManagerStoryContext, bool>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public DeleteManagerStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<Manager>(request.Id);
            return deleted;
        }
    }
}
