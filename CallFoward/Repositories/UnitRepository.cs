using System;
using CallFoward.Data;
using CallFoward.Interfaces;
using CallFoward.Models;
using Microsoft.EntityFrameworkCore;

namespace CallFoward.Repositories
{
	public class UnitRepository : IUnit
	{

        private readonly CallForwardContext _context;

        public UnitRepository(CallForwardContext context)
		{
            _context = context;
		}

        public Unit Create(Unit unit)
        {
            _context.Units.Add(unit);
            _context.SaveChanges();
            return unit;
        }

        public Unit Edit(Unit unit)
        {
            _context.Units.Attach(unit);
            _context.Entry(unit).State = EntityState.Modified;
            _context.SaveChanges();
            return unit;
        }

        public Unit GetUnit(int id)
        {
           Unit unit = _context.Units.Where(u => u.Id == id).FirstOrDefault();
           return unit;
        }

        public List<Unit> GetUnits()
        {
            List<Unit> units = _context.Units.ToList();
            return units;
        }
    }
}

