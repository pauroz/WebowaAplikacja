using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebowaAplikacja.Models;
using WebowaAplikacja.Repositories;

namespace WebowaAplikacja.Controllers
{
    public class NoteController1 : Controller
    {

        private readonly INoteRepository _noteRepositor;
        // 
        private  NoteController1(INoteRepository noteRepositor)
        {
            _noteRepositor = noteRepositor;
        }
        // GET: Note
        public ActionResult Index()
        {
            return View(_noteRepositor.GetAllActive());
        }

        // GET: Note/Details/5
        public ActionResult Details(int id)
        {
            return View(_noteRepositor.Get(id));
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View(new ClassWebApp());
        }

        // POST: Note/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassWebApp classWebApp)
        {

            _noteRepositor.Add(classWebApp);
            return RedirectToAction(nameof(Index));
        }

        // GET: Note/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_noteRepositor.Get(id));
        }

        // POST: Note/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClassWebApp classWebApp)
        {
            _noteRepositor.Update(id, classWebApp);
            return RedirectToAction(nameof(Index));
        }

        // GET: Note/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_noteRepositor.Get(id));
        }

        // POST: Note/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClassWebApp classWebApp)
        {
            
            _noteRepositor.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
