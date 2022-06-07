using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ClientStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Handlers
{
    public class UpdateServiceClientStoryHandler : IRequestHandler<UpdateServiceClientStoryContext, bool>
    {
        private readonly IRepository<ServiceDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public UpdateServiceClientStoryHandler(IRepository<ServiceDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateServiceClientStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new ServiceClient());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
