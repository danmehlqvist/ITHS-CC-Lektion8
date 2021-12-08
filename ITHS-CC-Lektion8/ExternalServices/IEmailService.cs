using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ExternalServices
{
    public interface IEmailService
    {
        void SendMessage(List<string> recipients, string subject, string message);
    }
}
