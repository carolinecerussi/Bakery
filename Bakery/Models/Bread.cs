using System;

namespace Bakery
{
  public class Bread
  {
    public bool IsBreadCost(int breadCost)
    {
    if (breadCost == 5) {
      return true;
    } //IsBreadCost is method/  //logic goes here
    else if(breadCost != 5)
    {
     return false; 
    }
    }
    public string BAmount {get;set;}
    public string BreadCost (string bAmount)
      {
      if(BAmount == bAmount)
      {
         string bAmount;
      } 

      }
    }
  }


  public Bread(int cost, int quantity)
  {
    Cost = cost;
    Quantity = quantity;
  }