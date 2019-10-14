namespace MailKitTest.MailLogic
{
    public interface IMailSendLogic
    {
        void SendMailAsync(string to, string from, string subject, string text);
    }
}