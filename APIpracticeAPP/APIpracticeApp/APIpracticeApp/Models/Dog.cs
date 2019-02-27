using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace APIpracticeApp
{
    public partial class DogData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    //public partial class DogData
    //{
    //    public static DogData FromJson(string json) => JsonConvert.DeserializeObject<DogData>(json, DogData.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this DogData self) => JsonConvert.SerializeObject(self, DogData.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
