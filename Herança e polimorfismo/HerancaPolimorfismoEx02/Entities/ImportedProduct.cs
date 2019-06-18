using System.Globalization;

namespace HerancaPolimorfismoEx02.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFree)
            :base(name, price)
        {
            CustomFree = customFree;
        }

        public double TotalPrice()
        {
            return Price + CustomFree;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + 
                   $"(Customs free: $ {CustomFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
