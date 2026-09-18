namespace NotificationApp
{
 internal class NotificationManager : INotificationService
{
    private INotificationService? iNotificationService;

    public void SetNotificationService(INotificationService ns)
        {
            iNotificationService = ns;
        }

    public void Send(string recipient, string message)
        {
            if (iNotificationService == null)
                throw new InvalidOperationException("Geen notification service ingesteld. Roep eerst SetNotificationService() aan.");
            
            iNotificationService.Send(recipient, message);
        }
}   
}