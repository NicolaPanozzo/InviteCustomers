using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Invite
{
    //create a new Stream from a URL source
    class UrlReader : IStream
    {
        private String url;

        public UrlReader(String u)
        { url = u; }

        public Stream GetStream()
        {
            using (var client = new WebClient())
            {
                Stream stream = client.OpenRead(url);
                return stream;
            }
        }
    }
}
