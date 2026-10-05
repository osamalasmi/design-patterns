namespace NotificationApp
{
    public class TimestampNotificationDecorator : NotificationDecorator
    {
        public TimestampNotificationDecorator(INotificationService notificationService)
        : base(notificationService) { }

        public override void Send(string recipient, string message)
        {
            string time = DateTime.Now.ToString("HH:mm");
            string timestampMessage = $"[{time}] {message}";
            notificationService.Send(recipient, timestampMessage);
        }
    }
}