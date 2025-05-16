using System.Collections.Generic;

namespace Gatekeeper.Notifications
{
    public interface INotifiable
    {
        void AddNotifications(IEnumerable<Notification> notifications);
    }
}
