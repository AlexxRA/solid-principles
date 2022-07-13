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

//The problem here is that an electronic book can't be sent on a ship, so violates the LSP
//because: Ebook ebook = new BaseProduct() is not possible to call
//ebook.ShippingFee()