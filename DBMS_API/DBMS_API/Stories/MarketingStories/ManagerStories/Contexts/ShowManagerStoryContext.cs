using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Contexts
{
    public class ShowManagerStoryContext : IRequest<Manager>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
