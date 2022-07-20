using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Cafe.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_CostForOne_Int()
    {
      int pastryQuantity = 1;
      double pastryCost = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_Discount_Int()
    {
      int pastryQuantity = 3;
      double pastryCost = 5;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    // public void PastryCost_ThirdHalfOffSixOrdered_Int()
    // {
    //   int pastryQuantity = 6;
    //   double pastryCost = 10;
    //   Pastry pastryOrder = new Pastry(pastryQuantity);
    //   Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }  
  }