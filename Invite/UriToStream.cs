using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Invite
{
    //create a new Stream from a URL source
    public class UriToStream : IStream
    {
        private IWebClientFactory webClientFactory;
        private String uri;

        public UriToStream(IWebClientFactory w, String u)
        {
            webClientFactory = w;
            uri = u;
        }

        public Stream GetStream()
        {
            using (var client = webClientFactory.Create())
            {
                Stream stream = client.OpenRead(uri);
                return stream;
            }
        }
    }
}
