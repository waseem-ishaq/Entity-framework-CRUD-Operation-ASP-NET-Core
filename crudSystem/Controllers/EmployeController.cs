using crudSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace crudSystem.Controllers
{
    public class EmployeController : Controller
    {
        private readonly MyDbContext context;

        public EmployeController(MyDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employes.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Employes model)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
            var emp = new Employes()
                {
                    firstName = model.firstName,
                    lastName = model.lastName,
                    State = model.State,
                    Status = model.Status,
                };
                context.Employes.Add(emp);
                context.SaveChanges();
                TempData["error"] = "Record Saved!";
                return RedirectToAction("Index");
           }
          else 
          {
                TempData["message"] = "Empty field cam't submit";
               return View(model);
          }
            
        }
        public IActionResult Delete(int id)
        {
            var emp = context.Employes.SingleOrDefault(x => x.Id == id);
            context.Employes.Remove(emp);
            context.SaveChanges();
            TempData["error"] = "Record Deleted!";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var emp=context.Employes.SingleOrDefault(y => y.Id == id);
            var results = new Employes()
            {
                firstName = emp.firstName,
                lastName = emp.lastName,
                State = emp.State,
                Status = emp.Status,
            };
            return View(results);
        }
        [HttpPost]
        public IActionResult Edit(Employes model)
        {
            var emp = new Employes()
            {
                Id = model.Id,
                firstName = model.firstName,
                lastName = model.lastName,
                State = model.State,
                Status = model.Status,
            };
            context.Employes.Update(emp);
            context.SaveChanges();
            TempData["error"] = "Record Updated!";
            return RedirectToAction("Index");
            
        }
    }
}
