using DBMS_API.Domain.Models.ServiceDepartment;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Contexts
{
    public class ShowServiceManagerStoryContext : IRequest<ServiceManager>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
