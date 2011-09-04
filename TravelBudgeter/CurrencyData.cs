using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelBudgeter
{
    public class CurrencyData
    {
        private static Dictionary<string, double> ExchangeRates = new Dictionary<string, double>();
        private static string defaultCurrency = "NZD";
        public static string DefaultCurrency { get { return defaultCurrency; } set { UpdateDefaultCurrency(value); } }

        static CurrencyData()
        {
            AddExchangeRate(DefaultCurrency, 1.0);
            AddExchangeRate("NZD", 1.0);
            AddExchangeRate("AUD", 0.75);
            AddExchangeRate("USD", 0.84);
            AddExchangeRate("GBP", 0.5);
            AddExchangeRate("EUR", 0.6);
        }

        private static void UpdateDefaultCurrency(string value)
        {
            defaultCurrency = value;
        }

        public static void AddExchangeRate(string currency, double rate)
        {
            ExchangeRates[currency] = rate;
        }
        public static double GetExchangeRate(string currency)
        {
            if (ExchangeRates.ContainsKey(currency))
                return ExchangeRates[currency];
            return 1.0;
        }
        public static double GetDefaultRate()
        {
            return ExchangeRates[DefaultCurrency];
        }
        public static string [] GetCurrencyList()
        {
            return ExchangeRates.Keys.ToArray();
        }
    }
}
