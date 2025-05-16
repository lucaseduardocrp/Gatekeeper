using Gatekeeper.Notifications;
using Gatekeeper.Samples.Entities;
using Gatekeeper.Samples.ValueObjects;
using Gatekeeper.Samples.Handlers.Requests;

namespace Gatekeeper.Samples.Handlers
{
    public class CustomerHandler : Notifiable<Notification>
    {
        public bool Handle(CreateCustomerRequest request)
        {
            if (request.IsValid == false)
            {
                AddNotifications(request.Notifications);
                return false;
            }

            var email = new Email(request.Email);
            var customer = new Customer(request.Name, email);

            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            return IsValid;

        }
    }
}
