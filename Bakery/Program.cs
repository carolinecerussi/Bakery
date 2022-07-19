using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{ public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to my bakery! We specialize in loaves of bread, and patries.");
      Console.Write("One loaf of bread cost $" + Bread.Price);
      Console.Write("Each pastry costs $" + Pastry.Price);
      Console.Write("-----------------------------");
      Console.WriteLine("Todays special offers:");
      Console.Write("Bread: Buy 2 loaves, get the third FREE!");
      Console.Write("Pastry: For every 2 pastries you order, get the third for $1");
      Console.Write("-----------------------------");
      Console.WriteLine("How many loaves of bread would you like to order?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to order?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Bread answerBread = new Bread(breadOrder);
      Pastry answerPastry = new Pastry(pastryOrder);
      Console.WriteLine("For" + answerBread + "loaf/ves of bread, and " + answerPastry + "pastry/pastries, your order costs: " + (answerBread.BreadCost() + answerPastry.PastryCost()));
    }
  }
}

// response 1, response 2, response 3