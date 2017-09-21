using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICurrencyConversion
    {
        [OperationContract]
        double DkkToEur(double value);

        [OperationContract]
        double DkkToX(string iso, double value);

        [OperationContract]
        CurrencyData[] GetCurrencyData();

        [OperationContract]
        double XtoY(string from, string to, double value);
    }
    
}
