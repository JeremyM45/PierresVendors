using System;
using PierresVendors.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void Vendor_ShouldCreateAnObjectOfTypeVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendors_ShouldReturnAListOfVendors_ListOfVendors()
    {
      Vendor newVendor = new Vendor();
      Vendor newVendor2 = new Vendor();
      List<Vendor> allVendors = GetVendors();
      Assert.AreEqual(2, allVendors.Count);
    }
  }
}