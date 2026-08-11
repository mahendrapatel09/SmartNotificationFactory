using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public interface INotification
    {
        void Send(string message);
    }
}
