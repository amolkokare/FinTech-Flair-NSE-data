using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIConsume.Models;
using APIConsume.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIConsume.Controllers
{
    public class NseController : Controller
    {

        public readonly NseService _nseService;
        private readonly NseDataServices _nseDataServices;
        public NseController(NseService nseService)
        {
            _nseService = nseService;
        }
        // GET: Nse
        //public ActionResult Index()
        //{
        //    return View(_nseService.Get());

        //}
        public ActionResult Index()
        {
            
            return View(_nseService.Get());

        }
        


        // GET: Nse/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nse = _nseService.Get(id);
            if (nse == null)
            {
                return NotFound();
            }
            return View(nse);
        }

        // GET: Nse/Create
        public ActionResult Create()
        {

            var sa = _nseService.GetNseData();

            var list = new List<string>();
            foreach (var item in sa)
            {
                list.Add(item.SYMBOL);
            }
            ViewBag.list = list;


            return View();
        }


        // POST: Nse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Nse nse)
        {
            if (ModelState.IsValid)
            {
                _nseService.Create(nse);
                return RedirectToAction(nameof(Index));
            }
            return View(nse);
        }

        // GET: Nse/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var nse = _nseService.Get(id);
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
                _nseService.Update(id, nse);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(nse);
            }


        }

        // GET: Nse/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nse = _nseService.Get(id);
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
                var nse = _nseService.Get(id);
                if (nse == null)
                {
                    return NotFound();
                }
                _nseService.Remove(nse.Id);


                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult Index(string watchlist)
        {
            var data = _nseService.SearchW(watchlist);
            return View(data);
        }

       
    }
}