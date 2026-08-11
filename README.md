# Smart Notification Factory

A simple C# console application demonstrating the **Factory Design Pattern**. It creates different types of notifications (Email, SMS, Push, WhatsApp) through a single factory method, without exposing the instantiation logic of each concrete notification class to the caller.

## Overview

The `NotificationFactory` class exposes a static `CreateNotification(string type)` method that returns an object implementing the `INotification` interface. Based on the `type` argument passed in, the factory decides which concrete notification class to instantiate:

| Type string | Concrete class |
|---|---|
| `EMAIL` | `EmailNotification` |
| `SMS` | `SMSNotification` |
| `PUSH` | `PushNotification` |
| `WHATSAPP` | `WhatsAppNotification` |
| `TELEGRAM` | `TelegramNotification` |

Any unrecognized or empty type throws an `ArgumentException`.

## Project structure

```
SmartNotificationFactory/
├── Program.cs                  # Entry point / demo of the factory in action
└── NotificationSystem/
    ├── INotification.cs        # Common interface with a Send(string message) method
    ├── NotificationFactory.cs  # Factory that creates the correct notification type
    ├── EmailNotification.cs
    ├── SMSNotification.cs
    ├── PushNotification.cs
    ├── WhatsAppNotification.cs
    └── TelegramNotification.cs
```

## How it works

1. The caller asks the factory for a notification type as a string (case-insensitive, whitespace-trimmed):

   ```csharp
   INotification email = NotificationFactory.CreateNotification("EMAIL");
   email.Send("Welcome to ScholarHat! Your learning journey begins.");
   ```

2. The factory matches the string against a `switch` expression and returns the corresponding notification object.
3. The caller only interacts with the `INotification` abstraction (`Send(string message)`), so it never needs to know about the concrete classes directly.

## Running the project

```bash
dotnet run
```

### Sample output

```
=== Smart Notification System ===

[Email] Sending: Welcome to ScholarHat! Your learning journey begins.
[SMS] Sending: Your OTP for login is 987654
[Push] Sending: New course 'Java Design Patterns' is now available!
[WhatsApp] Sending: Your order #ORD123 has been shipped successfully.
[Telegram] Sending: Your invoice #INV456 is ready for download.

Press any key to exit...
```

*(Exact wording depends on each concrete class's `Send` implementation.)*

## Extending the system

To add a new notification channel (e.g. Slack), following the same approach used for Telegram:

1. Create a class implementing `INotification`, e.g. `SlackNotification`.
2. Add a new case to the `switch` expression in `NotificationFactory.CreateNotification`:

   ```csharp
   "SLACK" => new SlackNotification(),
   ```

3. Call it the same way as any other type:

   ```csharp
   INotification slack = NotificationFactory.CreateNotification("SLACK");
   slack.Send("Deployment finished successfully.");
   ```

No changes are needed anywhere else in the codebase — this is the core benefit of the Factory pattern.

## Requirements

- .NET SDK (6.0 or later recommended, for file-scoped namespaces and top-level `switch` expressions)

## License

Add your preferred license here (e.g. MIT).
