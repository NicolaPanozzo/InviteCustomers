using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Invite
{
    public class StreamToStreamReader : IStreamReader
    {
        private IStream stream;

        public StreamToStreamReader(IStream s)
        {
            stream = s;
        }

        public StreamReader GetStreamReader()
        {
            StreamReader newReader = new StreamReader(stream.GetStream());
            return newReader;
        }
    }
}
