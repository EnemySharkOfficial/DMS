using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Stories.MarketingStories.ManagerStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Handlers
{
    public class AddManagerStoryHandler : IRequestHandler<AddManagerStoryContext, int>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;
        private readonly IMapper _mapper;

        public AddManagerStoryHandler(IRepository<MarketingDepartmentContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddManagerStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = _mapper.Map(request, new Manager());

            return await _repository.InsertAsync(item);
        }
    }
}
