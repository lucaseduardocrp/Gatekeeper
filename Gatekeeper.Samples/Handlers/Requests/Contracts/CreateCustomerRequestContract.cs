﻿using Gatekeeper.Validations;

namespace Gatekeeper.Samples.Handlers.Requests.Contracts
{
    public class CreateCustomerRequestContract : Contract<CreateCustomerRequest>
    {
        public CreateCustomerRequestContract(CreateCustomerRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Name, "Name", "Custom error message")
                .IsEmail(request.Email, "Email");
        }
    }
}
