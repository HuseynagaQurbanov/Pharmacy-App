using System;

namespace PharmacyApp.Models
{
    public class SoldMedicine : MedicineModel
    {
        public int SoldId { get; set; }
        public DateTime SoldDate { get; set; }
    }
}
