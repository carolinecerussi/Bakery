using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBreadCost_Integer_True()
    {
      BreadCost testBreadCost = new BreadCost();
      Assert.AreEqual(true, testBreadCost.IsBreadCost(5));
    }
  }
}