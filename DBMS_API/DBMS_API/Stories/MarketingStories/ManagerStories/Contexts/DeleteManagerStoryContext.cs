using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Contexts
{
    public class DeleteManagerStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
