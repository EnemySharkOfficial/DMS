using AutoMapper;
using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.Provider;
using DBMS_API.Repositories;
using DBMS_API.Stories.ProviderStories.Contexts;
using MediatR;

namespace DBMS_API.Stories.ProviderStories.Handlers
{
    public class AddOrderStoryHandler : IRequestHandler<AddOrderStoryContext, string>
    {
        private readonly IMongoRepository _repository;
        private readonly IMapper _mapper;

        public AddOrderStoryHandler(IMongoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<string> Handle(AddOrderStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Orders());

            return await _repository.InsertAsync(asteroid);
        }
    }
}