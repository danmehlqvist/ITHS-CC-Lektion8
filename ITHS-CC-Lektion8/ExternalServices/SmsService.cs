using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ExternalServices
{
    public class SmsService : ISmsService
    {
        public bool SendMessage(string number, string message)
        {
            // Dummy-implementering
            Console.WriteLine($"Vi skickar ett SMS till {number} med följande innehåll:");
            Console.WriteLine(message);
            return true;
        }
    }
}
