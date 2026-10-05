namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NotificationManager smsService = new NotificationManager();
            // smsService.SetNotificationService(new SmsNotificationService());
            // smsService.Send("0612345678",
            //     "Je les begint over 15 minuten.");


            // NotificationManager pushService = new NotificationManager();
            // pushService.SetNotificationService(new PushNotificationService());
            // pushService.Send("student123",
            //     "Er staat nieuwe feedback voor je klaar.");

            // INotificationService notification = new LoggedEmailNotificationService();

            // notification.Send(
            //     "student@school.nl",
            //     "Je rooster is gewijzigd."
            // );

            // INotificationService smsNotification = new LoggedSmsNotificationService();

            // smsNotification.Send(
            //     "0612341235123",
            //     "Je telefoon is gewijzigd."
            // );

            // INotificationService urgentNotification = new UrgentEmailNotificationService();

            // urgentNotification.Send(
            //     "student@school.nl",
            //     "Je rooster is gewijzigd."
            // );

            // INotificationService urgentSmsNotification = new UrgentSmsNotificationService();

            // urgentSmsNotification.Send(
            //     "061324513241",
            //     "Je rooster is gewijzigd."
            // );


            // INotificationService emailNotification = new EmailNotificationService();
            // emailNotification = new LoggingNotificationDecorator(emailNotification);
            // emailNotification.Send("student@school.nl", "Nieuwe melding.");


            // INotificationService smsNotification = new SmsNotificationService();
            // smsNotification = new UrgentNotificationDecorator(smsNotification);
            // smsNotification.Send("06139213947", "Nieuwe melding sms.");


            INotificationService notification =
    new LoggingNotificationDecorator(
        new UrgentNotificationDecorator(
            new EmailNotificationService()
        )
    );

            notification.Send("student@school.nl", "Nieuwe melding.");

            INotificationService notification2 =
                new UrgentNotificationDecorator(
                    new LoggingNotificationDecorator(
                        new EmailNotificationService()
                    )
                );

            notification2.Send("student@school.nl", "Nieuwe melding.");

            INotificationService timeStamp = new LoggingNotificationDecorator(
                new TimestampNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new SmsNotificationService()
                    )
                )
            );

            timeStamp.Send("student@school.nl", "Je rooster is gewijzigd.");

            INotificationService smsNoti = new UrgentNotificationDecorator(
                new TimestampNotificationDecorator(
                    new LoggingNotificationDecorator(new SmsNotificationService())
                )
            );

            smsNoti.Send("0612341234512", "Eindopdracht notification");

            Console.ReadLine();
        }
    }
}