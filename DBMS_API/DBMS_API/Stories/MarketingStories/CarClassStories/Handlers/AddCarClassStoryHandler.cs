using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories
{
    public class AddCarClassStoryHandler : IRequestHandler<AddCarClassStoryContext, int>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public AddCarClassStoryHandler(IRepository<MarketingDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddCarClassStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = _mapper.Map(request, new CarClass());

            return await _repository.InsertAsync(item);
        }
    }
}
