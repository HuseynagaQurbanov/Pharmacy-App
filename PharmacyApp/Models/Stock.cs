using System;

namespace PharmacyApp.Models
{
    public class Stock
    {
        private static int _id;
        private int _lastIndex;
        public int Id { get { return _id; } }
        public int MedicineCount { get; }
        private StockMedicine[] _medicines;
        public Stock(int medicineCount)
        {
            MedicineCount = medicineCount;
            _medicines = new StockMedicine[MedicineCount];
            _id++;
            _lastIndex = 0;
        }
        public void AddToStock(StockMedicine medicine)
        {
            if (_lastIndex >= MedicineCount)
                throw new Exception("Stock are filled");
            this._medicines[_lastIndex] = medicine;
            _lastIndex++;
        }
    }
}
