using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassicCar.Data;
using ClassicCar.Models;

namespace ClassicCar.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarDbContext _context;

        public CarsController(CarDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index(string carTransmission, string searchString)
        {
            //use LINQ to get list of Transmission
            IQueryable<string> transmissionQuery = from m in _context.Car orderby m.Transmission select m.Transmission;

            var cars =from m in _context.Car select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Model.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(carTransmission))
            {
                cars = cars.Where(x => x.Transmission == carTransmission);
            }
            var carTransmissionVM = new CarTransmissionViewModel
            {
                Transmission = new SelectList(await transmissionQuery.Distinct().ToListAsync()),
                Cars = await cars.ToListAsync()
            };
                return View(carTransmissionVM);
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Ad_Number == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Bind("Ad_Number,Model,Color, Transmission,AdDate,Fuel,Price,Rating ")]
        public async Task<IActionResult> Create([Bind("Ad_Number,Model,Color,Transmission,AdDate,Fuel,Price,Rating")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [Bind("Ad_Number,Model,Color, Transmission,AdDate,Fuel,Price,Rating ")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ad_Number,Model,Color,Transmission,AdDate,Fuel,Price,Rating")] Car car)
        {
            if (id != car.Ad_Number)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Ad_Number))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Ad_Number == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.FindAsync(id);
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.Ad_Number == id);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From[HttpPost]Index: filter on" + searchString;
        }
    }
}
