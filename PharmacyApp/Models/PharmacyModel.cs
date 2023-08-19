using System;

namespace PharmacyApp.Models
{
    public class PharmacyModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        private int _stocksCount = 1;
        public int StocksCount { get { return _stocksCount; } }
        private int _lastIndex;
        private Stock[] _stocks;
        public PharmacyModel(int stocksCount)
        {
            _stocksCount = stocksCount;
            _stocks = new Stock[_stocksCount];
            _lastIndex = 0;
        }
        public void AddStock(Stock stock)
        {
            if (_lastIndex >= StocksCount)
                throw new Exception("Pharmacy are filled");
            this._stocks[_lastIndex] = stock;
            _lastIndex++;
        }
        // public int WorkerCount { get; set; } // Gelecek ucun
    }
}
