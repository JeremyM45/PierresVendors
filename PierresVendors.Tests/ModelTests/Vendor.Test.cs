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
  }
}