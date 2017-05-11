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
            var List = new List<note>();
            for (var i = 0; i < 200; i++)
            {
                var ListData = new note
                {
                    category = i % 2,
                    noteday = DateTime.Now.AddDays(i).AddHours(i).AddMinutes(i),
                    description = "預設備註",
                    noteprice= 10000
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