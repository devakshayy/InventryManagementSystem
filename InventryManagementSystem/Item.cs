using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventryManagementSystem
{
    internal class Item
    {
        public string ItemName { get; set; }
        public decimal ItemQty { get; set; }
        public decimal Price { get; set; }

        public Item(string ItemName,decimal ItemQty,decimal Price)
        {
            this.ItemName = ItemName;
            this.ItemQty = ItemQty;
            this.Price = Price;
        }
        public string ChangePrice(decimal price)
        {
            if (price <= 0)
                return "Please Enter Valid Amount";
            Price = price;
            return "Price Updated Successfully";
        }
        public string ChangeQty(decimal qty)
        {
            if (qty <= 0)
                return "Not a Valid Quantity";
            ItemQty = qty;
            return "Quantity Updated Successfully";
        }
    }
}
