using Gatekeeper.Notifications;
using Gatekeeper.Samples.ValueObjects.Contracts;

namespace Gatekeeper.Samples.ValueObjects
{
    public class Email : Notifiable<Notification>
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new CreateEmailContract(this));
        }

        public string Address { get; private set; }
    }
}
