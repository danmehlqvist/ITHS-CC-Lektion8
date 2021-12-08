using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ExternalServices
{
    public class EmailService : IEmailService
    {
        public void SendMessage(List<string> recipients, string subject, string message)
        {
            Console.WriteLine($"Sending the email with subject {subject} and message {message} to the following recipients:");
            foreach (var recipient in recipients)
            {
                Console.WriteLine(recipient);
            }
        }
    }
}
