using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

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
        public ActionResult AddItem(string id, string name) {
            PackList packList = PackList.Lists[id];
            PackItem newPackItem = new PackItem();
            newPackItem.Name = name;
            packList.AddItem(newPackItem);
            return RedirectToAction("Show", new {id = id});
        }
    }
}