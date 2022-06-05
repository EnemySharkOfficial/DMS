using MediatR;

namespace DBMS_API.Stories.MarketingStories.ManagerStories.Contexts
{
    public class UpdateManagerStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Fio { get; set; }
        public string? Phonenumber { get; set; }
        public string? Email { get; set; }
        public string? Passportdata { get; set; }
        public string? Post { get; set; }
        public string? Requisites { get; set; }
    }
}
