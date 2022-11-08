using MarketplaceFactory.Contracts;
using MarketplaceFactory.Models.DTO;
using MarketplaceFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MarketplaceFactory.Marketplaces
{
    public class WildberriesController : IMarketplace
    {
        public async Task<IEnumerable<BasicDTO>> GetResponceAsync(string url)
        {
            List<BasicDTO> result = new List<BasicDTO>();

            using (HttpClient client = new HttpClient())
            {       
                HttpResponseMessage response = await client.GetAsync(url);

                string? source = null;

                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    source = await response.Content.ReadAsStringAsync();
                }
                else throw new Exception("Неизветсная сетевая ошибка");

                Root? root = JsonConvert.DeserializeObject<Root>(source);

                if (root is not null)
                {
                    foreach (Product product in root.data.products)
                    {
                        result.Add(new BasicDTO()
                        {
                            Id = product.id.ToString(),
                            Title = product.name,
                            Brand = product.brand,
                            Feddbacks = product.feedbacks.ToString(),
                            Price = product.priceU.ToString()
                        });
                    }
                }
            }

            return result;
        }
    }
}
