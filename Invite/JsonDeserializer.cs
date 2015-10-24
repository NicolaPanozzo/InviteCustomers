using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Invite
{
    //deserialize JSON objects from a stream implementing the interface IObjectReader
    public class JsonDeserializer<T> : IObjectDeserializer<T>
    {
        private IStreamReader streamReader;

        public JsonDeserializer(IStreamReader s)
        { streamReader = s; }

        public IEnumerable<T> Deserialize()
        {
            using (var newStreamReader = streamReader.GetStreamReader())
            {
                String line;
                while ((line = newStreamReader.ReadLine()) != null)
                {
                    yield return JsonConvert.DeserializeObject<T>(line);
                }
            }
        }
    }
}
