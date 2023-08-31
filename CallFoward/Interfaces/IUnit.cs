using System;
using CallFoward.Models;
namespace CallFoward.Interfaces
{
	public interface IUnit
	{
		List<Unit> GetUnits();

		Unit GetUnit(int id);

		Unit Create(Unit unit);

		Unit Edit(Unit unit);
	}
}

