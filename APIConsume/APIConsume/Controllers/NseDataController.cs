using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using APIConsume.Models;

using APIConsume.Services;

namespace APIConsume.Controllers
{
    
    public class NseDataController : Controller
    {
        
        private readonly NseDataServices _nseDataServices;
        public NseDataController(NseDataServices nseDataServices)
        {
            _nseDataServices = nseDataServices;
        }

           public ActionResult Index()
            {
                return View(_nseDataServices.Get());
            }


        
        [HttpPost]
        public ActionResult Index(string searchValue)
        {
           
                var data = _nseDataServices.Search(searchValue);
                return View(_nseDataServices.Search(searchValue));
           
        }

        /*[HttpPost]
        public ActionResult Index(string searchValue)
        {
            var data = _nseDataServices.SearchTime(searchValue);
            return View(_nseDataServices.SearchTime(searchValue));
        }*/




    }
}
