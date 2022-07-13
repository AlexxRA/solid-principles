using System;

namespace solid_principles.src.liskov_substitution.violation
{
  public abstract class BaseProduct
  {
    public string Name { get; set; }

    public decimal Price { get; set; }

    public abstract void ShippingFee();
  }
}