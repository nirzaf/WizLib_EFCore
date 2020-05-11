using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WizLib_DataAccess.Data;
using WizLib_DataAccess.Migrations;
using WizLib_Model.Models;
using WizLib_Model.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace WizLib.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Book> objList = _db.Books.ToList();
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            BookVM obj = new BookVM();
            obj.PublisherList = _db.Publishers.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Publisher_Id.ToString()
            });
            if (id == null)
            {
                return View(obj);
            }
            //this for edit
            obj.Book = _db.Books.FirstOrDefault(u => u.Book_Id== id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Upsert(Author obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (obj.Author_Id == 0)
        //        {
        //            //this is create
        //            _db.Authors.Add(obj);
        //        }
        //        else
        //        {
        //            //this is an update
        //            _db.Authors.Update(obj);
        //        }
        //        _db.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(obj);

        //}

        //public IActionResult Delete(int id)
        //{
        //    var objFromDb = _db.Authors.FirstOrDefault(u => u.Author_Id == id);
        //    _db.Authors.Remove(objFromDb);
        //    _db.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
