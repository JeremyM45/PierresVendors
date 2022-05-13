using System;
using PierresVendors.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void Order_ShouldCreateAnObjectOfTypeOrder_Order()
    {
      Order newOrder = new Order("title", "des", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}