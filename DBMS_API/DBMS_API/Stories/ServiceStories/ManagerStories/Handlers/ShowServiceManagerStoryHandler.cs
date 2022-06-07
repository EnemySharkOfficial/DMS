using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Handlers
{
    public class ShowServiceManagerStoryHandler : IRequestHandler<ShowServiceManagerStoryContext, ServiceManager>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public ShowServiceManagerStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceManager> Handle(ShowServiceManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<ServiceManager>(request.Id);

            return item;
        }
    }
}
