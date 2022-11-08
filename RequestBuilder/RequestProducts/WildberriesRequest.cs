using RequestBuilder.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestBuilder.RequestProducts
{
    //{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public class WildberriesRequest : IRequestProducts
    {
        public string? BaseUrl { get; set; } = string.Empty;
        public string? Prefix { get; set; } = string.Empty;
    }
}
