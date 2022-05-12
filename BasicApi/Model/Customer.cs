using BasicApi.Model.Abstaractions;

namespace BasicApi.Model
{
    public class Customer : Entity<Guid> , IPerson
    {
        public Customer()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            };
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalIdentityNumber { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? PhotoFileName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
       
        public Guid? AffiliateId { get; set; }
        public Affiliate? Affiliate { get; set; }
    }
}
