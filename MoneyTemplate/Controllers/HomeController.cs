using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyTemplate.Models;

namespace MoneyTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListDetail()
        {
            var book = new MoneyModel().AccountBook.ToList();

            
            var List = new List<note>();
            foreach (var item in book)
            {
                var ListData = new note
                {
                    category = item.Categoryyy,
                    noteday = item.Dateee,
                    description = item.Remarkkk.Length > 10 ? item.Remarkkk.Substring(0,10): item.Remarkkk,
                    noteprice= item.Amounttt
                };
                List.Add(ListData);
            }
            return View(List);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}