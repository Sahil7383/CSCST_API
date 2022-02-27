using Newtonsoft.Json;

namespace CSCST.Common
{
    public static class Utility
    {
        public static T JsonCast<T>(this Object myobj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(myobj,
                   new JsonSerializerSettings
                   {
                       ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                       NullValueHandling = NullValueHandling.Ignore
                   }));
        }
    }
}