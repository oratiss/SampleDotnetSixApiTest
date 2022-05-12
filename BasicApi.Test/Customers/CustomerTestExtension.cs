using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicApi.Model;
using BasicApi.Test.Customers.Constants;

namespace BasicApi.Test.Customers
{
    public static class CustomerTestExtension
    {
        public static Customer CreateSomeCustomer(this CustomerTest customerTest)
        {
            var customer = new Customer()
            {
                Id = CustomerConstants.SomeCustomerId,
                FirstName = CustomerConstants.SomeFirstName,
                LastName = CustomerConstants.SomeLastName,
                NationalIdentityNumber = CustomerConstants.SomeNationalIdentityNumber,
                Email = CustomerConstants.SomeEmail,
                MobileNumber = CustomerConstants.SomeMobileNumber,
                PhotoFileName = CustomerConstants.SomePhotoFileName,
                BirthDate = CustomerConstants.SomeBirthDate
            };

            return customer;
        }

    }
}
