using DBMS_API.Domain.Models.Provider;
using MediatR;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ProviderStories.Contexts
{
    public class ShowOrderStoryContext : IRequest<Orders>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public string Id { get; set; }
    }
}
