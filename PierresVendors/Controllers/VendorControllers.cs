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
    [HttpGet("/vendor/{name}")]
    public ActionResult Show(string name)
    {
      Vendor foundVendor = Vendor.FindVendor(name);
      // Vendor foundVendor = new Vendor(name, "description");
      return View(foundVendor);
    }
  }
}