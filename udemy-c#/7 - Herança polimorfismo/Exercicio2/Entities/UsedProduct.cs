using System.Globalization;
using System;

namespace Exercicio2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacterDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturerDate)
            : base(name, price)
        {
            ManufacterDate = manufacturerDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufacterDate.ToString("dd / MM / yyyy")
                + ")";
        }
    }
}
