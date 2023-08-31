using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CallFoward.Data;
using CallFoward.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CallFoward.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallFoward.Controllers
{
    public class UnitController : Controller
    {

        private readonly IUnit _unitRepo;

        public UnitController(IUnit unitRepo)
        {          
            _unitRepo = unitRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Unit> units = _unitRepo.GetUnits();
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
                unit = _unitRepo.Create(unit);
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details (int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return View(unit);
        }

        private Unit GetUnit(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return unit;
        }



        public IActionResult Edit(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return View(unit);
        }


        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                _unitRepo.Edit(unit);
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }
    }
}

