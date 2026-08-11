using System;
using System.Collections.Generic;
using System.Text;

namespace SmartNotificationFactory.NotificationSystem
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Notification type cannot be null or empty.");
            }

            return type.ToUpper().Trim() switch
            {
                "EMAIL" => new EmailNotification(),
                "SMS" => new SMSNotification(),
                "PUSH" => new PushNotification(),
                "WHATSAPP" => new WhatsAppNotification(),
                "TELEGRAM" => new TelegramNotification(),
                _ => throw new ArgumentException($"Unknown notification type: {type}")
            };
        }
    }
}