using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetVendors();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/vendor/{vendorName}")]
    public ActionResult Show(string vendorName)
    {
      Vendor foundVendor = Vendor.FindVendor(vendorName);
      return View(foundVendor);
    }
    [HttpPost("/vendor/{vendorName}/order")]
    public ActionResult Create(string vendorName, string title, string description, string price, string date)
    {
      Vendor foundVendor = Vendor.FindVendor(vendorName);
      Order newOrder = new Order(title, description, int.Parse(price), date);
      foundVendor.AddOrder(newOrder);
      return View("Show", foundVendor);
    }
  }
}