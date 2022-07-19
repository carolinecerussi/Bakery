using System;

namespace Bakery.Models
{
  public class Pastry
  {
   public static double PPrice = 2;
   double Discount;
   public int Quantity {get; set;}

   public static double Price
   {
    get {return PPrice;}
    set {PPrice = value; }
   }
    public Pastry(int quantity)
    {
      PPrice = Price;
      Discount = 0.5;
      Quantity = quantity;
    }
    public double PastryCost ()
      {
      double pastryTotal = 0;
      for ( int i = 0; i <= Quantity; i++)
      {
      if(i == 0)
      {
        pastryTotal += 0;
        } 
        else if (i % 3 == 0)
        {
          pastryTotal += PPrice * Discount;
        }
        else
        {
          pastryTotal += PPrice;
        }
      }
    return pastryTotal;
  }
}
}