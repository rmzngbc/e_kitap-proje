using System.Threading.Tasks;

namespace ekitap.webui.EmailServices
{
    public interface IEmailSender
    {
         
         Task SendEmailAsync(string email,string subject,string htmlMessage);
    
    }
}