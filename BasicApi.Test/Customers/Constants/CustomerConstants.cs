using System;

namespace BasicApi.Test.Customers.Constants
{
    public static class CustomerConstants
    {
        public static readonly Guid SomeCustomerId = new Guid("7d7905b4-379e-46e8-8ee9-42ed334bc6c2");
        public const string SomeFirstName = "SomeFirstName";
        public const string SomeLastName = "SomeLastName";
        public const string SomeNationalIdentityNumber = "SomeNationalIdentityNumber";
        public const string SomeEmail = "SomeEmail@SomeHost.com";
        public const string SomeMobileNumber = "SomeMobileNumber";
        public const string SomePhotoFileName = "SomePhotoFileName";
        public static DateTime SomeBirthDate = new DateTime(1985,7,18);
    }
}
