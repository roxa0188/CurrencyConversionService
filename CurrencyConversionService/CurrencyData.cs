using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CurrencyConversionService
{
    [DataContract (Namespace = "CCService")]
    public class CurrencyData
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ISO { get; set; }
        [DataMember]
        public double ExchangeRate { get; set; }
    }
}
