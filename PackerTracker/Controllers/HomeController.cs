using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Controllers
{
   public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/NewList")]
        public ActionResult NewList() 
        {
            return View();
        }

        [HttpPost("/NewList")]
        public ActionResult NewList(string listTitle) {
            new PackList(listTitle);
            return RedirectToAction("Index");
        }

        [HttpGet("/List/{id}")]
        public ActionResult Show(string id) {
            PackList packList = PackList.Lists[id];
            return View(packList);
        }

        [HttpGet("/List/{id}/NewItem")]
        public ActionResult AddItem(string id) {
            PackList packList = PackList.Lists[id];
            return View(packList);
        }

        [HttpPost("/List/{id}/NewItem")]
        public ActionResult AddItem(string id, string name, string brand, 
                                    double price, double weight, bool isPurchased, bool isPacked) {
            PackList packList = PackList.Lists[id];
            PackItem newPackItem = new PackItem(name, brand, price, weight, isPurchased, isPacked);
            packList.AddItem(newPackItem);
            Console.WriteLine("\nCHECKBOX INPUTS FOUND HERE:",isPurchased.ToString(), isPacked.ToString());
            return RedirectToAction("Show", new {id = id});
        }
    }
}