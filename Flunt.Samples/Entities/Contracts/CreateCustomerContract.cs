using Gatekeeper.Samples.Entities;
using Gatekeeper.Validations;

namespace Gatekeeper.Samples.Entities.Contracts
{
    public class CreateCustomerContract : Contract<Customer>
    {
        public CreateCustomerContract(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.Name, "Name", "Custom error message");
        }
    }
}
