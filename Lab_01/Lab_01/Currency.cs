using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    public class Currency : IEquatable<Currency>
    {
        public readonly string _id;
        public readonly bool _isDigital;
        public readonly string _currencyName;
        public readonly string _symbol;


        public readonly Dictionary<string, CurrencySubType> SubTypes;
        public CurrencySubType DisplayingSubType { get; private set; }
        private CurrencyTypeRepository _repo = new CurrencyTypeRepository();

        public Currency(string id)
        {
            if (!_repo.Exists(id))
            {
                throw new ArgumentException("Invalid ISO Currency Code");
            }

            var newCurrency = _repo.Get(id);
            _id = newCurrency._id;
            _isDigital = newCurrency._isDigital;
            _currencyName = newCurrency._currencyName;
            _symbol = newCurrency._symbol;

        }

        public Currency(string isoCode, bool isDigital, string generalName, string symbol)
        {
            _id = isoCode;
            _isDigital = isDigital;
            _currencyName = generalName;
            _symbol = symbol;

        }

        public Currency(string id, bool isDigital, string name, string symbol, Dictionary<string, CurrencySubType> subtypes)
        {
            _id = id;
            _isDigital = isDigital;
            _currencyName = name;
            _symbol = symbol;

            SubTypes = subtypes;
        }

        #region Equals and !Equals
        public static bool operator ==(Currency a, Currency b) { return Equals(a, b); }

        public static bool operator !=(Currency a, Currency b) { return !Equals(a, b); }

        public bool Equals(Currency other)
        {
            if (ReferenceEquals(null, other)) 
                return false;
            if (ReferenceEquals(this, other)) 
                return true;

            return _id == other._id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) 
                return false;
            else if (ReferenceEquals(this, obj)) 
                return true;
            else if(obj.GetType() != typeof(Currency)) 
                return false;

            return Equals((Currency)obj);
        }

        #endregion

        public CurrencySubType GetSubType(string key)
        {
            if (SubTypes != null)
            {
                if (SubTypes.ContainsKey(key))
                    return SubTypes[key];
            }

            return null;
        }

        public void DisplayAsSubType(string key)
        {
            DisplayingSubType = GetSubType(key);
        }

        public class CurrencySubType      // different types of internet currencies
        {
            public string _symbol;  

            public string Symbol
            {
                get { return _symbol; }
                set { _symbol = value; }
            }

        }


        public class CurrencyTypeRepository
        {
            // List of all currencies with their properties.
            public static readonly Dictionary<string, Currency> Currencies =
                new Dictionary<string, Currency>()
                {
            {"BTC", new Currency("BTC", true, "Bitcoin", "฿",
                new Dictionary<string, CurrencySubType>()
                {
                    {"mBTC", new CurrencySubType{_symbol = "mBTC "}}
                }
            )},
            {"LTC", new Currency("LTC", true, "Litecoin", "L",
                new Dictionary<string, CurrencySubType>()
                {
                    {"mLTC", new CurrencySubType{_symbol = "mLTC "}}
                }
            )},
            {"AUD", new Currency("AUD", false, "Australian dollar", "$")},
            {"CAD", new Currency("CAD", false, "Canadian dollar", "$")},
            {"CNY", new Currency("CNY", false, "Renminbi", "¥")},
            {"EUR", new Currency("EUR", false, "Euro", "€")},
            {"GBP", new Currency("GBP", false, "Pound sterling", "£")},
            {"HKD", new Currency("HKD", false, "Hong Kong dollar", "HKD$")},
            {"IDR", new Currency("IDR", false, "Indonesian rupiah", "Rp")},
            {"INR", new Currency("INR", false, "Indian rupee", "Rs")},
            {"JPY", new Currency("JPY", false, "Japanese yen", "¥")},
            {"KRW", new Currency("KRW", false, "South Korean won", "₩")},
            {"MOP", new Currency("MOP", false, "Pataca", "MOP$")},
            {"NZD", new Currency("NZD", false, "New Zealand dollar", "$")},
            {"PHP", new Currency("PHP", false, "Philippine peso", "P")},
            {"RUB", new Currency("RUB", false, "Russian ruble", "PP")},
            {"SGD", new Currency("SGD", false, "Singapore dollar", "S$")},
            {"TWD", new Currency("TWD", false, "New Taiwan dollar", "$")},
            {"USD", new Currency("USD", false, "US dollar", "$")},
            {"VND", new Currency("VND", false, "Vietnamese dong", "₫")},
            {"ZAR", new Currency("ZAR", false, "South African rand", "R")}
                };

            public Currency Get(string id)
            {
                if (Currencies.ContainsKey(id))
                {
                    return Currencies[id];
                }
                else
                {
                    return null;
                }
            }

            public bool Exists(string id) { return Currencies.ContainsKey(id); }
        }

        public override string ToString() { return this._id + _symbol; }
        public override int GetHashCode() { return _id.GetHashCode(); }
    }
}
