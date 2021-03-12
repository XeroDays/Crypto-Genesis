using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Models
{
    class ServerCurrency
    {
        public string CurrencyCode { get; set; }
        public string Code { get; set; }
        public string Link { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this); 
        }
    }
}
