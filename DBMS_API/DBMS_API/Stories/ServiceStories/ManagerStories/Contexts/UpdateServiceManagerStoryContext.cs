using MediatR;

namespace DBMS_API.Stories.ServiceStories.ManagerStories.Contexts
{
    public class UpdateServiceManagerStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Fio { get; set; }

        public string? Mail { get; set; }
        public string? PassportData { get; set; }
    }
}
