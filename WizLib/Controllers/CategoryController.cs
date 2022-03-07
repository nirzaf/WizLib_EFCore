using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WizLib_DataAccess.Data;
using WizLib_Model.Models;

namespace WizLib.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        List<Category> objList = _db.Categories.AsNoTracking().ToList();
        return View(objList);
    }

    public IActionResult Upsert(int? id)
    {
        Category obj = new();
        if (id == null) return View(obj);
        //this for edit
        obj = _db.Categories.FirstOrDefault(u => u.Category_Id == id);
        if (obj == null) return NotFound();
        return View(obj);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Upsert(Category obj)
    {
        if (ModelState.IsValid)
        {
            if (obj.Category_Id == 0)
                //this is create
                _db.Categories.Add(obj);
            else
                //this is an update
                _db.Categories.Update(obj);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        return View(obj);
    }

    public IActionResult Delete(int id)
    {
        Category objFromDb = _db.Categories.FirstOrDefault(u => u.Category_Id == id);
        _db.Categories.Remove(objFromDb);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult CreateMultiple2()
    {
        List<Category> catList = new();
        for (var i = 1; i <= 2; i++)
            catList.Add(new Category {Name = Guid.NewGuid().ToString()});
        //_db.Categories.Add(new Category { Name = Guid.NewGuid().ToString() });
        _db.Categories.AddRange(catList);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult CreateMultiple5()
    {
        List<Category> catList = new();
        for (var i = 1; i <= 5; i++)
            catList.Add(new Category {Name = Guid.NewGuid().ToString()});
        //_db.Categories.Add(new Category { Name = Guid.NewGuid().ToString() });
        _db.Categories.AddRange(catList);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemoveMultiple2()
    {
        IEnumerable<Category> catList = _db.Categories.OrderByDescending(u => u.Category_Id).Take(2).ToList();

        _db.Categories.RemoveRange(catList);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemoveMultiple5()
    {
        IEnumerable<Category> catList = _db.Categories.OrderByDescending(u => u.Category_Id).Take(5).ToList();

        _db.Categories.RemoveRange(catList);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}