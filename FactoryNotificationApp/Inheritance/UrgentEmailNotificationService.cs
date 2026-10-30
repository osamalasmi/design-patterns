using NotificationApp;

public class UrgentEmailNotificationService : EmailNotificationService
{
    public override void Send(string recipient, string message)
    {
        string urgent = $"[URGENT] {message}";
        base.Send(recipient, urgent);
    }
}