using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchList.Models;
using WatchList.Services;

namespace WatchList.Controllers
{
    public class NseController : Controller
    {
        private readonly NseService nseService;
        public NseController(NseService nseService)
        {
            this.nseService = nseService;
        }
        // GET: Nse
        public ActionResult Index()
        {
            return View(nseService.Get());
        }

        // GET: Nse/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nse = nseService.Get(id);
            if (nse == null)
            {
                return NotFound();
            }
            return View(nse);
            
        }

        // GET: Nse/Create
       
        public ActionResult Create()
        {
            /*if (ModelState.IsValid)
            {
                nseService.Create(nse);
                return RedirectToAction(nameof(Index));
            }*/
                return View();
        }

        // POST: Nse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Nse nse)
        {
            if (ModelState.IsValid)
            {
                nseService.Create(nse);
                return RedirectToAction(nameof(Index));
            }
            return View(nse);

            /*try
            {
                // TODO: Add insert logic here
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(nse);
            }*/
        }

        // GET: Nse/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var nse = nseService.Get(id);
            if (nse == null)
            {
                return NotFound();
            }
            return View(nse);
           
        }

        // POST: Nse/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Nse nse)
        {
            if (id != nse.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                nseService.Update(id, nse);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(nse);
            }
            /*try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
        }

        // GET: Nse/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nse = nseService.Get(id);
            if (nse == null)
            {
                return NotFound();
            }
            return View(nse);
            
        }

        // POST: Nse/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var nse = nseService.Get(id);
                if (nse == null)
                {
                    return NotFound();
                }
                nseService.Remove(nse.Id);


                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}