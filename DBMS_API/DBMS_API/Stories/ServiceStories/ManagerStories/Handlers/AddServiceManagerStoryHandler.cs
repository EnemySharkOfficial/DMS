using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Handlers
{
    public class AddServiceManagerStoryHandler : IRequestHandler<AddServiceManagerStoryContext, int>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public AddServiceManagerStoryHandler(IRepository<ServiceDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddServiceManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = _mapper.Map(request, new ServiceManager());

            return await _repository.InsertAsync(item);
        }
    }
}
