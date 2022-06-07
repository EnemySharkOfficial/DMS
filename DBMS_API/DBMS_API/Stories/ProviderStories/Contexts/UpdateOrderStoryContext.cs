using DBMS_API.Domain.Models.Provider;
using MediatR;

namespace DBMS_API.Stories.ProviderStories.Contexts
{
    public class UpdateOrderStoryContext : IRequest<bool>
    {
        public string Id { get; set; }

        public string ProviderName { get; set; }

        public string OrderDate { get; set; }

        public List<Cars>? CarsObj { get; set; }

        public List<SpareParts>? SparePartsObj { get; set; }

        public int? ManagerId { get; set; }
    }
}
