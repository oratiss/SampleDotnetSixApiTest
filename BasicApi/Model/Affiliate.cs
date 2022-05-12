using BasicApi.Model.Abstaractions;

namespace BasicApi.Model
{
    public class Affiliate : Entity<Guid>, IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalIdentityNumber { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? PhotoFileName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}
