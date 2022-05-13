using System;
using PierresVendors.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void Vendor_ShouldCreateAnObjectOfTypeVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "des");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendors_ShouldReturnAListOfVendors_ListOfVendors()
    {
      Vendor newVendor = new Vendor("name1", "des");
      Vendor newVendor2 = new Vendor("name2", "des");
      List<Vendor> allVendors = Vendor.GetVendors();
      Assert.AreEqual(2, allVendors.Count);
    }
    [TestMethod]
    public void FindVendor_ShouldReturnASpecificVendorFromName_Vendor()
    {
      Vendor thisOne = new Vendor("this one", "this des");
      Vendor notThisOne = new Vendor("not this one", "not this des");
      Vendor foundVendor = Vendor.FindVendor("this one");
      Assert.AreEqual(thisOne, foundVendor);
      Assert.AreEqual(thisOne.Description, foundVendor.Description);
    }
    [TestMethod]
    public void AddOrder_ShouldAddAnOrderToAVendorsListOfOrders_Vendor()
    {
      Vendor newVendor = new Vendor("name", "des");
      Order newOrder = new Order("test name", "test des", 1);
      newVendor.AddOrder(newOrder);
      Assert.AreEqual(1, newVendor.Orders.Count);
      Assert.AreEqual(newOrder, newVendor.Orders[0]);
    }
  }
}