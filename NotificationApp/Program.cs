namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            NotificationManager emailService = new NotificationManager();
            emailService.SetNotificationService(new EmailNotificationService(), new WhatsAppClient());
            emailService.Send("student@school.nl",
                "Je nieuwe rooster staat klaar.");
            emailService.SendWhatsApp("062135213", "hello", true);
            

            // NotificationManager smsService = new NotificationManager();
            // smsService.SetNotificationService(new SmsNotificationService());
            // smsService.Send("0612345678",
            //     "Je les begint over 15 minuten.");


            // NotificationManager pushService = new NotificationManager();
            // pushService.SetNotificationService(new PushNotificationService());
            // pushService.Send("student123",
            //     "Er staat nieuwe feedback voor je klaar.");

            Console.ReadLine();
        }
    }
}