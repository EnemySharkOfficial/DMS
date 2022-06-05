using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.CarClassStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories.Handlers
{
    public class UpdateCarClassStoryHandler : IRequestHandler<UpdateCarClassStoryContext, bool>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public UpdateCarClassStoryHandler(IRepository<MarketingDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateCarClassStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new CarClass());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
