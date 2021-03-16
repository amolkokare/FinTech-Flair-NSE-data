using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using APIConsume.Models;
using APIConsume.Services;
using cloudscribe.Pagination.Models;
using Microsoft.EntityFrameworkCore;
using APIConsume.Controllers;

namespace APIConsume.Controllers
{

    public class NseDataController : Controller
    {
        
        public readonly NseDataServices _nseDataServices;
        public readonly NseService _nseService;
        public NseDataController(NseDataServices nseDataServices)
        {
            _nseDataServices = nseDataServices;
        }
        


        // It gives whole data
        public ActionResult Index2()
        {
             return View(_nseDataServices.GetNseData());
        }
       


        public ActionResult Index(int PageNumber=1, int PageSize=6)
        {
            var alldata = _nseDataServices.GetNseData().ToList();
            int Exclude = (PageNumber * PageSize) - PageSize;
            var output = alldata
                .Skip(Exclude)
                .Take(PageSize);

            
            return View(output);
            }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nsedata = _nseDataServices.Get(id);
            if (nsedata == null)
            {
                return NotFound();
            }
            return View(nsedata);
        }

        // It gives symbol that we want to search
        [HttpPost]
        public ActionResult Index(string searchValue, string scannerName, string button, string watchlist)
        {
            if (scannerName == "1")
            {
                
                var data = _nseDataServices.searchaway52weekhigh(scannerName);
                return View(data);
            }
            else if(scannerName=="2")
            {
                var data = _nseDataServices.searchaway52weeklow(scannerName);
                return View(data);
                
            }
            else if(scannerName=="3")
            {
                var data = _nseDataServices.Rel_Momentum(scannerName);
                return View(data);
            }
            else if (scannerName == "")
            {
                return View(_nseDataServices.GetNseData());
            }
            else if (scannerName == "4")
            {

                return View(_nseDataServices.Sort(scannerName));
            }
            else if (scannerName == "5")
            {
                
                return View(_nseDataServices.SortA(scannerName));
            }
            else if(button=="first")
            {
                return View(_nseDataServices.sort(scannerName));
            }
            
            else
            {
                var data = _nseDataServices.Search(searchValue);
                return View(data);
            }
        }


        }
    }
