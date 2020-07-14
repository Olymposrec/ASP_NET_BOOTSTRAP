using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Homepage2()
        {
            return View();
        }
        public ActionResult Homepage3()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message() { Level = 1, Text = "Uyarı Düzeyi 1" });
            messages.Add(new Message() { Level = 2, Text = "Uyarı Düzeyi 2" });
            messages.Add(new Message() { Level = 3, Text = "Uyarı Düzeyi 3" });
            messages.Add(new Message() { Level = 4, Text = "Uyarı Düzeyi 4" });
            return View(messages);
        }
    }
}