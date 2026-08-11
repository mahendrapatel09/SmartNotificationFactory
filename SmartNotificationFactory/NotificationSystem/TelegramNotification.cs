using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public class TelegramNotification : INotification
    {
        public void Send(string message)
        {
            // Implementation for sending Telegram notification
            Console.WriteLine($"[TELEGRAM] Telegram Notification Sent: {message}");
        }
    }
}
