using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Handlers
{
    public class ShowServiceClientStoryHandler : IRequestHandler<ShowServiceClientStoryContext, ServiceClient>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public ShowServiceClientStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceClient> Handle(ShowServiceClientStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<ServiceClient>(request.Id);

            return item;
        }
    }
}
