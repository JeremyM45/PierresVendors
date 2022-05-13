using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorName}/order/new")]
    public ActionResult New(string vendorName)
    {
      Vendor foundVendor = Vendor.FindVendor(vendorName);
      return View(foundVendor);
    }
    [HttpGet("/vendor/{vendorName}/order/{orderId}")]
    public ActionResult Show(string vendorName, string orderId)
    {
      Vendor foundVendor = Vendor.FindVendor(vendorName);
      Order foundOrder = foundVendor.FindOrder(int.Parse(orderId));
      ViewBag.VendorName = vendorName;
      return View(foundOrder);
    }
  }
}