using System;
using Gatekeeper.Samples.Entities;
using Gatekeeper.Validations;

namespace Gatekeeper.Samples.Entities.Contracts
{
    public class UpdateCustomerBirthDateContract : Contract<Customer>
    {
        public UpdateCustomerBirthDateContract(Customer customer)
        {
            Requires()
                .IsLowerThan(customer.BirthDate, DateTime.Now.AddYears(-18), "BirthDate");
        }
    }
}
