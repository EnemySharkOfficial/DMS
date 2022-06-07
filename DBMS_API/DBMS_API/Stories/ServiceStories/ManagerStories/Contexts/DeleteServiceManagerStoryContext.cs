using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Contexts
{
    public class DeleteServiceManagerStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
