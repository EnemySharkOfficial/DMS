using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Handlers
{
    public class DeleteServiceClientStoryHandler : IRequestHandler<DeleteServiceClientStoryContext, bool>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public DeleteServiceClientStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteServiceClientStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<ServiceClient>(request.Id);
            return deleted;
        }
    }
}
