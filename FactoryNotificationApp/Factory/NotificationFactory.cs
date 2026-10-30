namespace NotificationApp
{
    public class NotificationFactory
    {
        public INotificationService Create(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email:
                    return new EmailNotificationService();

                case NotificationType.Sms:
                    return new SmsNotificationService();

                case NotificationType.LoggedEmail:
                    return new LoggingNotificationDecorator(new EmailNotificationService());

                case NotificationType.UrgentSms:
                    return new UrgentNotificationDecorator(new SmsNotificationService());

                case NotificationType.TimestampedEmail:
                    return new TimestampNotificationDecorator(new EmailNotificationService());

                case NotificationType.CriticalSms:
                    return new UrgentNotificationDecorator(
                        new TimestampNotificationDecorator(
                            new LoggingNotificationDecorator(
                                new SmsNotificationService()
                            )
                        )
                    );

                default:
                    throw new ArgumentException("Deze notificatie staat niet op de kaart.");
            }
        }
    }
}