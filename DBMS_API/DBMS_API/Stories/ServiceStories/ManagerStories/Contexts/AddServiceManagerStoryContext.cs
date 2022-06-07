using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Contexts
{
    public class AddServiceManagerStoryContext : IRequest<int>
    {
        public string? Fio { get; set; }
       
        public string? Mail { get; set; }
        public string? PassportData { get; set; }

    }
}
