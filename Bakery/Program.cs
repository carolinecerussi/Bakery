using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{ public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to my bakery! We specialize Bread and Pastries");
      Console.WriteLine("One loaf of bread cost $" + Bread.Price);
      Console.WriteLine("Each pastry costs $" + Pastry.Price);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Todays special offers:");
      Console.WriteLine("Bread: Buy 2 loaves, get the third FREE!");
      Console.WriteLine("Pastry: For every 2 pastries you order, get the third for $1!");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("How many loaves of bread would you like to order?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to order?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Bread answerBread = new Bread(breadOrder);
      Pastry answerPastry = new Pastry(pastryOrder);
      Console.WriteLine("For " + answerBread.Quantity + " loaf/ves of bread, and " + answerPastry.Quantity + " pastry/pastries, your order costs: $" + (answerBread.BreadCost() + answerPastry.PastryCost()));
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Thank you so much!");
    }
  }
}

// response 1, response 2, response 3