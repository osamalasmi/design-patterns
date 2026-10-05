namespace NotificationApp
{
    public class LoggingNotificationDecorator : NotificationDecorator
    {
        public LoggingNotificationDecorator(
            INotificationService notificationService)
            : base(notificationService)
        {
        }

        public override void Send(
            string recipient,
            string message)
        {
            // Voeg hier logging toe
            Console.WriteLine($"LOG: notificatie naar {recipient}: {message}");
            // Geef daarna het versturen door
            // aan notificationService
            notificationService.Send(recipient, message);

        }
    }
}
