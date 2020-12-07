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

        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult GetChart()
        {
            return Json(_context.Produto.Select(p => new { p.NomeProduto,p.Quantidade}));
        }
    }
}
