using DBMS_API.Domain.Models.Provider;
using DBMS_API.Repositories;
using DBMS_API.Stories.ProviderStories.Contexts;
using MediatR;
using MongoDB.Driver;

namespace DBMS_API.Stories.ProviderStories.Handlers
{
    public class ShowAllOrderStoryHandler : IRequestHandler<ShowAllOrderStoryContext, List<Orders>>
    {
        //private readonly ILibraryRepository _repository;
        private readonly IMongoRepository _repository;

        public ShowAllOrderStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<Orders>> Handle(ShowAllOrderStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync();

            return item.ToList();
        }
    }
}
