using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceFactory.Models
{
    public class Root
    {
        public Metadata metadata { get; set; }
        public int state { get; set; }
        public int version { get; set; }
        public Data data { get; set; }
    }
}
