namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory = new NotificationFactory();

            Console.WriteLine("===== Email =====");
            INotificationService email = factory.Create(NotificationType.Email);
            email.Send("student@school.nl", "Je rooster is gewijzigd.");

            Console.WriteLine("===== Logged Email =====");
            INotificationService loggedEmail = factory.Create(NotificationType.LoggedEmail);
            loggedEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            Console.WriteLine("===== Critical SMS =====");
            INotificationService criticalSms = factory.Create(NotificationType.CriticalSms);
            criticalSms.Send("0612345678", "Server ligt eruit.");

            Console.ReadLine();

        }
    }
}