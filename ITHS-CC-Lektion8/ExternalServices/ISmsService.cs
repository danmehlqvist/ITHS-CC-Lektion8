using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ExternalServices
{
    public interface ISmsService
    {
        bool SendMessage(string number, string message);
    }
}
