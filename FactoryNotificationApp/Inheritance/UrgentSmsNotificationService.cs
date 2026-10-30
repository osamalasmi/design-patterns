using NotificationApp;

public class UrgentSmsNotificationService : SmsNotificationService
{
    public override void Send(string recipient, string message)
    {
        string urgent = $"[URGENT] {message}";
        base.Send(recipient, urgent);
    }
}