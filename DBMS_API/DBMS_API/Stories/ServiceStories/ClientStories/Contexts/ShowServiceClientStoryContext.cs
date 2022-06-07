using DBMS_API.Domain.Models.ServiceDepartment;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Contexts
{
    public class ShowServiceClientStoryContext : IRequest<ServiceClient>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }
    }
}
