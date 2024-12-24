using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo.Association_Composition
{
    internal class OrderItem
    {
        // Association Composition Relationship
        // OrderItem has an Item
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public OrderItem(Product _Product)
        {
            Product = _Product;
        }
    }
}
