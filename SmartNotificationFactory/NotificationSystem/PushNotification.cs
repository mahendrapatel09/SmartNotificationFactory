using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            // Implementation for sending push notification
            Console.WriteLine($"[PUSH] Push Notification Sent: {message}");
        }
    }
}
