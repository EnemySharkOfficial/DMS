using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.MarketingStories.CarClassStories.Contexts
{
    public class DeleteCarClassStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
