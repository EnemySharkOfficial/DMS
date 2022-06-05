using DBMS_API.Domain.Models.MarketingDepartment;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.MarketingStories.CarClassStories
{
    public class ShowCarClassStoryContext : IRequest<CarClass>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
