using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Handlers
{
    public class ShowAllServiceClientStoryHandler : IRequestHandler<ShowAllServiceClientStoryContext, List<ServiceClient>>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public ShowAllServiceClientStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<ServiceClient>> Handle(ShowAllServiceClientStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<ServiceClient>();

            return item.ToList();
        }
    }
}
