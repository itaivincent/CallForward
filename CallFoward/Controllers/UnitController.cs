using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CallFoward.Data;
using CallFoward.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallFoward.Controllers
{
    public class UnitController : Controller
    {

        private readonly CallForwardContext _context;


        public UnitController(CallForwardContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Unit> units = _context.Units.ToList();
            return View(units);
        }

        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Unit unit)
        {
            try
            {
                _context.Units.Add(unit);
                _context.SaveChanges();
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }
    }
}

