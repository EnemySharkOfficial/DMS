using AutoMapper;
using DBMS_API.Domain.Models.Provider;
using DBMS_API.Repositories;
using DBMS_API.Stories.ProviderStories.Contexts;
using MediatR;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DBMS_API.Stories.ProviderStories.Handlers
{
    public class UpdateOrderStoryHandler : IRequestHandler<UpdateOrderStoryContext, bool>
    {
        private readonly IMongoRepository _repository;
        private readonly IMapper _mapper;
        public UpdateOrderStoryHandler(IMongoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateOrderStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Orders());
            var response = await _repository.UpdateAsync(new ObjectId(asteroid.Id), asteroid);

            return response;
        }
    }
}
