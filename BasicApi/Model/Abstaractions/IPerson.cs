namespace BasicApi.Model.Abstaractions
{
    public interface IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalIdentityNumber { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? PhotoFileName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}
