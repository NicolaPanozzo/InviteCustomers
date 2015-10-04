using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Invite
{
    //deserialize JSON objects from a stream implementing the interface IObjectReader
    class JsonObjectReader<T> : IObjectReader<T>
    {
        private IStream stream;

        public JsonObjectReader(IStream r)
        { stream = r; }

        public IEnumerable<T> FetchObjects()
        {
            StreamReader newReader = new StreamReader(stream.GetStream());
            String line;
            while ((line = newReader.ReadLine()) != null)
            {
                yield return JsonConvert.DeserializeObject<T>(line);
            }
        }
    }
}
