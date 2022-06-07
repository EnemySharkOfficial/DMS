using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Handlers
{
    public class UpdateServiceManagerStoryHandler : IRequestHandler<UpdateServiceManagerStoryContext, bool>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public UpdateServiceManagerStoryHandler(IRepository<ServiceDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateServiceManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new ServiceManager());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
