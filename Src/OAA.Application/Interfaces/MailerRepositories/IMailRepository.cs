namespace OAA.Application.Interfaces.MailerRepositories
{
    /// <summary>
    /// Mail repository
    /// </summary>
    public interface IMailRepository
    {
        void Send(string title, string message);
    }
}