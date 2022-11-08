using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestBuilder.Contracts
{
    public interface IBuilder
    {
        void Reset();
        IBuilder AddBaseUrl(string url);
        IBuilder AddBasePrefix(string prefix);
        IBuilder AddNameFilter(string name);
        IBuilder AddPageNumber(string number);
        

        IRequestProducts GetResult();

        string GetUrl();
    }
}
