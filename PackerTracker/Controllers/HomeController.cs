using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
   public class HomeController : Controller
    {
        Dictionary<string, PackList> _packingLists = new Dictionary<string, PackList>();
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/NewList")]
        public ActionResult NewList() {
            return View();
        }

        [HttpPost("/NewList")]
        public ActionResult NewList(string listTitle) {
            PackList newList = new PackList(listTitle);
            _packingLists.Add(listTitle, newList);
            return RedirectToAction("Index");
        }
    }
}