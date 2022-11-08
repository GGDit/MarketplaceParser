using MarketplaceFactory.Contracts;
using MarketplaceFactory.Marketplaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceFactory.Creators
{
    public class WildberriesCreator : AbstractCreator
    {
        public override IMarketplace FactoryMethod()
        {
            return new WildberriesController();
        }
    }
}
