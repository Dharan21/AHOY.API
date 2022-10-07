using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Utilities
{
    public static class Helper
    {
        public static T? JsonCast<T>(this Object myobj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(myobj,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                }));
        }
    }
}
