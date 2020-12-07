using Microsoft.AspNetCore.Mvc;
using ProjetoChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoChart.Controllers
{
    public class ChartController : Controller
    {
        private readonly Context _context;

        public ChartController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Produto objProductModel = new Produto();
            objProductModel.NomeProduto = "Carro";
            objProductModel.Quantidade = 10;
            return View(objProductModel);
        }

        public ActionResult GetChart()
        {
            return Json(_context.Produto
                // you may add some query to your entitles 
                //.Where()
                .Select(p => new { p.NomeProduto, p.Quantidade}),
                    JsonRequestBehavior.AllowGet);
        }
    }
}
