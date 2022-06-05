using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.CarClassStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories.Handlers
{
    public class DeleteCarClassStoryHandler : IRequestHandler<DeleteCarClassStoryContext, bool>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public DeleteCarClassStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteCarClassStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<CarClass>(request.Id);
            return deleted;
        }
    }
}
