using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Handlers
{
    public class DeleteServiceManagerStoryHandler : IRequestHandler<DeleteServiceManagerStoryContext, bool>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public DeleteServiceManagerStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteServiceManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<ServiceManager>(request.Id);
            return deleted;
        }
    }
}
