namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opdracht 1 - Beginsituatie
            Kop("Opdracht 1 - Beginsituatie");
            INotificationService basis = new EmailNotificationService();
            basis.Send("student@school.nl", "Je rooster is gewijzigd.");

            // Opdracht 2 - Logging met inheritance
            Kop("Opdracht 2 - Logging met inheritance");
            INotificationService loggedEmail = new LoggedEmailNotificationService();
            loggedEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            INotificationService loggedSms = new LoggedSmsNotificationService();
            loggedSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Opdracht 3 - Urgent met inheritance
            Kop("Opdracht 3 - Urgent met inheritance");
            INotificationService urgentEmail = new UrgentEmailNotificationService();
            urgentEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            INotificationService urgentSms = new UrgentSmsNotificationService();
            urgentSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Opdracht 6 - LoggingNotificationDecorator
            Kop("Opdracht 6 - LoggingNotificationDecorator");
            INotificationService loggingEmail = new EmailNotificationService();
            loggingEmail = new LoggingNotificationDecorator(loggingEmail);
            loggingEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            INotificationService loggingSms = new SmsNotificationService();
            loggingSms = new LoggingNotificationDecorator(loggingSms);
            loggingSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Opdracht 7 - UrgentNotificationDecorator
            Kop("Opdracht 7 - UrgentNotificationDecorator");
            INotificationService urgentDecorator =
                new UrgentNotificationDecorator(
                    new EmailNotificationService()
                );
            urgentDecorator.Send("student@school.nl", "Je leslokaal is gewijzigd.");

            // Opdracht 8 - Decorators combineren
            Kop("Opdracht 8 - Decorators combineren");
            INotificationService gecombineerd =
                new LoggingNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new EmailNotificationService()
                    )
                );
            gecombineerd.Send("student@school.nl", "Je rooster is gewijzigd.");

            // Opdracht 9 - Maakt de volgorde uit?
            Kop("Opdracht 9 - Variant A (Logging -> Urgent -> Email)");
            INotificationService variantA =
                new LoggingNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new EmailNotificationService()
                    )
                );
            variantA.Send("student@school.nl", "Nieuwe melding.");

            Kop("Opdracht 9 - Variant B (Urgent -> Logging -> Email)");
            INotificationService variantB =
                new UrgentNotificationDecorator(
                    new LoggingNotificationDecorator(
                        new EmailNotificationService()
                    )
                );
            variantB.Send("student@school.nl", "Nieuwe melding.");

            // Opdracht 10 - TimestampNotificationDecorator
            Kop("Opdracht 10 - Logging -> Timestamp -> Urgent -> Email");
            INotificationService timestampEmail =
                new LoggingNotificationDecorator(
                    new TimestampNotificationDecorator(
                        new UrgentNotificationDecorator(
                            new EmailNotificationService()
                        )
                    )
                );
            timestampEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            Kop("Opdracht 10 - Logging -> Timestamp -> Urgent -> SMS");
            INotificationService timestampSms =
                new LoggingNotificationDecorator(
                    new TimestampNotificationDecorator(
                        new UrgentNotificationDecorator(
                            new SmsNotificationService()
                        )
                    )
                );
            timestampSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Opdracht 16 - Eindopdracht
            Kop("Opdracht 16 - Eindopdracht (SMS, urgent, timestamp, gelogd)");
            INotificationService eindopdracht =
                new UrgentNotificationDecorator(
                    new TimestampNotificationDecorator(
                        new LoggingNotificationDecorator(
                            new SmsNotificationService()
                        )
                    )
                );
            eindopdracht.Send("0612345678", "Eindopdracht notification");

            Console.ReadLine();
        }

        // Print een kopje zodat je in de output ziet welke opdracht het is
        static void Kop(string titel)
        {
            Console.WriteLine($"===== {titel} =====");
        }
    }
}