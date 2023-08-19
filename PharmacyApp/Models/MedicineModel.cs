using System;

namespace PharmacyApp.Models
{
    public abstract class MedicineModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MedicineTypes Type { get; set; }
        public MedicinePurposes Purpose { get; set; }
        public DateTime ProdDate { get; set; }
        public DateTime ExpDate { get; set; }
    }

    public enum MedicineTypes
    {
        None = 0,
        Liquid,
        Tablet,
        Capsules,
        Drops,
        Inhalers,
        Injections
    }

    public enum MedicinePurposes
    {
        None = 0,
        Kardioloji,
        Nevroloji,
        Lore,
    }
}
