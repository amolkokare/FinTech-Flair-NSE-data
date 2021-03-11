using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using APIConsume.Models;
using APIConsume.Services;
using cloudscribe.Pagination.Models;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult Index2()
        {
             return View(_nseDataServices.Get());
        }

        
        public ActionResult Index(int PageNumber=1, int PageSize=6)
        {
            var alldata = _nseDataServices.Get().ToList();
            int Exclude = (PageNumber * PageSize) - PageSize;
            var output = alldata
                .Skip(Exclude)
                .Take(PageSize);

            
            return View(output);
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
                return View(_nseDataServices.Get());
            }
            else if (scannerName == "4")
            {

                return View(_nseDataServices.sort(scannerName).Take(10));
            }
            else if (scannerName == "5")
            {
                
                return View(_nseDataServices.sortA(scannerName).Take(2));
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
