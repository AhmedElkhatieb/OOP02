using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo.Association_Composition
{
    internal class Order
    {
        // Association Compostion (Has A)
        // Order has an item
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public decimal Total {  get; set; }
        public OrderItem[] Items { get; set; }
        public Order(string _BuyerEmail, OrderItem[] _Items )
        {
            BuyerEmail = _BuyerEmail;
            Items = _Items;
        }
    }
}
