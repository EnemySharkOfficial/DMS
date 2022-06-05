using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;

namespace DBMS_API.Stories.MarketingStories.CarClassStories
{
    public class ShowAllCarClassStoryHandler : IRequestHandler<ShowAllCarClassStoryContext, List<CarClass>>
    {
        private readonly IRepository<MarketingDepartmentContext> _repository;

        public ShowAllCarClassStoryHandler(IRepository<MarketingDepartmentContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<CarClass>> Handle(ShowAllCarClassStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<CarClass>();

            return item.ToList();
        }
    }
}
