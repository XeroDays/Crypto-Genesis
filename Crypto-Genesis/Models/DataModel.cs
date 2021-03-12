using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Models
{
   public  class DataModel
    {
        public string MarketCap { get; set; }
        public string CirculatingSupply { get; set; }
        public decimal MarketCap_decimal { get { return Convert.ToDecimal(MarketCap); } set { } }
        public decimal CirculatingSupply_decimal { get { return Convert.ToDecimal(CirculatingSupply); } set { } }
        public string CurrencyCode { get; set; }
    }
}
