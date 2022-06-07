using MediatR;

namespace DBMS_API.Stories.ServiceStories.ClientStories.Contexts
{
    public class UpdateServiceClientStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Fio { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Mail { get; set; }
        public string? PassportData { get; set; }
    }
}
