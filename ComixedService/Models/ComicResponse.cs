using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComixedService.Models
{
    public class ComicResponse
    {
        [DeserializeAs(Name = "comics")]
        public List<Comic> Comics { get; set; }
    }
}
