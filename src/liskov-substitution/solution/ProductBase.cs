using System;

namespace solid_principles.src.liskov_substitution.solution
{
    public abstract class ProductBase : IDelivery
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void DeliverToCustomer();
    }
}