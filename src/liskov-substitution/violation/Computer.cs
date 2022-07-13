using System;

namespace solid_principles.src.liskov_substitution.violation
{
    public class Computer : BaseProduct
    {
        public override void ShippingFee()
        {
            Console.WriteLine($"Shipping fee is ...");
        }
  }
}