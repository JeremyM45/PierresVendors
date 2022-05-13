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
    }
  }
}