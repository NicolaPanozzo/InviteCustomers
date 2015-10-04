using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Invite
{
    //define a method to create a Stream from a generic source
    interface IStream
    {
        Stream GetStream();
    }
}
