using DBMS_API.Domain.Models.Provider;
using DBMS_API.Repositories;
using DBMS_API.Stories.ProviderStories.Contexts;
using MediatR;
using MongoDB.Bson;

namespace DBMS_API.Stories.ProviderStories.Handlers
{
    public class DeleteOrderStoryHandler : IRequestHandler<DeleteOrderStoryContext, bool>
    {
        private readonly IMongoRepository _repository;

        public DeleteOrderStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteOrderStoryContext request,
            CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(new ObjectId(request.Id));
            return true;
        }
    }
}
