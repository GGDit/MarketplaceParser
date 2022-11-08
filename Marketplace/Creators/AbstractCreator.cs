using MarketplaceFactory.Contracts;
using MarketplaceFactory.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceFactory.Creators
{
    public abstract class AbstractCreator
    {
        public abstract IMarketplace FactoryMethod();

        public IEnumerable<BasicDTO> GetResponce(string url)
        {
            var product = FactoryMethod();

            var result =  product.GetResponceAsync(url);

            return result.Result;
        }
    }
}

