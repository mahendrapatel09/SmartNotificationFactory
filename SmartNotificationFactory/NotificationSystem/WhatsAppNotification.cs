using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public class WhatsAppNotification : INotification
    {
        public void Send(string message)
        {
            // Implementation for sending WhatsApp notification
            Console.WriteLine($"[WHATSAPP] WhatsApp Notification Sent: {message}");
        }
    }
}
