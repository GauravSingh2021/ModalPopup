using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModalPopup.Models;

namespace ModalPopup.Controllers
{
    public class UserController : Controller
    {
        private UserDbContext dbContext;
        public UserController(UserDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            var list = dbContext.usertbl.ToList();
            return View(list);
        }
        public ActionResult CreateEdit(int? id)
        {
            User model = new User();
            if (id.HasValue)
            {
                //Write your get user details code here.  
             
            }
            return PartialView("_CreateEdit", model);

        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEdit(User model)
        {
            dbContext.usertbl.Add(model);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var list = dbContext.usertbl.SingleOrDefault(e => e.Id == id);
            return PartialView("_Edit", list);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(User model)
        {
            dbContext.usertbl.Update(model);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var list = dbContext.usertbl.SingleOrDefault(e => e.Id == id);
            return PartialView("_Details", list);
        }
        public IActionResult Delete(int Id)
        {
            var list = dbContext.usertbl.SingleOrDefault(e => e.Id == Id);
            if (list != null)
            {
                dbContext.usertbl.Remove(list);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
