using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders;
    private static List<Vendor> _allVendors = new List<Vendor>{};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _allVendors.Add(this);
    }
    public static List<Vendor> GetVendors()
    {
      return _allVendors;
    }
    public static void ClearAll()
    {
      _allVendors.Clear();
    }
    public static Vendor FindVendor(string vendorName)
    {
      foreach (Vendor vendor in _allVendors)
      {
        if(vendor.Name == vendorName)
        {
          return vendor;
        }
      }
      return null;
    }
  }
}