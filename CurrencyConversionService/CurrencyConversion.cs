using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CurrencyConversion : ICurrencyConversion
    {
        private List<CurrencyData> currencies;
        public CurrencyConversion()
        {
            currencies = new List<CurrencyData>();
            CurrencyData usd = new CurrencyData { Name = "America", ISO = "usd", ExchangeRate = 5.2402 };
            CurrencyData cad = new CurrencyData { Name = "Canada", ISO = "cad", ExchangeRate = 4.9227 };
            CurrencyData eur = new CurrencyData { Name = "Euro", ISO = "eur", ExchangeRate = 7.4599 };
            currencies.Add(usd);
            currencies.Add(cad);
            currencies.Add(eur);

        }
        public double DkkToEur(double value)
        {
            return value / 7.4599;
        }

        public double DkkToX(string iso, double value)
        {
            double rate;
            CurrencyData CD = GetCurrencyData(iso);
            rate = CD.ExchangeRate;
            return value / rate;

        }

        public CurrencyData[] GetCurrencyData()
        {
            return currencies.ToArray();
        }

        public double XtoDkk(string iso, double value)
        {
            double rate;
            CurrencyData CD = GetCurrencyData(iso);
            rate = CD.ExchangeRate;
            return value * rate;

        }

        public double XtoY(string from, string to, double value)
        {
            double x = XtoDkk(from, value);
            return DkkToX(to, x);
        }

        private CurrencyData GetCurrencyData(string iso)
        {
            CurrencyData result = new CurrencyData();

            foreach (CurrencyData CD in currencies)
            {
                if(CD.ISO == iso.ToLower())
                {
                    result = CD;
                }
                
            }
            return result;
        }
    }
}
