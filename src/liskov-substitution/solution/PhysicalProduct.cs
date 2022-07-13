using System;

namespace solid_principles.src.liskov_substitution.solution
{
  public class PhysicalProduct : ProductBase, IPhysicalProduct 
  {
    public decimal Weight { get; set; }


    public override void DeliverToCustomer() 
    {
       DeliverViaCargo();
    }

    private void DeliverViaCargo()
    {
      Console.WriteLine($"{this.Name} was sent by cargo..");
    }
  }
}