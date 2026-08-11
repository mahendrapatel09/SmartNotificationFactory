using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            // Implementation for sending email notification
            Console.WriteLine($"[EMAIL] Email Notification Sent: {message}");
        }
    }
}
