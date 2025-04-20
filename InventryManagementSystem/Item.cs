using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventryManagementSystem
{
    internal class Item
    {
        public string ItemName { get; set; }
        public decimal ItemQty { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellingPrincePerUniit { get; set; }
        public decimal ProfitUnit { get; set; }
        public decimal TotalBuyPrice { get; set; }
        public decimal TotalSellingPrice { get; set; }

        public Item(string ItemName, decimal ItemQty, decimal BuyPrice, decimal ProfitUnit)
        {
            this.ItemName = ItemName;
            this.ItemQty = ItemQty;
            this.BuyPrice = BuyPrice;
            this.ProfitUnit = ProfitUnit;

            CalculatePrices();
        }
        private void CalculatePrices()
        {
            TotalBuyPrice = ItemQty * BuyPrice;
            SellingPrincePerUniit = BuyPrice + ProfitUnit;
            TotalSellingPrice = SellingPrincePerUniit * ItemQty;
        }

        public string ChangePrice(decimal Buyprice)
        {
            if (Buyprice <= 0)
                return "Please Enter Valid Amount";

            BuyPrice = Buyprice;
            CalculatePrices();

            return "Price Updated Successfully";
        }
        public string ChangeQty(decimal qty)
        {
            if (qty <= 0)
                return "Not a Valid Quantity";

            ItemQty = qty;
            CalculatePrices();

            return "Quantity Updated Successfully";
        }
        public string ChangeProfit(decimal profit)
        {
            if (profit <= 0)
                return "Not a Valid Profit";

            ProfitUnit = profit;
            CalculatePrices();

            return "Profit Updated Successfully";

        }
    }
}
