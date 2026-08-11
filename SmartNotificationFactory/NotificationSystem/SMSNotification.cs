using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            // Implementation for sending SMS notification
            Console.WriteLine($"[SMS] SMS Notification Sent: {message}");
        }
    }
}
