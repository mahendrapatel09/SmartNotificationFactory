using SmartNotificationFactory.NotificationSystem;

namespace SmartNotificationFactory;

class Program
{
    static void Main(string[] args)
    {
        // Enable proper encoding for console output
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Smart Notification System ===\n");

        INotification email = NotificationFactory.CreateNotification("EMAIL");
        email.Send("Welcome to ScholarHat! Your learning journey begins.");

        INotification sms = NotificationFactory.CreateNotification("SMS");
        sms.Send("Your OTP for login is 987654");

        INotification push = NotificationFactory.CreateNotification("PUSH");
        push.Send("New course 'Java Design Patterns' is now available!");

        INotification whatsapp = NotificationFactory.CreateNotification("WHATSAPP");
        whatsapp.Send("Your order #ORD123 has been shipped successfully.");

        INotification telegram = NotificationFactory.CreateNotification("TELEGRAM");
        telegram.Send("Your order #ORD123 has been shipped successfully.");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}