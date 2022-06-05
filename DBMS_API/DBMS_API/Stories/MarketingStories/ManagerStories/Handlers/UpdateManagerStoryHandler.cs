using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Handlers
{
    public class UpdateManagerStoryHandler : IRequestHandler<UpdateManagerStoryContext, bool>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public UpdateManagerStoryHandler(IRepository<MarketingDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Manager());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
