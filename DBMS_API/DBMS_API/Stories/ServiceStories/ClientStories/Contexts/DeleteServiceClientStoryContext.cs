using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Contexts
{
    public class DeleteServiceClientStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
