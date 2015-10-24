using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invite
{
    public interface IWebClientFactory
    {
        IWebClient Create();
    }
}
