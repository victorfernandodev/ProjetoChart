using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoChart.Controllers
{
    public class ViewController : Controller
    {
        // GET: ViewController
        public ActionResult Index()
        {
            return View("View");
        }


    }
}
