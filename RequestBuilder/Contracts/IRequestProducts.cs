using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestBuilder.Contracts
{
    public interface IRequestProducts
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
    }
}
