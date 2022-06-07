using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Handlers
{
    public class AddServiceClientStoryHandler : IRequestHandler<AddServiceClientStoryContext, int>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public AddServiceClientStoryHandler(IRepository<ServiceDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddServiceClientStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = _mapper.Map(request, new ServiceClient());

            return await _repository.InsertAsync(item);
        }
    }
}
