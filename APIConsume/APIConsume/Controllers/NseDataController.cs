﻿using System;
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

        // It gives whole data
        public ActionResult Index()
        {
             return View(_nseDataServices.Get());
        }


        // It gives symbol that we want to search
        [HttpPost]
        public ActionResult Index(string searchValue, string scannerName)// 
        {
            if (scannerName == "HighWeek")
            {
                var data = _nseDataServices.searchaway52weekhigh(scannerName);
                return View(data);
            }
            else if(scannerName=="LowWeek")
            {
                var data = _nseDataServices.searchaway52weeklow(scannerName);
                return View(data);
                
            }
            else if(scannerName=="Momentum")
            {
                var data = _nseDataServices.Rel_Momentum(scannerName);
                return View(data);
            }
            else if (scannerName == "None")
            {
                return View(_nseDataServices.Get());
            }
            else if (scannerName == "SortByDescending")
            {

                return View(_nseDataServices.Sort(scannerName));
            }
            else if (scannerName == "SortByAscending")
            {

                return View(_nseDataServices.SortA(scannerName).Take(3));
            }
            else
            {
                var data = _nseDataServices.Search(searchValue);
                return View(data);
            }
        }


        // It gives Max date with Away_52weekhigh,geater close and max Volume
        //[HttpPost]
        //public ActionResult Away52WeekHigh(string scannerName)
        //{
            
        //    var data = _nseDataServices.searchaway52weekhigh(scannerName);
        //    return View(data);
            
        //}

        // It gives Max date with Away_52weeklow,geater close and max Volume
        //[HttpPost]
        //public ActionResult Away52WeekLow(string scannerName)
        //{
        //    var data = _nseDataServices.searchaway52weeklow(scannerName);
        //    return View(data);

        //}

        // It gives Max date with Relative_Volume,geater close and max Volume
        //[HttpPost]
        //public ActionResult Momentum(string scannerName)
        //{
        //    var data = _nseDataServices.Rel_Momentum(scannerName);
        //    return View(data);

        //}


    }
}
