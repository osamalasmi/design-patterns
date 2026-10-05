namespace NotificationApp
{
    public class UrgentNotificationDecorator : NotificationDecorator
    {
        public UrgentNotificationDecorator(INotificationService notificationService)
        : base(notificationService) { }

        public override void Send(string recipient, string message)
        {
            string urgentMessage = $"[URGENT] {message}";
            notificationService.Send(recipient, urgentMessage);
        }
    }
}