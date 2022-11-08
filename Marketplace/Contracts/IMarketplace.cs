using MarketplaceFactory.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceFactory.Contracts
{
    public interface IMarketplace
    {
        Task<IEnumerable<BasicDTO>> GetResponceAsync(string url);
    }
}
