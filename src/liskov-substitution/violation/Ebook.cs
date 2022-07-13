using System;

namespace solid_principles.src.liskov_substitution.violation
{
  public class Ebook : BaseProduct
  {
    public override void ShippingFee()
    {
      throw new NotSupportedException("e-Book cannot be shipped by cargo!");
    }
  }

}