using System;

namespace Bakery.Models
{
  public class Bread
  {
   public static double BPrice = 5;
   double Discount;
   public int Quantity {get; set;}

   public static double Price
   {
    get {return BPrice;}
    set {BPrice = value; }
   }
    public Bread(int quantity)
    {
      BPrice = Price;
      Discount = 0.0;
      Quantity = quantity;
    }
    public double BreadCost ()
      {
      double breadTotal = 0;
      for ( int i = 0; i <= Quantity; i++)
      {
      if(i == 0)
      {
        breadTotal += 0;
        } 
        else if (i % 3 == 0)
        {
          breadTotal += BPrice * Discount;
        }
        else
        {
          breadTotal += BPrice;
        }
      }
    return breadTotal;
  }
}
}


  // public Bread(int cost, int quantity)
  // {
  //   Cost = cost;
  //   Quantity = quantity;
  // }