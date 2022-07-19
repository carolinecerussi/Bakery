using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CostForOne_Int()
    {
      int breadQuantity = 1;
      double breadCost = 5;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

  }
}





    // [TestMethod]
    // public void IsBreadCost_Integer_True()
    // {
    //   BreadCost testBreadCost = new BreadCost();
    //   Assert.AreEqual(true, testBreadCost.IsBreadCost(5));
    // }
  
    // [TestMethod]
    // public void BreadAmount_GetsBreadAmount_Amount()
    // {
    //   string bAmount = "5"; 
    //   BreadCost newbAmount = new BreadCost(bAmount);

    //   string resultBAmount = newbAmount.BAmount;
    //   Assert.AreEqual(bAmount, resultBAmount );

    // }

// review : 
//