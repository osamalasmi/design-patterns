namespace NotificationApp
{
    internal class NotificationManager : INotificationService
    {
        private INotificationService? iNotificationService;
        private WhatsAppClient? whatsAppClient;

        public void SetNotificationService(INotificationService ns, WhatsAppClient whatsAppClient)
        {
            iNotificationService = ns;
            this.whatsAppClient = whatsAppClient;
        }

        public void Send(string recipient, string message)
        {
            if (iNotificationService == null)
                throw new InvalidOperationException("Geen notification service ingesteld. Roep eerst SetNotificationService() aan.");

            iNotificationService.Send(recipient, message);
        }

        public void SendWhatsApp(string phoneNumber, string text, bool urgent)
        {
            whatsAppClient.SendWhatsAppMessage(phoneNumber, text, urgent);
        }
    }
}