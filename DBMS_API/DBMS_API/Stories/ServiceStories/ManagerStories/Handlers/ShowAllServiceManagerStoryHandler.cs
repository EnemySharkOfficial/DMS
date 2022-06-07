using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Handlers
{
    public class ShowAllServiceManagerStoryHandler : IRequestHandler<ShowAllServiceManagerStoryContext, List<ServiceManager>>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;

        public ShowAllServiceManagerStoryHandler(IRepository<ServiceDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<ServiceManager>> Handle(ShowAllServiceManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<ServiceManager>();

            return item.ToList();
        }
    }
}
