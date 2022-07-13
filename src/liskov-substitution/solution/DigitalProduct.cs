using System;

namespace solid_principles.src.liskov_substitution.solution
{
  public abstract class DigitalProduct : ProductBase, IDigitalProduct
  {
    public decimal FileSize { get; set; }

    public override void DeliverToCustomer()
    {
      DeliverViaEmail();
    }

    private void DeliverViaEmail()
    {
      Console.WriteLine($"{this.Name} was sent by e-mail..");
    }
  }
}