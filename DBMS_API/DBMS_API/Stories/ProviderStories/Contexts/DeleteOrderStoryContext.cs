using MediatR;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ProviderStories.Contexts
{
    public class DeleteOrderStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]

        public string Id { get; set; }
    }
}
