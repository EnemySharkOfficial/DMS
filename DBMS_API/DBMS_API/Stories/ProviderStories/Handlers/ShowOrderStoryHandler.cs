using DBMS_API.Domain.Models.Provider;
using DBMS_API.Repositories;
using DBMS_API.Stories.ProviderStories.Contexts;
using MediatR;
using MongoDB.Bson;

namespace DBMS_API.Stories.ProviderStories.Handlers
{
    public class ShowOrderStoryHandler : IRequestHandler<ShowOrderStoryContext, Orders>
    {
        private readonly IMongoRepository _repository;

        public ShowOrderStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Orders> Handle(ShowOrderStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync(new ObjectId(request.Id));
            return item;
        }
    }
}
