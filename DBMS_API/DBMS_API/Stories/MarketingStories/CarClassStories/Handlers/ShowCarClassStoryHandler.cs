using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories
{
    public class ShowCarClassStoryHandler : IRequestHandler<ShowCarClassStoryContext, CarClass>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public ShowCarClassStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<CarClass> Handle(ShowCarClassStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<CarClass>(request.Id);

            return item;
        }
    }
}
