using RequestBuilder.Contracts;
using RequestBuilder.RequestProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RequestBuilder.Builders
{
    public class WildberriesRequestBuilder : IBuilder
    {
        private IRequestProducts _product = new WildberriesRequest(); 

        public IBuilder AddBaseUrl(string url)
        {
            _product.BaseUrl = url;
            return this;
        }

        public IBuilder AddBasePrefix(string prefix)
        {
            _product.Prefix = prefix;
            return this;
        }

        public IBuilder AddNameFilter(string name)
        {
            Regex regex = new Regex(@"&query=(.+?)(?=&|$)");

            Match match = regex.Match(_product.Prefix);

            if (match.Success)
            {
                _product.Prefix = regex.Replace(_product.Prefix, @"&query=" + name);
            }
            else
            {
                _product.Prefix += @"&query=" + name;
            }

            return this;
        }

        public IBuilder AddPageNumber(string number)
        {
            Regex regex = new Regex(@"&page=(.+?)(?=&|$)");

            Match match = regex.Match(_product.Prefix);

            if (match.Success)
            {
                _product.Prefix = regex.Replace(_product.Prefix, @"&page=" + number);
            }
            else
            {
                _product.Prefix += @"&page=" + number;
            }

            return this;
        }

        public string GetUrl()
        {
            string product = _product.BaseUrl + _product.Prefix;
            Reset();
            return product;
        }

        public IRequestProducts GetResult()
        {
            IRequestProducts product = _product;
            Reset();
            return product;
            
        }

        public void Reset()
        {
            this._product = new WildberriesRequest();
        }
    }
}
